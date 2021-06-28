using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БК_СПОРТЛАЙН
{
    class USER
    {
        [Key]
        public int ID_user { get; set; }
        public int GameN { get; set; }
        public string FIO_user { get; set; }
        public string Email_user { get; set; }
        public string Phone_user { get; set; }
        
        public string PasportNumber_user { get; set; }
        public string IdentifNumber_user { get; set; }
        public string MestoVIdachi_user { get; set; }
        public string Password_user { get; set; }

        public float balanc_user { get; set; }
        public USER() { }
        public USER( int gn,string email, string fio, string phone,string pasport, string ind, string mesto,string password, float balanc)
        {
            GameN = gn;
            FIO_user = fio;
            Email_user = email;
            Phone_user = phone;
            PasportNumber_user = pasport;
            IdentifNumber_user = ind;
            MestoVIdachi_user = mesto;
            Password_user = password;
            balanc_user = balanc;
        }
    }
}
