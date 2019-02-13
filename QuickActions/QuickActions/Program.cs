using System.Data.SqlClient;
using System.Data;
using System.Text;
using System;

namespace QuickActions
{
    class Program
    {

        static void Main(string[] args)
        {
            GerarSomas();
            CriaObjetos();
        }

        private static void GerarSomas()
        {
            int X = 0;
            int Y = 0;
            SomaSim(X, Y);
        }

        private static void SomaSim(int x, int y)
        {
            int v = x + y;
        }


        private static void CriaObjetos()
        {
            #region CriacaoObjetos
            var con = new SqlConnection();
            var ds = new DataSet();
            var sb = new StringBuilder();
            #endregion
        }
    }
}
