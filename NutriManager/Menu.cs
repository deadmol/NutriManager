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
        List<Ingredient> IgList = new List<Ingredient>();
        List<Recettes> ReList = new List<Recettes>();

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
            Ingredients Ingredients = new Ingredients();
            Ingredients.ShowDialog();
        }

        private void recettesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recette recettes = new Recette();
            recettes.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Rbtn_Mn_Re.Checked = true;
            Tv_Mn_Menu.Nodes.Add(Cal_Mn_Calendar.TodayDate.Day.ToString() +"/"+ Cal_Mn_Calendar.TodayDate.Month.ToString() +"/"+ Cal_Mn_Calendar.TodayDate.Year.ToString());
            Tv_Mn_Menu.Nodes.Add("");
            Btn_Mn_Remove.Enabled = false;
            Btn_Mn_Add.Enabled = false;
        }

        private void Rbtn_Mn_Ig_CheckedChanged(object sender, EventArgs e)
        {
            Tv_Mn_ListRe.Nodes.Clear();
            List<Dictionary<string, string>> TempIGList = DAL.DAL.SelectQuery("SELECT * FROM [Ingredients]");
            foreach (var item in TempIGList)
            {
                IgList.Add(new Ingredient(int.Parse(item.ElementAt(0).Value), item.ElementAt(1).Value, int.Parse(item.ElementAt(2).Value), item.ElementAt(3).Value));
                TreeNode node = new TreeNode(int.Parse(item.ElementAt(0).Value) + " " + item.ElementAt(1).Value);
                Tv_Mn_ListRe.Nodes.Add(node);
            }
        }

        private void Rbtn_Mn_Re_CheckedChanged(object sender, EventArgs e)
        {
            Tv_Mn_ListRe.Nodes.Clear();

            List<Dictionary<string, string>> TempReList = DAL.DAL.SelectQuery("SELECT * FROM [Recettes]");
            foreach (var item in TempReList)
            {
                ReList.Add(new Recettes(int.Parse(item.ElementAt(0).Value), item.ElementAt(1).Value, item.ElementAt(2).Value, int.Parse(item.ElementAt(3).Value), int.Parse(item.ElementAt(4).Value), int.Parse(item.ElementAt(5).Value)));
                TreeNode node = new TreeNode(int.Parse(item.ElementAt(0).Value) + " " + item.ElementAt(1).Value);
                Tv_Mn_ListRe.Nodes.Add(node);
            }
        }

        private void Btn_Mn_Add_Click(object sender, EventArgs e)
        {
            Tv_Mn_Menu.Nodes.Add(Tv_Mn_ListRe.SelectedNode.Text.ToString());
        }

        private void Btn_Mn_Remove_Click(object sender, EventArgs e)
        {
            if (Tv_Mn_Menu.Nodes.Count > 0)
            {
                Tv_Mn_Menu.SelectedNode.Remove();
            }
        }

        private void Tv_Mn_Menu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Btn_Mn_Remove.Enabled = true;
        }

        private void Tv_Mn_ListRe_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Btn_Mn_Add.Enabled = true;
        }
        
    }
}
