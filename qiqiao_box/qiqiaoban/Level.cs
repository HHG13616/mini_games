using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qiqiaoban
{
    public class Level
    {
        public int Index { get; set; }
        public String Name { get; set; }

        /// <summary>
        /// 板块信息
        /// </summary>
        public readonly Board[] Boards;

        /// <summary>
        /// 轮廓图
        /// </summary>
        public Bitmap Outline { get; set; }

        /// <summary>
        /// 轮廓图位置
        /// </summary>
        public Point OutlineLocation { get; set; }

        /// <summary>
        /// 轮廓图大小
        /// </summary>
        public Size OutLineSize { get; set; }

        /// <summary>
        /// 轮廓图透明度
        /// </summary>
        public float OutlineOpacity { get; set; }

        /// <summary>
        /// 最大时间
        /// </summary>
        public int Times { get; set; }

        public Level(Bitmap outlinbe, String name="", int index=0, int times = 120, params Board[] boards)
        {
            Boards = boards;
            Name = name;
            Outline = outlinbe;
            Index = index;
            Times = times;
        }
    }
}
