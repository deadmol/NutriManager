using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace NutriManager
{
    public partial class Ingredients : Form
    {
        List<Ingredient> IgList = new List<Ingredient>();
        Dictionary<int, Categories> IgcatList = new Dictionary<int, Categories>();
        List<string> UnitList = new List<string>();

        public Ingredients()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Recherche les valeurs en fonction de l'ID de l'ingrédient
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        private Ingredient GetNodeInList(string ID)
        {
            Ingredient tempIg = null;
            foreach (var item in IgList)
            {
                if (item.ID == int.Parse(ID))
                {
                    tempIg = item;
                }
            }
            return tempIg;
        }

        /// <summary>
        /// Recharge le treeview des ingrédients
        /// </summary>
        private void IngredientReload()
        {
            IgList.Clear();
            Tv_Ig_List.Nodes.Clear();
            List<Dictionary<string, string>> TempIGList = DAL.DAL.SelectQuery("SELECT * FROM [Ingredients]");
            foreach (var item in TempIGList)
            {
                IgList.Add(new Ingredient(int.Parse(item.ElementAt(0).Value), item.ElementAt(1).Value, int.Parse(item.ElementAt(2).Value), item.ElementAt(3).Value, item.ElementAt(4).Value));
                TreeNode node = new TreeNode(int.Parse(item.ElementAt(0).Value) + " " + item.ElementAt(1).Value);
                Tv_Ig_List.Nodes.Add(node);
            }
        }

        /// <summary>
        /// Charge les ingrédients dans le TV et charge les données des CMB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ingrédients_Load(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> TempIgcatList = DAL.DAL.SelectQuery("SELECT * FROM [IG-Categorie]");
            foreach (var item in TempIgcatList)
            {
                IgcatList.Add(int.Parse(item.ElementAt(0).Value), new Categories(int.Parse(item.ElementAt(0).Value), item.ElementAt(1).Value, null));
                Cmb_Ig_Cat.Items.Add(item.ElementAt(1).Value);
            }

            List<Dictionary<string, string>> TempUnitList = DAL.DAL.SelectQuery("SELECT * FROM [Unites]");
            foreach (var item in TempUnitList)
            {
                UnitList.Add(item.ElementAt(1).Value);
                Cmb_Ig_Qte.Items.Add(item.ElementAt(1).Value);
            }

            List<Dictionary<string, string>> TempIGList = DAL.DAL.SelectQuery("SELECT * FROM [Ingredients]");
            foreach (var item in TempIGList)
            {
                IgList.Add(new Ingredient(int.Parse(item.ElementAt(0).Value), item.ElementAt(1).Value, int.Parse(item.ElementAt(2).Value), item.ElementAt(3).Value, item.ElementAt(4).Value));
                TreeNode node = new TreeNode(int.Parse(item.ElementAt(0).Value) + " " + item.ElementAt(1).Value);
                Tv_Ig_List.Nodes.Add(node);
            }

            Cmb_Ig_Qte.SelectedIndex = 0;
            Cmb_Ig_Cat.SelectedIndex = 0;

        }//end void

        /// <summary>
        /// Permet d'afficher le détail d'un ingrédients lorsqu'on clique dessus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tv_Ig_List_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Ingredient tempIg = GetNodeInList(e.Node.Text.Substring(0, e.Node.Text.IndexOf(" ")));
            Txt_Ig_Nom.Text = tempIg.LIB;
            Txt_Ig_Qte.Text = tempIg.QTE.ToString();
            Cmb_Ig_Qte.Text = tempIg.QTELIB;
            Cmb_Ig_Cat.Text = tempIg.CATEGORIE;

        }

        /// <summary>
        /// Ajoute l'ingrédient en base et actualise le TV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Ig_Ajouter_Click(object sender, EventArgs e)
        {
            Ingredient tempIg = new Ingredient();
            tempIg.LIB = Txt_Ig_Nom.Text;
            tempIg.QTE = int.Parse(Txt_Ig_Qte.Text);
            tempIg.QTELIB = Cmb_Ig_Qte.Text;
            tempIg.CATEGORIE = Cmb_Ig_Cat.Text;

            DAL.DAL.ExecuteQuery("INSERT INTO Ingredients (IG_LIB,IG_QTE,IG_QTELIB,IG_CATLIB) VALUES ('" + tempIg.LIB + "','" + tempIg.QTE + "','" + tempIg.QTELIB + "','" + tempIg.CATEGORIE + "')");
            IngredientReload();
        }

        /// <summary>
        /// Modifie l'ingrédient selectionné et actualise le TV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Ig_Modifier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmez-vous la modification ?", "Confirmation des modifications", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Ingredient tempIg = GetNodeInList(Tv_Ig_List.SelectedNode.Text.Substring(0, Tv_Ig_List.SelectedNode.Text.IndexOf(" ")));
                DAL.DAL.ExecuteQuery("UPDATE Ingredients SET IG_LIB = '" + Txt_Ig_Nom.Text + "', IG_QTE = '" + Txt_Ig_Qte.Text + "', IG_QTELIB = '" + Cmb_Ig_Qte.Text + "', IG_CATLIB = '" + Cmb_Ig_Cat.Text + "' WHERE IG_ID = " + tempIg.ID.ToString());
               
                IngredientReload();
            }
        }//end void

        /// <summary>
        /// Supprime l'ingrédient sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Ig_Supprimer_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirmez-vous la suppression ?", "Supprimer un ingrédient", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Ingredient tempIg = GetNodeInList(Tv_Ig_List.SelectedNode.Text.Substring(0, Tv_Ig_List.SelectedNode.Text.IndexOf(" ")));
                DAL.DAL.ExecuteQuery("DELETE FROM [Ingredients] WHERE IG_ID = '" + tempIg.ID + "'");
                Tv_Ig_List.SelectedNode.Remove();
                Txt_Ig_Nom.Text = "";
                Txt_Ig_Qte.Text = "";
                Cmb_Ig_Qte.SelectedIndex = 0;
                Cmb_Ig_Cat.SelectedIndex = 0;
            }
        }//end void


        /// <summary>
        /// Recherche un ingrédient dans le TV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_Ig_Recherche_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_Ig_Recherche.Text != "")
            {
                Tv_Ig_List.Nodes.Clear();
                List<Dictionary<string, string>> TempIGList = DAL.DAL.SelectQuery("SELECT * FROM Ingredients WHERE IG_LIB LIKE '%" + Txt_Ig_Recherche.Text + "%'");
                foreach (var item in TempIGList)
                {
                    IgList.Add(new Ingredient(int.Parse(item.ElementAt(0).Value), item.ElementAt(1).Value, int.Parse(item.ElementAt(2).Value), item.ElementAt(3).Value));
                    TreeNode node = new TreeNode(int.Parse(item.ElementAt(0).Value) + " " + item.ElementAt(1).Value);
                    Tv_Ig_List.Nodes.Add(node);
                }
                Tv_Ig_List.Refresh();
            }
            else
            {
                Tv_Ig_List.Nodes.Clear();
                IngredientReload();
            }
        }//end recherche



    }//end class
}//end namespace
