using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static qiqiaoban.Utils.GraphicsPlus;

namespace qiqiaoban
{
    public partial class Form1 : Form
    {
        Bitmap bf_colors;
        Graphics bf_colors_renderer;

        public float zoom = 1f;
        
        /// <summary>
        /// 表示还剩余多少时间
        /// </summary>
        int RemainedSeconds { get; set; }

        /// <summary>
        /// 表示还剩下的板块
        /// </summary>
        List<Board> RemainedBoards = new List<Board>();
        /// <summary>
        /// 表示已经固定的板块
        /// </summary>
        List<Board> FixedBoards = new List<Board>();

        public Board currentBoard;

        /// <summary>
        /// 切换下一个板块
        /// </summary>
        /// <returns></returns>
        public Board SwitchBoard()
        {
            int i = new Random().Next(RemainedBoards.Count);
            Board board = RemainedBoards[i];
            Point newMouse = Point.Round(new PointF(Screen.PrimaryScreen.Bounds.Width/2f, Screen.PrimaryScreen.Bounds.Height / 2f));
            //改变鼠标当前位置
            ChangeMousePoint(newMouse);
            return board;
        }

        public RectangleF OutlineRect { get; set; }

        public Form1()
        {
            InitializeComponent();
            new Size(381, 387);
            Bitmap back1 = new Bitmap(Properties.Resources.level1);
            Bitmap back2 = new Bitmap(Properties.Resources.level2);
            Bitmap back3 = new Bitmap(Properties.Resources.level3);
            LevelsManager.Levels.AddRange(new Level[] {
                new Level(back1,"简单",1,120,new Board[]{
                    new Board(){  Index=0, Shape=new Bitmap(Properties.Resources.青), Location=new PointF(0.25984252f,0),Size=new Size(100,99)},
                    new Board(){  Index=1, Shape=new Bitmap(Properties.Resources.粉), Location=new PointF(0,0.2937685f),Size=new Size(198,99)},
                    new Board(){  Index=2,Shape=new Bitmap(Properties.Resources.橘), Location=new PointF(0.25984252f,0.169139f),Size=new Size(281,140)},
                    new Board(){  Index=3, Shape=new Bitmap(Properties.Resources.绿), Location=new PointF(0.1312336f,0.587537f),Size=new Size(141,140),Origin=new PointF(0.25f,0.25f)},
                    new Board(){  Index=4, Shape=new Bitmap(Properties.Resources.浅蓝), Location=new PointF(0.1312336f,0.587537f),Size=new Size(281,140)},
                    new Board(){  Index=5,Shape=new Bitmap(Properties.Resources.深蓝), Location=new PointF(0.5f,0.587537f),Size=new Size(141,70)},
                    new Board(){  Index=6, Shape=new Bitmap(Properties.Resources.黄), Location=new PointF(0.68421f,0.587537f),Size=new Size(71,140)},
                })
                {
                    OutlineLocation=new Point(103,84),
                    OutLineSize=new Size(381,337),
                    OutlineOpacity=1
                },
                new Level(back2, "中等",2,120, new Board[]
                {
                    new Board(){ Index=0, Shape=new Bitmap(Properties.Resources.黄2), Location=new PointF(0, 0.209059f), Size=new Size(120,60), },
                    new Board(){Index=1, Shape=new Bitmap(Properties.Resources.深蓝2), Location=new PointF(0.251046f,0.414634f), Size=new Size(84,84)},
                    new Board(){ Index=2, Shape=new Bitmap(Properties.Resources.浅蓝2), Location=new PointF(0.251046f, 0), Size=new Size(240,120) },
                    new Board(){ Index=3, Shape=new Bitmap(Properties.Resources.青2),Location=new PointF(0.42887f,0.414634f),Size=new Size(84,84)  },
                    new Board(){ Index=4, Shape=new Bitmap(Properties.Resources.橘2),Location=new PointF(0.502092f,0),Size=new Size(240,120) },
                    new Board(){ Index=5, Shape=new Bitmap(Properties.Resources.粉2), Location=new PointF(0.606694f,0.414634f), Size=new Size(180,60) },
                    new Board(){ Index=6, Shape=new Bitmap(Properties.Resources.绿2), Location=new PointF(0.606694f,0.414634f), Size=new Size(85,168) },
                })
                {
                    OutlineLocation=new Point(52,132),
                    OutLineSize=new Size(478,287),
                    OutlineOpacity =1,
                },
                new Level(back3, "困难",3,120,new Board[]
                {
                    new Board(){Index=0, Shape=new Bitmap(Properties.Resources.深蓝3), Size=new Size(94,102), Location=new PointF(0.4076433f,0), Origin=new PointF(0.25f, 0.25f), },
                    new Board(){ Index=1, Shape=new Bitmap(Properties.Resources.红3), Size=new Size(133,133), Location=new PointF(0.05414f,0.450549f), Origin=new PointF(0.75f, 0.33f) },
                    new Board(){ Index = 2, Shape=new Bitmap(Properties.Resources.粉3), Size=new Size(94,94), Location=new PointF(0.509554f,0.065934f),  },
                    new Board(){ Index=3, Shape=new Bitmap(Properties.Resources.橘3), Size=new Size(133,67), Location=new PointF(0.576433f,0.4203296f) },
                    new Board(){ Index=4, Shape=new Bitmap(Properties.Resources.绿3), Size=new Size(133,133), Location=new PointF(0.477707f,0.3241758f), Origin=new PointF(0.33f, 0.33f), },
                    new Board(){ Index=5, Shape=new Bitmap(Properties.Resources.青3), Size=new Size(67,67), Location=new PointF(0.477707f,0.815934f), Origin=new PointF(0.33f,0.67f), },
                    new Board(){ Index=6,Shape=new Bitmap(Properties.Resources.浅蓝3), Size=new Size(67,67), Location=new PointF(0,0.590659f), Origin=new PointF(0.33f,0.33f), },
                })
                {
                    OutlineLocation = new Point(137,75),
                    OutLineSize = new Size(314,364),
                    OutlineOpacity = 1,
                }
            });
            Level startLevel = LevelsManager.SwitchLevel(1);
            RemainedSeconds = startLevel.Times;
            RemainedBoards.AddRange(startLevel.Boards);
            currentBoard=SwitchBoard();
            bf_colors = new Bitmap(palBlackboard.Width, palBlackboard.Height);
            bf_colors_renderer = Graphics.FromImage(bf_colors);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = $"时间：{RemainedSeconds}s";
            RemainedSeconds--;
        }

