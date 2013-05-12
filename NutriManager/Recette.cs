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
        List<Ingredient> IgList = new List<Ingredient>();
        List<Recettes> ReList = new List<Recettes>();
        List<string> UnitList = new List<string>();

        private Recettes GetNodeInList(string ID)
        {
            Recettes tempRe = null;
            foreach (var item in ReList)
            {
                if (item.ID == int.Parse(ID))
                {
                    tempRe = item;
                }
            }
            return tempRe;
        }

        /// <summary>
        /// Recharge le treeview des recettes
        /// </summary>
        private void RecettesReload()
        {
            ReList.Clear();
            Tv_Re_List.Nodes.Clear();
            List<Dictionary<string, string>> TempReList = DAL.DAL.SelectQuery("SELECT * FROM [Recettes]");
            foreach (var item in TempReList)
            {
                ReList.Add(new Recettes(int.Parse(item.ElementAt(0).Value), item.ElementAt(1).Value, item.ElementAt(2).Value, int.Parse(item.ElementAt(3).Value), int.Parse(item.ElementAt(4).Value), int.Parse(item.ElementAt(5).Value)));
                TreeNode node = new TreeNode(int.Parse(item.ElementAt(0).Value) + " " + item.ElementAt(1).Value);
                Tv_Re_List.Nodes.Add(node);
            }
        }


        public Recette()
        {
            InitializeComponent();
        }

        private void Btn_Re_AjoutIg_Click(object sender, EventArgs e)
        {
            Ingredients ig = new Ingredients();
            ig.ShowDialog();
        }

        private void Recette_Load(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> TempReList = DAL.DAL.SelectQuery("SELECT * FROM [Recettes]");
            foreach (var item in TempReList)
            {
                ReList.Add(new Recettes(int.Parse(item.ElementAt(0).Value), item.ElementAt(1).Value, item.ElementAt(2).Value, int.Parse(item.ElementAt(3).Value), int.Parse(item.ElementAt(4).Value), int.Parse(item.ElementAt(5).Value)));
                TreeNode node = new TreeNode(int.Parse(item.ElementAt(0).Value) + " " + item.ElementAt(1).Value);
                Tv_Re_List.Nodes.Add(node);
            }

            List<Dictionary<string, string>> TempIGList = DAL.DAL.SelectQuery("SELECT * FROM [Ingredients]");
            foreach (var item in TempIGList)
            {
                IgList.Add(new Ingredient(int.Parse(item.ElementAt(0).Value), item.ElementAt(1).Value, int.Parse(item.ElementAt(2).Value), item.ElementAt(3).Value));
                Cbox_Re_Ingredients.Items.Add(item.ElementAt(1).Value);
            }            

        }//end load

        private void Tv_Re_List_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Recettes tempRe = GetNodeInList(e.Node.Text.Substring(0, e.Node.Text.IndexOf(" ")));
            Txt_Re_Nom.Text = tempRe.NOM;
            Txt_Re_Details.Text = tempRe.DETAILS;
            Txt_Re_TpsPrepa.Text = tempRe.PREPARATION.ToString();
            Txt_Re_TpsCuisson.Text = tempRe.CUISSON.ToString();
            Txt_Re_NbPers.Text = tempRe.NBPERS.ToString();

        }

        private void Btn_Re_Sauvegarde_Click(object sender, EventArgs e)
        {
            Recettes tempRe = new Recettes();
            tempRe.NOM = Txt_Re_Nom.Text;
            tempRe.DETAILS = Txt_Re_Details.Text;
            tempRe.PREPARATION = int.Parse(Txt_Re_TpsPrepa.Text);
            tempRe.CUISSON = int.Parse(Txt_Re_TpsCuisson.Text);
            tempRe.NBPERS = int.Parse(Txt_Re_NbPers.Text);

            DAL.DAL.ExecuteQuery("INSERT INTO Recettes (RE_TITRE,RE_DETAILS,RE_TPSPREPA,RE_TPSCUISSON,RE_NBPERS) VALUES ('" + tempRe.NOM + "','" + tempRe.DETAILS + "','" + tempRe.PREPARATION + "', '" + tempRe.CUISSON + "', '" + tempRe.NBPERS + "')");

            RecettesReload();
        }//end sauvegarder

        private void Btn_Re_Modifier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmez-vous la modification ?", "Confirmation des modifications", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Recettes tempRe = GetNodeInList(Tv_Re_List.SelectedNode.Text.Substring(0, Tv_Re_List.SelectedNode.Text.IndexOf(" ")));
                DAL.DAL.ExecuteQuery("UPDATE [Recettes] SET RE_TITRE = '" + Txt_Re_Nom.Text + "', RE_DETAILS = '" + Txt_Re_Details.Text + "', RE_TPSPREPA = '" + Txt_Re_TpsPrepa.Text + "', RE_TPSCUISSON = '" + Txt_Re_TpsCuisson.Text + "', RE_NBPERS = '" + Txt_Re_NbPers.Text + "' WHERE RE_ID = " + tempRe.ID.ToString());

                RecettesReload();
            }
        }//end modifier

        private void Btn_Re_Supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmez-vous la suppression ?", "Supprimer un ingrédient", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Recettes tempRe = GetNodeInList(Tv_Re_List.SelectedNode.Text.Substring(0, Tv_Re_List.SelectedNode.Text.IndexOf(" ")));
                DAL.DAL.ExecuteQuery("DELETE FROM [Recettes] WHERE RE_ID = '" + tempRe.ID + "'");
                Tv_Re_List.SelectedNode.Remove();
                Txt_Re_Nom.Text = "";
                Txt_Re_Details.Text = "";
                Txt_Re_TpsPrepa.Text = "";
                Txt_Re_TpsCuisson.Text = "";
                Txt_Re_NbPers.Text = "";
            }
        }//end supprimer   

        private void Btn_Re_Test_Click(object sender, EventArgs e)
        {

        }     


    }//end Class
}//end Namespace
