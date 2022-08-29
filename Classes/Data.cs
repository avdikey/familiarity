using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace familiarity_wpf
{
    class Data
    {
        public static string[] Players { get; set; }
        public static int[] Players_gender;//1 - male, 2 - female
        public static bool[] player_have_gender;
        public static bool First_launch { get; set; } = true;
        public static int language = 0;//0-eng,1-ru,2-uk
        public static List<string> questionMale = new List<string>();
        public static List<string> questionFemale = new List<string>();
        public static List<string> questionEndless = new List<string>();

        public static bool Endless { get; set; }
        public static bool Window_Choose_Sex { get; set; } = false;
        public static bool New_Players_Changes { get; set; } = false;
        public static void Make_Size_Arrays()
        {
            Players_gender = new int[Players.Length];
            player_have_gender = new bool[Players.Length];
            for (int i = 0; i > Players_gender.Length; i++)
            {
                Players_gender[i] = 0;
                player_have_gender[i] = false;
            }
        }
    }
}
