using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 推箱子
{
    /// <summary>
    /// 动画类
    /// </summary>
    [Serializable]
    public class Animation
    {
        public Animation()
        {

        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 帧
        /// </summary>
        public ImageList Frames { get; set; }

        /// <summary>
        /// 帧尺寸
        /// </summary>
        public Size FrameSize { get; set; }
    }
}
