using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using financeiro;

namespace gestaoSuporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-vindo ao Sistema!"+matematica.Somar(1,2));
        }
    }
}
