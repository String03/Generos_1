using Generos_1.BLL;
using Generos_1.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generos_1
{
    public partial class Form1 : Form
    {
        private readonly GeneroBLL generoBLL;
        public Form1()
        {
            InitializeComponent();
            generoBLL = GeneroFactory.CrearGenero();
            RefrescarGrillaGeneros();
        }

        private void RefrescarGrillaGeneros()
        {
            grillaGenero.DataSource = null;
            grillaGenero.DataSource = generoBLL.ListarGeneros();
        }
    }
}
