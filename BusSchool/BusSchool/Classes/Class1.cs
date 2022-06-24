using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSchool
{
    public class Player
    {

       
        public string Name { set; get; }
        public string Gender { set; get; }
        public string Age { set; get; }
        public string Image { set; get; }
        public int Theme { set; get; }
        public long Highest_Score { set; get; }
        public long Lowest_Score { set; get; }
        public long Lowest_Dur { set; get; }
        public long Highest_Dur { set; get; }
        public long Total_Dur { set; get; }

        public Player()
        {
            Name = Gender = "";
            Age = "";
            Theme = 1;

        }
        public Player(string Name, string Gender, string Age, string Image,int Theme)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Age = Age;
            this.Image = Image;
            this.Theme = Theme;
            
        }
        public override bool Equals(Object obj)
        {
            Player p = obj as Player;
            if (p == null)
                return false;
            else
                return base.Equals((Player)obj);
        }
    }
}
