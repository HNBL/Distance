using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    internal class Distance
    {

        int foot;
        double inch;
        public Distance(int foot, double inch)
        {

            this .foot = foot;  
            this .inch = inch;


        }

        public override string ToString()
        {
            return Convert .ToString(this.foot) + " '-" + Convert.ToString(this.inch) + "\"";
        }

        public static Distance operator +(Distance dist1, Distance dist2)
        {
            int newfoot = dist1.foot + dist2.foot;
            double newinch = dist1.inch + dist2.inch;
            if (newinch >=12)
            {

                newfoot += (int)(newinch / 12);
                newinch = newinch % 12;
            }
            return (new Distance(newfoot, newinch));
        }
        public static Distance operator -(Distance dist1, Distance dist2) 
        {
            double newinch;
            int newfoot; 
            if(dist1 .inch > dist2.inch) 
            {
            newfoot = dist1.foot -1-  dist2.foot;  
                newinch =dist1 .inch +12 + dist2.inch;
            }
        else
            {

                newfoot = dist1.foot - dist2.foot;
                newinch = dist1.inch - dist2.inch;

            }
           return (new Distance(newfoot, newinch));
        }

        public static bool operator >(Distance dist1, Distance dist2)
        {
            return (dist1.foot *12 +dist1.inch > dist2.foot*12+dist2.inch);

        }
        public static bool operator <(Distance dist1, Distance dist2)
        {
            return (dist1.foot * 12 + dist1.inch < dist2.foot * 12 + dist2.inch);

        }
        public static bool operator >=(Distance dist1, Distance dist2)
        {
            return (dist1.foot * 12 + dist1.inch >= dist2.foot * 12 + dist2.inch);

        }
        public static bool operator <=(Distance dist1, Distance dist2)
        {
            return (dist1.foot * 12 + dist1.inch <= dist2.foot * 12 + dist2.inch);

        }

        public static bool operator ==(Distance dist1, Distance dist2)
        {
            return (dist1.foot ==dist2.foot && dist1.inch == dist2.inch);

        }
        public static bool operator !=(Distance dist1, Distance dist2)
        {
            return (dist1.foot == dist2.foot && dist1.inch == dist2.inch);

        }

        public override bool Equals(object obj)
        {
            Distance dist2 = (Distance)obj;
            return(this.foot == dist2.foot && this.inch == dist2.inch);
        }
        public override int GetHashCode() 
        {
            return this.foot * 12 + (int)this.inch;
        }

    }
}
