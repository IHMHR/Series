using System;
using DAL;

namespace SeriesSolution.Classes
{
    class ClsLoja
    {
        public string loja { get; set; }
        public string telefone { get; set; }

        private static DAO_Sql sql;

        public ClsLoja()
        {
            sql = new DAO_Sql(@"Data Source=MARTINELLI-07\SQLEXPRESS;Initial Catalog=series;Integrated Security=True");
        }

        public void InserirLoja()
        {
            try
            {
                sql.InserirDados("loja", string.Format("'{0}','{1}'", loja, telefone));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ApagarLoja()
        {
            try
            {
                sql.ApagarDados("loja", "loja = '" + loja + "'");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlterarLoja()
        {
            try
            {
                string[] campos = {"loja", "telefone"};
                string[] valores = {loja, telefone};
                sql.AlterarDados("loja", campos, valores, "loja = '" + loja + "'");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public System.Data.DataTable VisualizarLojas()
        {
            try
            {
                return sql.VisualizarDados("loja");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
