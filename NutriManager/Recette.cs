using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NutriManager
{
    public partial class Recette : Form
    {
        public Recette()
        {
            InitializeComponent();
        }

        private void Btn_Re_AjoutIg_Click(object sender, EventArgs e)
        {
            Ingrédients ig = new Ingrédients();
            ig.ShowDialog();
        }
    }
}
