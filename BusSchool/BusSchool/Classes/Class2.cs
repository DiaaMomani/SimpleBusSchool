using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSchool.Classes
{
    public static class Game
    {
        public static long Max_Score =-1;
        public static long Min_Score =7000;
        public static long Max_Duration =-1;
        public static long Min_Duration =7000;
        public static long Total_Duration=0;
        public static long cur_Duration = 0;
        public static long cur_Score = 0;
        public static long NOG = 0;
        public static List<Player> playerList = new List<Player>();
        public static int idx;
        public static List<Round> Rounds = new List<Round>();
        public static Round cur_Round;
        public static int level=0;
        public static List<History> H = new List<History>();
        public static List<Steps> StepsList = new List<Steps>();
        public static long cur_time=0;
        
    }
}
