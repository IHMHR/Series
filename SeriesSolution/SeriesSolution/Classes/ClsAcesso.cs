using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesSolution.Classes
{
    class ClsAcesso
    {
        public DateTime dtAcesso { get; set; }
        public decimal vlrTotal { get; set; }
        public int parcelas { get; set; }
        public decimal vlrFrete { get; set; }
        public string tipoFrete { get; set; }
        public int tempoFrete { get; set; }
        public string url { get; set; }
        public int LojaID { get; set; }
        public int SeriadoID { get; set; }
    }
}
