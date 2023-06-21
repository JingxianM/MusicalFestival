using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMLibrary
{
    public class Campspot
    {
        public int id { get; }
        //public int tktnr { get; }
        public bool occupid { get; }

        public Campspot(int id, bool occupid)
        {
            this.id = id;
            //this.tktnr = tktnr;
            this.occupid = occupid;
        }

        public override string ToString()
        {
            return id.ToString();
        }
    }
}