        private void palBlackboard_MouseMove(object sender, MouseEventArgs e)
        {
            //技术鼠标坐标
            Point mouse = palBlackboard.PointToClient(MousePosition);
            if (mouse.NearBy(PointFToPoint(currentBoard.Location, OutlineRect.Size, OutlineRect.Location), 40, new Size((int)(currentBoard.Size.Width*zoom), (int)(currentBoard.Size.Height*zoom)), currentBoard.Origin))
            {
                RemainedBoards.MoveTo(currentBoard, FixedBoards);
                lblRemaineds.Text = $"剩余：{RemainedBoards.Count}个";
                palBlackboard.Refresh();
                if (RemainedBoards.Count > 0)
                {
                    Thread.Sleep(500);
                    currentBoard = SwitchBoard();
                }
                else
                {
                    palBlackboard.Refresh();
                    FixedBoards.Clear();
                    lblRemaineds.Text = $"剩余：{RemainedBoards.Count}个";
                    if (LevelsManager.HasNextLevel())
                    {
                        LevelsManager.NextLevel();
                    }
                    else
                    {
                        MessageBox.Show("通关成功！");
                        LevelsManager.SwitchLevel(1);
                    }
                    AdjustOutline();
                    RemainedBoards.AddRange(LevelsManager.CurrentLevel.Boards);
                    currentBoard = SwitchBoard();
                    RemainedSeconds = LevelsManager.CurrentLevel.Times;
                    lblTime.Text = $"时间：{RemainedSeconds}s";
                }
            }
            palBlackboard.Refresh();
        }

