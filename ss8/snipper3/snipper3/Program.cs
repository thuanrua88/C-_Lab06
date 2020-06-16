using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper3
{
    class IntelliSenseDemo : TimeZone
    {
        public override string DayLightName
        {
            get
            {
                throw new Exception("method or operation is not implemented");
            }
        }
        public override System.Globalization.DaylightTime GetDaylightChanges(int year)
        {
            throw new Exception("The method operation is not implemented");
        }
        public override TimeSpan GetUtcOffset(DateTime time)
        {
            throw new Exception("The method or operation is not implemented");
        }
        public override string StandardName
        {
            get
            {
                throw new Exception("The method or operation is not mplemented.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
