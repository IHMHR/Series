using System;
using DAL;

namespace SeriesSolution.Classes
{
    class ClsSerie
    {
        public string seriado { get; set; }
        public string descricao { get; set; }
        public int temporadas { get; set; }
        public double nota { get; set; }
        public DateTime dtLancamento { get; set; }
        public DateTime dtUltimoEpisodio { get; set; }
        public int situacaoID { get; set; }

        private static DAO_Sql sql;

        public ClsSerie()
        {
            sql = new DAO_Sql(@"Data Source=MARTINELLI-07\SQLEXPRESS;Initial Catalog=series;Integrated Security=True");
        }

        public void InserirSerie()
        {
            try
            {
                string dt1 = string.Empty;
                string dt2 = string.Empty;
                string val = string.Empty;

                dt1 = dtLancamento.ToString("yyyy-MM-dd");

                if (dtUltimoEpisodio.CompareTo(DateTime.Parse("01/01/0001 00:00:00")) == 0)
                    val = string.Format(@"'{0}','{1}',{2},{3},'{4}',NULL,{5}", seriado, descricao, temporadas, nota.ToString().Replace(",","."), dt1, situacaoID);
                else
                    val = string.Format(@"'{0}','{1}',{2},{3},'{4}','{5}',{6}", seriado, descricao, temporadas, nota.ToString().Replace(",", "."), dt1, dtUltimoEpisodio.ToString("yyyy-MM-dd"), situacaoID);
                //val = string.Format(@"'{0}','{1}',{2},{3},'{4}','{5}',{6}", seriado, descricao, temporadas, nota, dt1, dt2, situacaoID);

                sql.SPsemRetorno("usp_InserirSeriado", val);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
