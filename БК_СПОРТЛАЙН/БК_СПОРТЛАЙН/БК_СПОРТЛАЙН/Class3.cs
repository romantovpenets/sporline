using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БК_СПОРТЛАЙН
{
    class HistoryFinansy
    {
        [Key]
        public int ID_fin { get; set; }
        public int gameNumber { get; set; }
        public string vid_popolnenia { get; set; }
        public string sum { get; set; }
        public string nomercard { get; set; }
        public string vremya { get; set; }

        public HistoryFinansy() { }
        public HistoryFinansy(int gn, string vp, string s, string nc, string v)
        {
           
            gameNumber = gn;
            vid_popolnenia = vp;
            sum = s;
            nomercard = nc;
            vremya = v;
        }
        
    }
}
