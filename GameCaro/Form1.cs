using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {        
        #region Properties
        ChessBoardManager ChessBoard;

        SocketManager socket;
        #endregion
        public Form1()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlChessBoard, txbPlayerName, picbMark, picbAvatar);
            ChessBoard.PlayerMarked += chessBoard_PlayerMarked;
            ChessBoard.EndedGame +=chessBoard_EndedGame;
            
            prcbCountDown.Step = Cons.COOL_DOWN_STEP;
            prcbCountDown.Maximum = Cons.COOL_DOWN_TIME;
            prcbCountDown.Value = 0;

            tmCountDown.Interval = Cons.COOL_DOWN_INTERVAL;

            socket = new SocketManager();

            //Game moi
            NewGame();

        }

        #region Methods

        void EndGame()
        {
            tmCountDown.Stop();
            pnlChessBoard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
        }

        void NewGame()
        {
            prcbCountDown.Value = 0;
            tmCountDown.Stop();
            undoToolStripMenuItem.Enabled = true;
            ChessBoard.drawChessBoard();
        }

        void Undo()
        {
            ChessBoard.Undo();
            ChessBoard.Undo();
            prcbCountDown.Value = 0;
            tmCountDown.Stop();
        }

        void Quit()
        {
            Application.Exit();
        }

        void chessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            tmCountDown.Start();
            pnlChessBoard.Enabled = false;
            prcbCountDown.Value = 0;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, e.ClickedPoint));

            undoToolStripMenuItem.Enabled = false;
            Listen();
        }

        private void chessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void tmCountDown_Tick(object sender, EventArgs e)
        {
            prcbCountDown.PerformStep();

            if(prcbCountDown.Value >= prcbCountDown.Maximum){
                tmCountDown.Stop();
                undoToolStripMenuItem.Enabled = false;
                if (pnlChessBoard.Enabled == true)
                {
                    MessageBox.Show("Bạn thua rồi! \nChúc bạn may mắn lần sau", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Chúc mừng! \nBạn đã thắng", "Thông báo");
                }
                pnlChessBoard.Enabled = false;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, new Point()));
            pnlChessBoard.Enabled = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
            socket.Send(new SocketData((int)SocketCommand.UNDO, new Point()));
            undoToolStripMenuItem.Enabled = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Cảnh báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Cancel)
                e.Cancel = true;
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, new Point()));
                }
                catch { }   
            }
                          
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            socket.IP = txbIP.Text;

            if (!socket.ConnectServer())
            {
                //socket.isServer = true;
                pnlChessBoard.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                //socket.isServer = false;
                pnlChessBoard.Enabled = false;
                Listen();
            }
        }

        void Listen() 
        {
            try
            {
                Thread listenThread = new Thread(() =>
                {
                    try
                    {
                        SocketData data = (SocketData)socket.Receive();
                        ProcessData(data);
                    }
                    catch
                    {

                    }
                    
                });
                listenThread.IsBackground = true;//Chương trình tắt thì luồng cũng tắt
                listenThread.Start();
            }
            catch { }
 
        }

        void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBoard.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(()=>{
                        prcbCountDown.Value = 0;
                        pnlChessBoard.Enabled = true;
                        tmCountDown.Start();
                        ChessBoard.OtherPlayerMark(data.Point);
                        undoToolStripMenuItem.Enabled = true;
                    }));
                    break;
                case (int)SocketCommand.UNDO:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        Undo();   
                    }));
                    break;
                case (int)SocketCommand.QUIT:
                    tmCountDown.Stop();
                    MessageBox.Show("Đối thủ đã bỏ cuộc! \nHẹn bạn lần sau", "Thông báo");
                    break;
                default:
                    break;
            }
            Listen();
        }

        private void Form1_Show(object sender, EventArgs e)
        {
            //txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            //if (string.IsNullOrEmpty(txbIP.Text))
            //{
            //    txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            //}
        }
        #endregion      

    }
}
