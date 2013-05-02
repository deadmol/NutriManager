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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingrédientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingrédients Ingredients = new Ingrédients();
            Ingredients.ShowDialog();
        }

        private void recettesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recette recettes = new Recette();
            recettes.ShowDialog();
        }
    }
}
