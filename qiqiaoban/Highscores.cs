using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qiqiaoban
{
    /// <summary>
    /// 记录历史分数
    /// </summary>
    public static class Highscores
    {
        /// <summary>
        /// 历史分数记录
        /// </summary>
        public readonly static List<int> Scores = new List<int>(); 

        /// <summary>
        /// 测试分数超过了多少玩家
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public static int OverPercent(int player)
        {
            int smallers = Scores.Count(score => player > score);
            return (int)((float)smallers / Scores.Count)*100;
        }
    }
}
