using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using global::推箱子.Properties;

namespace 推箱子
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design")]
    public partial class Renderer : UserControl
    {
        /// <summary>
        /// 通过调整此参数可以改变玩家在格子中的相对位置[0,1]，0表示最左上角，1表示最右下角，0.5f表示在格子中居中
        /// </summary>
        public PointF playerPosInGrid = new PointF(0.5f, 0.5f);

        /// <summary>
        /// 新关卡
        /// </summary>
        public void NewLevel(string level="")
        {
            InitPos();
        }

        /// <summary>
        /// 当玩家把箱子搬进目的地的时候，会发生此事件
        /// </summary>
        [Browsable(true)]
        public event Action<int> 闯关完成;

        #region 预加载所有图片
        Bitmap boxImg = new Bitmap(Resources.box);
        Bitmap xrzImg = new Bitmap(Resources.仙人掌);
        Bitmap destImg = new Bitmap(Resources.红色坐标);
        Bitmap successImng = new Bitmap(Resources.对勾);
        Bitmap bg = new Bitmap(Properties.Resources.大海背景2);
        //猴子动画
        Dictionary<string, List<Bitmap>> playerImg = new Dictionary<string, List<Bitmap>>() { };
        //抱着箱子时等待的动画
        Dictionary<string, List<Bitmap>> watingImg = new Dictionary<string, List<Bitmap>>() { };
        //走动的动画
        Dictionary<string, List<Bitmap>> walkingImg = new Dictionary<string, List<Bitmap>>() { };
        //抱着箱子走动的动画
        Dictionary<string, List<Bitmap>> carryingImg = new Dictionary<string, List<Bitmap>>() { };
        //站立不动时的动画
        Dictionary<string, List<Bitmap>> idleImg = new Dictionary<string, List<Bitmap>>() { };
        #endregion

        /// <summary>
        /// 背景缓存
        /// </summary>
        protected Bitmap back;

        /// <summary>
        /// 通过改变此画笔，可以改变网格线的样式，默认2个单位长度的灰色线条
        /// </summary>
        protected Pen gridPen = new Pen(Brushes.Gray, 2);

        /// <summary>
        /// 表示是否将箱子移入目的地
        /// </summary>
        public bool success = false;

        /// <summary>
        /// 网格大小
        /// </summary>
        public Size GridSize { get; set; }

        public Random rnd = new Random(DateTime.Now.Millisecond);

        #region 物体位置
        /// <summary>
        /// 表示玩家是否正在搬运箱子
        /// </summary>
        public bool boxing = false;
        /// <summary>
        /// 表示是否将箱子成功搬运到目的地
        /// </summary>
        public bool boxed = false;

        /// <summary>
        /// 存放着所有物体的位置，通过改变该列表的元素可以改变地图
        /// </summary>
        public List<Point> points = new List<Point>();
        /// <summary>
        /// 箱子初始位置
        /// </summary>
        public Point boxPos;
        public float boxZoom = 0.5f;
        public RectangleF boxRect;
        /// <summary>
        /// 目的地初始位置
        /// </summary>
        public Point destPos;
        public Rectangle destRect;
        /// <summary>
        /// 目的地缩放
        /// </summary>
        public float destZoom = 0.6f;
        /// <summary>
        /// 玩家初始位置
        /// </summary>
        public Point playerPos;
        public float playerDist, playerDest;
        public PointF playerOrigin=new PointF(0.5f, 0.5f);
        public RectangleF playerRect;
        public List<Point> xrzPos = new List<Point>(6);
        public List<RectangleF> xrzRects = new List<RectangleF>();
        public float xrzZoom = 0.5f;

        public float playerImgIndex = 0;
        /// <summary>
        /// 玩家的状态，根据不同的状态切换不同的动画显示
        /// </summary>
        public string playerStatus = "right";
        public float playerZoom = 0.65f;
        /// <summary>
        /// 通过改变此参数可以改变玩家的移动速度
        /// </summary>
        public float SpeedX;
        public float SpeedY;
        /// <summary>
        /// 玩家动画播放的速度，数值越大，播放速度越快，取值范围(0,1]， 1表示每帧播放一帧动画
        /// </summary>
        public float playerAni = 0.1f;
        #endregion

        /// <summary>
        /// 初始化障碍位置
        /// </summary>
        public void InitPos()
        {
            points.Clear();
            xrzPos.Clear();
            xrzRects.Clear();
            success = false;
            boxed = false;
            boxing = false;
            playerImg = idleImg;
            do
            {
                boxPos = new Point(rnd.Next(1, 7), rnd.Next(1, 7));
            } while ((points.Count(pos => pos.X == boxPos.X && pos.Y == boxPos.Y) > 0));
            points.Add(boxPos);
            boxRect = new RectangleF((boxPos.X - 1) * GridSize.Width + GridSize.Width / 2f - boxImg.Width * boxZoom / 2f, (boxPos.Y - 1) * GridSize.Height + GridSize.Height / 2f - boxImg.Height * boxZoom / 2f, boxImg.Width * boxZoom, boxImg.Height * boxZoom);
            do
            {
                destPos = new Point(rnd.Next(1, 7), rnd.Next(1, 7));
            } while ((points.Count(pos => pos.X == destPos.X && pos.Y == destPos.Y) > 0));
            points.Add(destPos);
            destRect = new Rectangle(new Point((destPos.X - 1) * GridSize.Width, (destPos.Y - 1) * GridSize.Height), GridSize);
            do
            {
                playerPos = new Point(rnd.Next(1, 7), rnd.Next(1, 7));
            } while (points.Count(pos => pos.X == playerPos.X && pos.Y == playerPos.Y) > 0);
            Bitmap player = playerImg[playerStatus][(int)playerImgIndex];
            playerRect = new RectangleF((playerPos.X - 1) * GridSize.Width + GridSize.Width / 2f - player.Width * playerZoom / 2f, (playerPos.Y - 1) * GridSize.Height + GridSize.Height / 2f - player.Height * playerZoom / 2f, player.Width * playerZoom, player.Height * playerZoom);
            points.Add(playerPos);

            int count = rnd.Next(3, 7);
            for (int i = 0; i < count; i++)
            {
                Point pt = new Point(rnd.Next(1, 7), rnd.Next(1, 7));
                while (points.Count(pos => pos.X == pt.X && pos.Y == pt.Y) > 0)
                {
                    pt = new Point(rnd.Next(1, 7), rnd.Next(1, 7));
                }
                xrzRects.Add(new RectangleF((pt.X - 1) * GridSize.Width + GridSize.Width / 2f - xrzImg.Width * xrzZoom / 2f, (pt.Y - 1) * GridSize.Height + GridSize.Height / 2f - xrzImg.Height * xrzZoom / 2f, xrzImg.Width * xrzZoom, xrzImg.Height * xrzZoom));
                xrzPos.Add(pt);
                points.Add(pt);
            }
        }

        public Renderer()
        {
            #region 控件样式
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ContainerControl, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.Selectable, false);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserMouse, true);
            #endregion
            InitializeComponent();
            #region 加载猴子动画
            #region 未抱箱站立动画
            idleImg["right"] = new List<Bitmap>() { new Bitmap(Properties.Resources.idle_right1), new Bitmap(Properties.Resources.idle_right2), new Bitmap(Properties.Resources.idle_right3), };
            idleImg["left"] = new List<Bitmap>() { new Bitmap(Properties.Resources.idle_left1), new Bitmap(Properties.Resources.idle_left2), new Bitmap(Properties.Resources.idle_left3), };
            idleImg["up"] = new List<Bitmap>() { new Bitmap(Properties.Resources.idle_up1), new Bitmap(Properties.Resources.idle_up2), new Bitmap(Properties.Resources.idle_up3), };
            idleImg["down"] = new List<Bitmap>() { new Bitmap(Properties.Resources.idle_down1), new Bitmap(Properties.Resources.idle_down2), new Bitmap(Properties.Resources.idle_down3), };
            #endregion
            #region 未抱箱行走动画
            walkingImg["right"] = new List<Bitmap>() { new Bitmap(Properties.Resources.walking_right1), new Bitmap(Properties.Resources.walking_right2), new Bitmap(Properties.Resources.walking_right3), new Bitmap(Properties.Resources.walking_right4), };
            walkingImg["left"] = new List<Bitmap>() { new Bitmap(Properties.Resources.walking_left1), new Bitmap(Properties.Resources.walking_left2), new Bitmap(Properties.Resources.walking_left3), new Bitmap(Properties.Resources.walking_left4), };
            walkingImg["up"] = new List<Bitmap>() { new Bitmap(Properties.Resources.walking_up1), new Bitmap(Properties.Resources.walking_up2), };
            walkingImg["down"] = new List<Bitmap>() { new Bitmap(Properties.Resources.walking_down1), new Bitmap(Properties.Resources.walking_down2), };
            #endregion
            #region 抱箱站立动画
            watingImg["right"] = new List<Bitmap>() { new Bitmap(Properties.Resources.waiting_right1), new Bitmap(Properties.Resources.waiting_right2), new Bitmap(Properties.Resources.waiting_right3), };
            watingImg["left"] = new List<Bitmap>() { new Bitmap(Properties.Resources.waiting_left1), new Bitmap(Properties.Resources.waiting_left2), new Bitmap(Properties.Resources.waiting_left3), };
            watingImg["up"] = new List<Bitmap>() { new Bitmap(Properties.Resources.waiting_up1), new Bitmap(Properties.Resources.waiting_up2), new Bitmap(Properties.Resources.waiting_up3), };
            watingImg["down"] = new List<Bitmap>() { new Bitmap(Properties.Resources.waiting_down1), new Bitmap(Properties.Resources.waiting_down2), new Bitmap(Properties.Resources.waiting_down3), };
            #endregion
            #region 抱箱行走动画
            carryingImg["right"] = new List<Bitmap>() { new Bitmap(Properties.Resources.carrying_right1), new Bitmap(Properties.Resources.carrying_right2), new Bitmap(Properties.Resources.carrying_right3), new Bitmap(Properties.Resources.carrying_right4), };
            carryingImg["left"] = new List<Bitmap>() { new Bitmap(Properties.Resources.carrying_left1), new Bitmap(Properties.Resources.carrying_left2), new Bitmap(Properties.Resources.carrying_left3), new Bitmap(Properties.Resources.carrying_left4), };
            carryingImg["up"] = new List<Bitmap>() { new Bitmap(Properties.Resources.carrying_up1), new Bitmap(Properties.Resources.carrying_up2), };
            carryingImg["down"] = new List<Bitmap>() { new Bitmap(Properties.Resources.carrying_down1), new Bitmap(Properties.Resources.carrying_down2), };
            #endregion
            #endregion
            //设置玩家的初始动画集
            playerImg = idleImg;
        }

        public Renderer(IContainer container) : this()
        {
            container.Add(this);
        }

        /// <summary>
        /// 该函数可以将裁剪区域设置透明图片的非透明区域，实现真正的透明
        /// </summary>
        /// <param name="img"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        private unsafe static GraphicsPath subGraphicsPath(Image img, SizeF? scale = null)
        {
            if (img == null) return null;

            if (scale == null)
            {
                scale = new SizeF(1, 1);
            }

            // 建立GraphicsPath, 给我们的位图路径计算使用   
            GraphicsPath g = new GraphicsPath(FillMode.Alternate);

            Bitmap bitmap = new Bitmap(img, (int)(img.Width * scale.Value.Width + 0.5), (int)(img.Height * scale.Value.Height + 0.5));

            int width = bitmap.Width;
            int height = bitmap.Height;
            BitmapData bmData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte* p = (byte*)bmData.Scan0;
            int offset = bmData.Stride - width * 3;
            int p0, p1, p2;
            // 记录左上角0，0座标的颜色值  
            p0 = p[0];
            p1 = p[1];
            p2 = p[2];
            int start = -1;
            // 行座标 ( Y col )   
            for (int Y = 0; Y < height; Y++)
            {
                // 列座标 ( X row )   
                for (int X = 0; X < width; X++)
                {
                    if (start == -1 && (p[0] != p0 || p[1] != p1 || p[2] != p2))     //如果 之前的点没有不透明 且 不透明   
                    {
                        start = X;                            //记录这个点  
                    }
                    else if (start > -1 && (p[0] == p0 && p[1] == p1 && p[2] == p2))      //如果 之前的点是不透明 且 透明  
                    {
                        g.AddRectangle(new Rectangle(start, Y, X - start, 1));    //添加之前的矩形到  
                        start = -1;
                    }

                    if (X == width - 1 && start > -1)        //如果 之前的点是不透明 且 是最后一个点  
                    {
                        g.AddRectangle(new Rectangle(start, Y, X - start + 1, 1));      //添加之前的矩形到  
                        start = -1;
                    }
                    //if (p[0] != p0 || p[1] != p1 || p[2] != p2)  
                    //    g.AddRectangle(new Rectangle(X, Y, 1, 1));  
                    p += 3;                                   //下一个内存地址  
                }
                p += offset;
            }
            bitmap.UnlockBits(bmData);
            bitmap.Dispose();
            // 返回计算出来的不透明图片路径   
            return g;
        }

        /// <summary>  
        /// 调用此函数后使图片透明  
        /// </summary>  
        /// <param name="control">需要处理的控件</param>  
        /// <param name="img">控件的背景或图片，如PictureBox.Image  
        /// 或PictureBox.BackgroundImage</param>  
        public static void ControlTrans(Control control, Image img, SizeF? scale = null)
        {
            GraphicsPath g;
            g = subGraphicsPath(img, scale);
            if (g == null)
                return;
            control.Region = new Region(g);
        }

        /// <summary>
        /// 主要绘制逻辑
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //绘制背景
            e.Graphics.DrawImage(bg, ClientRectangle);
            for (int i = 1; i < 6; i++)
            {
                //绘制横线
                e.Graphics.DrawLine(Pens.Gray, 0, i * GridSize.Width, ClientSize.Width, i * GridSize.Height);
                //绘制竖线
                e.Graphics.DrawLine(Pens.Gray, i * GridSize.Width, 0, i * GridSize.Width, i * ClientSize.Height);
            }
            e.Graphics.FillRectangle(Brushes.Orange, GridSize.Width * (destPos.X - 1) + 1, GridSize.Height * (destPos.Y - 1) + 1, GridSize.Width - 1, GridSize.Height - 1);
            //绘制目的地
            Bitmap dest = success ? successImng : destImg;
            e.Graphics.DrawImage(dest, GridSize.Width * (destPos.X - 1) + GridSize.Width / 2f - dest.Width / 2f * destZoom, GridSize.Height * (destPos.Y - 1) + GridSize.Height / 2f - dest.Height / 2f * destZoom, dest.Width * destZoom, dest.Height * destZoom);
            //绘制障碍物
            foreach (var xrz in xrzRects)
            {
                e.Graphics.DrawImage(xrzImg, xrz);
            }
            //绘制箱子
            if(!boxing)
                e.Graphics.DrawImage(boxImg, boxRect);
            //绘制玩家
            Bitmap player = playerImg[playerStatus][(int)playerImgIndex];
            e.Graphics.DrawImage(player, playerRect);
        }

        private void Renderer_Resize(object sender, EventArgs e)
        {
            Size prevSize = GridSize;
            GridSize = Size.Round(new SizeF(ClientSize.Width / 6f, ClientSize.Height / 6f));
            float scale = GridSize.Height / (float)prevSize.Height;
            if (FindForm() != null)
            {
                back = new Bitmap(FindForm().BackgroundImage, FindForm().ClientSize);
                boxZoom *= scale;
                playerZoom *= scale;
                destZoom *= scale;
                xrzZoom *= scale;
                boxRect = new RectangleF((boxPos.X - 1) * GridSize.Width + GridSize.Width / 2f - boxImg.Width * boxZoom / 2f, (boxPos.Y - 1) * GridSize.Height + GridSize.Height / 2f - boxImg.Height * boxZoom / 2f, boxImg.Width * boxZoom, boxImg.Height * boxZoom);
                Bitmap player = playerImg[playerStatus][(int)playerImgIndex];
                playerRect = new RectangleF((playerPos.X - 1) * GridSize.Width + GridSize.Width / 2f - player.Width * playerZoom / 2f, (playerPos.Y - 1) * GridSize.Height + GridSize.Height / 2f - player.Height * playerZoom / 2f, player.Width * playerZoom, player.Height * playerZoom);
                for (int i = 0; i < xrzRects.Count; i++)
                {
                    xrzRects[i] = new RectangleF((xrzPos[i].X - 1) * GridSize.Width + GridSize.Width / 2f - xrzImg.Width * xrzZoom / 2f, (xrzPos[i].Y - 1) * GridSize.Height + GridSize.Height / 2f - xrzImg.Height * xrzZoom / 2f, xrzImg.Width * xrzZoom, xrzImg.Height * xrzZoom);
                }
            }
        }

        private void Renderer_Load(object sender, EventArgs e)
        {
            Form form = FindForm();
            back = new Bitmap(form.BackgroundImage, form.ClientSize);
            GridSize = Size.Round(new SizeF(ClientSize.Width / 6f, ClientSize.Height / 6f));
            InitPos();
            if (DesignMode)
            {
                animations.Enabled = false;
            }
            else
            {
                animations.Enabled = true;
            }
        }

        /// <summary>
        /// 重新开始
        /// </summary>
        public void Restart()
        {
            InitPos();
        }
        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Renderer_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            if (key.HasFlag(Keys.W) || key.HasFlag(Keys.A) || key.HasFlag(Keys.D) || key.HasFlag(Keys.S))
            {
                if (!Physics.Enabled)
                {
                    playerDist = 0;
                    playerDest = GridSize.Width;
                    switch (key)
                    {
                        case Keys.D:
                            playerStatus = "right";
                            if (playerPos.X<6 && !xrzPos.Contains(new Point(playerPos.X + 1, playerPos.Y)))
                            {
                                Physics.Enabled = true;
                                if (!boxing)
                                {
                                    playerImg = walkingImg;
                                }
                                else
                                {
                                    playerImg = carryingImg;
                                }
                                playerImgIndex = 0;
                                SpeedX = 3;
                                if (playerPos.Y == boxPos.Y && playerPos.X + 1 == boxPos.X)
                                {
                                    playerDest *= 0.65f;
                                }
                            }
                            break;
                        case Keys.A:
                            playerStatus = "left";
                            if (playerPos.X>1 && !xrzPos.Contains(new Point(playerPos.X - 1, playerPos.Y)))
                            {
                                Physics.Enabled = true;
                                if (!boxing)
                                {
                                    playerImg = walkingImg;
                                }
                                else
                                {
                                    playerImg = carryingImg;
                                }
                                playerImgIndex = 0;
                                SpeedX = -3;
                                if (playerPos.Y == boxPos.Y && playerPos.X - 1 == boxPos.X)
                                {
                                    playerDest *= 0.65f;
                                }
                            }
                            break;
                        case Keys.W:
                            playerStatus = "up";
                            if (playerPos.Y>1 && !xrzPos.Contains(new Point(playerPos.X, playerPos.Y-1)))
                            {
                                Physics.Enabled = true;
                                if (!boxing)
                                {
                                    playerImg = walkingImg;
                                }
                                else
                                {
                                    playerImg = carryingImg;
                                }
                                playerImgIndex = 0;
                                SpeedY = -3;
                            }
                            break;
                        case Keys.S:
                            playerStatus = "down";
                            if (playerPos.Y<6 && !xrzPos.Contains(new Point(playerPos.X, playerPos.Y+1)))
                            {
                                Physics.Enabled = true;
                                if (!boxing)
                                {
                                    playerImg = walkingImg;
                                }
                                else
                                {
                                    playerImg = carryingImg;
                                }
                                playerImgIndex = 0;
                                SpeedY = 3;
                                if (playerPos.Y+1 == boxPos.Y && playerPos.X == boxPos.X)
                                {
                                    playerDest *= 1.1f;
                                }
                            }
                            break;
                    }
                }
            }
            playerRect.Width = playerImg[playerStatus][(int)playerImgIndex].Width * playerZoom;
            playerRect.Height = playerImg[playerStatus][(int)playerImgIndex].Height * playerZoom;
            Invalidate();
            playerRect.X = (playerPos.X - 1) * GridSize.Width + playerPosInGrid.X*GridSize.Width - playerOrigin.X*playerRect.Width;
            playerRect.Y = (playerPos.Y - 1) * GridSize.Height + playerPosInGrid.Y * GridSize.Height - playerOrigin.Y * playerRect.Height;
        }

        /// <summary>
        /// 用于玩家的移动更新，物理定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Physics_Tick(object sender, EventArgs e)
        {
            //禁止移动中按键
            if (SpeedX==0 && SpeedY==0)
            {
                if (playerDist + Math.Abs(SpeedY) <= playerDest && playerDist + Math.Abs(SpeedX) <= playerDest)
                {
                    playerRect.X += SpeedX;
                    playerRect.Y += SpeedY;
                    playerDist += Math.Abs(SpeedX + SpeedY);
                }
                else
                {
                    Physics.Enabled = false;
                    playerImgIndex = 0;
                    #region 移动主角
                    playerPos.X += Math.Sign(SpeedX);
                    playerPos.Y += Math.Sign(SpeedY);
                    if (boxPos == playerPos)
                    {
                        boxing = true;
                    }
                    #endregion
                    #region 微调主角，不知道为什么会这样
                    playerRect.X += playerDest - playerDist;
                    playerRect.Y += playerDest - playerDist;
                    #endregion
                    #region 停止移动
                    SpeedX = 0;
                    SpeedY = 0;
                    playerDist = 0;
                    #endregion
                    #region 切换等待动画
                    if (boxing)
                    {
                        playerImg = watingImg;
                    }
                    else
                    {
                        playerImg = idleImg;
                    }
                    #endregion
                    if (playerPos == destPos && boxing)
                    {
                        success = true;
                        闯关完成?.Invoke(0);
                    }
                    playerRect.Width = playerImg[playerStatus][(int)playerImgIndex].Width * playerZoom;
                    playerRect.Height = playerImg[playerStatus][(int)playerImgIndex].Height * playerZoom;
                    playerRect.X = (playerPos.X - 1) * GridSize.Width + playerPosInGrid.X * GridSize.Width - playerOrigin.X * playerRect.Width;
                    playerRect.Y = (playerPos.Y - 1) * GridSize.Height + playerPosInGrid.Y * GridSize.Height - playerOrigin.Y * playerRect.Height;
                }
            }
        }

        /// <summary>
        /// 用于玩家的动画的更新，渲染定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void animations_Tick(object sender, EventArgs e)
        {
            #region 动画处理
            if (playerAni + playerImgIndex > playerImg[playerStatus].Count)
            {
                playerImgIndex = 0;
            }
            else
            {
                playerImgIndex += playerAni;
            }
            Invalidate();
            #endregion
        }
    }
}
