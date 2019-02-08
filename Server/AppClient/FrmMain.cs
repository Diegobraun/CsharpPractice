using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClient
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        async Task Log(string mensagem)
        {
            txtResult.Text = mensagem;
        } 

        private async void btnExecute_Click(object sender, EventArgs e)
        {

            try
            {
                int r = ExecutarWebService();
                txtResult.Text = r.ToString();
            }
            catch(Exception E)
            {
                await Log(E.Message);
            }
            finally
            {

            }
        }

        private int ExecutarWebService()
        {
            var calc = new Proxy.CalcWebService();
            return calc.Soma(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtY.Text));
        }
    }
}
