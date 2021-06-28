using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БК_СПОРТЛАЙН
{
    class HistoryStavok
    {
        [Key]
        public  int id_stavki { get; set; }
        public  int autor_stavki { get; set; }
        public string name_stavki { get; set; }
        public string vibor_stavki { get; set; }
        public string kf_stavki { get; set; }
        public string vremya_stavki { get; set; }
        public string summa_stavki { get; set; }
        public string status_stavki { get; set; }
        public HistoryStavok()
        { }
        public HistoryStavok(int autor, string name, string vibor, string kf, string vremya, string summa, string status)
        {
            autor_stavki = autor;
            name_stavki = name;
            vibor_stavki = vibor;
            kf_stavki = kf;
            vremya_stavki = vremya;
            summa_stavki = summa;
            status_stavki = status;
        }
    }
}
