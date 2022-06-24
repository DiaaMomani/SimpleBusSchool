using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSchool.Classes
{
    internal class playBack
    {
        private int _x, _y, _side;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public int side
        {
            get { return _side; }
            set { _side = value; }
        }
        public int SchoolX
        {
            get; set;
        }
        public int SchoolY
        {
            get; set;
        }
        public int Rock1X
        {
            get; set;
        }
        public int Rock1Y
        {
            get; set;
        }
        public int Rock2X
        {
            get; set;
        }
        public int Rock2Y
        {
            get; set;
        }
        public playBack()
        {
            Rock1X = -50;
            Rock1Y = -50;
            Rock2X = -50;
            Rock2Y = -50;
        }
    }
}   