        public enum EvaluateMode
        {
            /// <summary>
            /// 丢弃小数部分
            /// </summary>
            Truncate,
            /// <summary>
            /// 不小于的最小整数
            /// </summary>
            Celling,
            /// <summary>
            /// 四舍五入
            /// </summary>
            Round,
            /// <summary>
            /// 不大于的最大整数
            /// </summary>
            Floor,
        }

        /// <summary>
        /// 将板块的相对坐标转换成
        /// </summary>
        /// <returns></returns>
        public Point PointFToPoint(PointF coord, SizeF unit, PointF parent = default(PointF), EvaluateMode mode = EvaluateMode.Round)
        {
            PointF p = new PointF(parent.X, parent.Y);
            p.X += coord.X * unit.Width;
            p.Y += coord.Y * unit.Height;
            switch (mode)
            {
                case EvaluateMode.Truncate:
                    return Point.Truncate(p);
                case EvaluateMode.Celling:
                    return Point.Ceiling(p);
                case EvaluateMode.Round:
                    return Point.Round(p);
                case EvaluateMode.Floor:
                    return new Point((int)Math.Floor(p.X), (int)Math.Floor(p.Y));
                default:
                    break;
            }
            return Point.Truncate(p);
        }

        private void palBlackboard_Paint(object sender, PaintEventArgs e)
        {
            bf_colors_renderer.Clear(Color.Transparent);
            //绘制拼图轮廓
            bf_colors_renderer.DrawImage(LevelsManager.CurrentLevel.Outline, OutlineRect);
            //绘制已经固定好了的板块
            FixedBoards.ForEach(board=>
            {
                Point p = PointFToPoint(board.Location, OutlineRect.Size, OutlineRect.Location);
                bf_colors_renderer.DrawTransformedImage(board.Shape, p, board.Rotation, Size.Round(new SizeF(board.Size.Width * zoom, board.Size.Height * zoom)), PointF.Empty);
            });
            //获取鼠标在当前画板的位置
            Point mouse = palBlackboard.PointToClient(MousePosition);
            //绘制板块
            bf_colors_renderer.DrawTransformedImage(currentBoard.Shape, mouse,
                currentBoard.Rotation, Size.Truncate(new SizeF(currentBoard.Size.Width * zoom, currentBoard.Size.Height * zoom)), currentBoard.Origin);
            Graphics g = e.Graphics;
            //将后台的缓存渲染到前台
            g.DrawImage(bf_colors, Point.Empty);
        }

        public void ChangeMousePoint(Point newMouse)
        {
            Cursor.Position = newMouse;   
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AdjustOutline()
        {
            if (LevelsManager.CurrentLevel.OutLineSize.Width > LevelsManager.CurrentLevel.OutLineSize.Height)
            {
                zoom = (float)palBlackboard.ClientSize.Width / LevelsManager.CurrentLevel.OutLineSize.Width * 0.7f;
            }
            else if (LevelsManager.CurrentLevel.OutLineSize.Width <= LevelsManager.CurrentLevel.OutLineSize.Height)
            {
                zoom = (float)palBlackboard.ClientSize.Height / LevelsManager.CurrentLevel.OutLineSize.Height * 0.7f;
            }
            SizeF OutlineSize = new SizeF(zoom * LevelsManager.CurrentLevel.OutLineSize.Width, zoom * LevelsManager.CurrentLevel.OutLineSize.Height);
            PointF OutlineLoc = new PointF(palBlackboard.ClientSize.Width / 2f - OutlineSize.Width / 2f, palBlackboard.ClientSize.Height / 2f - OutlineSize.Height / 2f);
            OutlineRect = new RectangleF(OutlineLoc, OutlineSize);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            palBlackboard.ClientSize = new Size(ClientSize.Height, ClientSize.Height);
            palBlackboard.Location = Point.Round(new PointF(ClientSize.Width/2f-palBlackboard.Width/2f, 0));
            AdjustOutline();
            bf_colors = new Bitmap(palBlackboard.Width, palBlackboard.Height);
            bf_colors_renderer = Graphics.FromImage(bf_colors);
        }
    }
}
