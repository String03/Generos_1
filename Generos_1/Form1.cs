﻿using Generos_1.BLL;
using Generos_1.EE;
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

        private Genero LeerGenero()
        {
            return new Genero
            {
                Nombre = txt_nombre_genero.Text.Trim()
            };
        }

        private void btn_alta_genero_Click(object sender, EventArgs e)
        {
            var genero = LeerGenero();
            generoBLL.Alta(genero);
            RefrescarGrillaGeneros();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_nombre_genero.Text = string.Empty;
        }
    }
}
