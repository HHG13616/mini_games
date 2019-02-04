using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qiqiaoban.Utils
{
    public static class GraphicsPlus
    {
        /// <summary>
        /// 绘制旋转的图像
        /// </summary>
        /// <param name="img"></param>
        /// <param name="rotation"></param>
        /// <param name="location"></param>
        /// <param name="size"></param>
        /// <param name="origin"></param>
        /// <returns></returns>
        public static void DrawTransformedImage(this Graphics g, Image img, Point location, float rotation = 0, SizeF? scale = null, PointF? origin = null)
        {
            if (scale==null)
            {
                //原始大小
                scale = new SizeF(1,1);
            }
            if (origin==null)
            {
                origin = new PointF(0.5f,0.5f);
            }
            //保存当前绘图的状态
            GraphicsState state = g.Save();
            //锁定当前的g对象
            //lock (g)
            {
                //移动绘图到旋转的中心
                float dx = location.X;
                float dy = location.Y;
                g.TranslateTransform(dx, dy);
                //缩放图像
                g.ScaleTransform(scale.Value.Width, scale.Value.Height);
                //旋转图像
                g.RotateTransform(rotation);
                //在原点绘制图像
                g.DrawImage(img, new PointF(-origin.Value.X * img.Width,-origin.Value.Y*img.Height));

            }
            //恢复当前的状态
            g.Restore(state);
        }

        /// <summary>
        /// 绝对缩放
        /// </summary>
        /// <param name="g"></param>
        /// <param name="img"></param>
        /// <param name="location"></param>
        /// <param name="rotation"></param>
        /// <param name="scale"></param>
        /// <param name="origin"></param>
        public static void DrawTransformedImage(this Graphics g, Image img, Point location, float rotation = 0, Size? scale=null, PointF? origin = null)
        {
            if (scale == null)
            {
                //原始大小
                scale = img.Size;
            }
            SizeF fractor = new SizeF((float)scale.Value.Width/img.Width,(float)scale.Value.Height/img.Height);
            DrawTransformedImage(g,img,location,rotation,fractor,origin);
        }

        /// <summary>
        /// 指定点是否在矩形区域内
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Contains(this Rectangle rect, Point p)
        {
            return p.X > rect.Left && p.Y>rect.Top && p.X<rect.Right && p.Y<rect.Bottom;
        }

        /// <summary>
        /// 表示某个点是否在目标点的附近
        /// </summary>
        /// <param name="p"></param>
        /// <param name="target"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static bool NearBy(this Point p, Point target, float rMax = 10f, Size size=default(Size), PointF offset=default(PointF))
        {
            if (offset==default(PointF))
            {
                offset = new PointF(0.5f,0.5f);
            }
            if (size==default(Size))
            {
                size = Size.Empty;
            }
            PointF dp = new PointF(offset.X*size.Width, offset.Y*size.Height);
            float dist = (float)Math.Sqrt((target.X+dp.X-p.X)*(target.X+dp.X-p.X)+ (target.Y+dp.Y - p.Y) * (target.Y+dp.Y - p.Y));
            return dist <= rMax;
        }

        /// <summary>
        /// 在矩形区域内是否有点
        /// </summary>
        /// <param name="p"></param>
        /// <param name="target"></param>
        /// <param name="xyMax"></param>
        /// <returns></returns>
        public static bool NearBy(this Point p, Point target, Size xyMax)
        {
            Size xy = new Size(Math.Abs(p.X-target.X),Math.Abs(p.Y-target.Y));
            return xy.Width<=xyMax.Width&&xy.Height<=xyMax.Height;
        }

        /// <summary>
        /// 移动元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="original"></param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static T MoveTo<T>(this ICollection<T> original, T source, ICollection<T> target, bool keepPosition = false)
        {
            target.Add(source);
            original.Remove(source);
            return source;
        }
    }
}
