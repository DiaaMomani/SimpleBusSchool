using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSchool.Classes
{
    public class History
    {
        public string profile_name { set; get; }
        public DateTime date { set; get; }
        public long duration { set; get; }
        public long score { set; get; }
        public int level { set; get; }
        public List<Steps> StepsList1 = new List<Steps>();
        public History(string profile_name,DateTime date,long duration,long score,int level)
        {
            this.profile_name = profile_name;
            this.date = date;
            this.duration = duration;
            this.score = score;
            this.level = level;

        }
        public override bool Equals(Object o)
        {
            History obj = o as History;
            return profile_name.Equals(obj.profile_name) && date.Equals(obj.date)
                && duration.Equals(obj.duration) && score.Equals(obj.score) && level.Equals(obj.level);
        }
        

    }
}
