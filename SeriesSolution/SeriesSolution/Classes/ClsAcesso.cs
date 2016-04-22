using System;
using DAL;

namespace SeriesSolution.Classes
{
    class ClsAcesso
    {
        public DateTime dtAcesso { get; set; }
        public double vlrTotal { get; set; }
        public int parcelas { get; set; }
        public double vlrFrete { get; set; }
        public string tipoFrete { get; set; }
        public int tempoFrete { get; set; }
        public string url { get; set; }
        public int LojaID { get; set; }
        public int SeriadoID { get; set; }

        private static DAO_Sql sql;

        public ClsAcesso()
        {
            sql = new DAO_Sql(@"Data Source=MARTINELLI-07\SQLEXPRESS;Initial Catalog=series;Integrated Security=True");
        }

        public void Inserir()
        {
            try
            {
                string val = string.Empty;
                val = string.Format("'{0}',{1},{2},{3},'{4}',{5},'{6}',{7},{8}", dtAcesso.ToString("yyyy-MM-dd HH:mm:ss"), vlrTotal.ToString().Replace(",", "."), parcelas, vlrFrete.ToString().Replace(",", "."), tipoFrete, tempoFrete, url, LojaID, SeriadoID);
                sql.SPsemRetorno("usp_InserirVisita", val);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao inserir");
            }
        }
    }
}
