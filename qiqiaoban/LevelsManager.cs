using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qiqiaoban
{
    public static class LevelsManager
    {
        static LevelsManager()
        {
            Current = 1;
        }

        public static int Current { get; set; }

        /// <summary>
        /// 当前关卡
        /// </summary>
        public static Level CurrentLevel { get; set; }

        public static readonly List<Level> Levels = new List<Level>();

        public static Level SwitchLevel(int index)
        {
            CurrentLevel = Levels[index - 1];
            Current = index;
            return CurrentLevel;
        }

        public static Level NextLevel()
        {
            if (Current==Levels.Count)
            {
                return null;
            }
            else
            {
                CurrentLevel = Levels[(++Current) - 1];
                return CurrentLevel;
            }
        }

        public static bool HasNextLevel()
        {
            return Current < Levels.Count;
        }
    }
}
