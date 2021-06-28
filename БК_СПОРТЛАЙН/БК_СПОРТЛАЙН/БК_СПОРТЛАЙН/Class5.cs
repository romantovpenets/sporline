using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БК_СПОРТЛАЙН
{
    class stavka
    {
    
        [Key]
        public int ID_st { get; set; }
        public string vid_sport { get; set; }
        public float kfP1 { get; set; }
        public float kfX { get; set; }
        public float kfP2 { get; set; }
        public string vremya { get; set; }
        public string nameT1 { get; set; }
        public string nameT2 { get; set; }
        public stavka() { }
        public stavka(string vid,float k1,float k2,float k3,string v,string n1,string n2)
        {
            vid_sport = vid;
            kfP1 = k1;
            kfX = k2;
            kfP2 = k3;
            vremya = v;
            nameT1 = n1;
            nameT2 = n2;
        }

    }
}
