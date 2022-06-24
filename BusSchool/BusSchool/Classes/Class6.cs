using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSchool.Classes
{
    public class Steps
    {
        public Boolean Right;
        public Boolean Left;
        public Boolean Up;
        public Boolean Down;
        public long time;
        public long time2;
        public Steps(Boolean Right,Boolean Left,Boolean Up,Boolean Down,long time,long time2)
        {
            this.Right = Right;
            this.Left = Left;
            this.Up = Up;
            this.Down = Down;
            this.time = time;
            this.time2 = time2;
        }
    }
}
