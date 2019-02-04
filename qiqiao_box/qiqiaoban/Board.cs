using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qiqiaoban
{
    public class Board
    {
        public int Index { get; set; }
        /// <summary>
        /// 板块类型
        /// </summary>
        public Bitmap Shape { get; set; }

        /// <summary>
        /// 板块的大小
        /// </summary>
        public Size @Size { get; set; }

        /// <summary>
        /// 板块旋转角度
        /// </summary>
        public float Rotation { get; set; }

        /// <summary>
        /// 板块正确的位置
        /// </summary>
        public PointF Location { get; set; }

        /// <summary>
        /// 表示当前的偏差位置在多少范围之内
        /// </summary>
        public Size Offset { get; set; }

        public PointF Origin { get; set; }

        public Board()
        {
            Offset = new Size(20,20);
            Origin = new PointF(0.5f,0.5f);
        }
    }
}
