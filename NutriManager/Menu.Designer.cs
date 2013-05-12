namespace NutriManager
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tv_Mn_ListRe = new System.Windows.Forms.TreeView();
            this.Cal_Mn_Calendar = new System.Windows.Forms.MonthCalendar();
            this.Tv_Mn_Menu = new System.Windows.Forms.TreeView();
            this.Btn_Mn_Add = new System.Windows.Forms.Button();
            this.Btn_Mn_Remove = new System.Windows.Forms.Button();
            this.Mn_Menu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingrédientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recettesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Mn_Sauvegarde = new System.Windows.Forms.Button();
            this.Rbtn_Mn_Midi = new System.Windows.Forms.RadioButton();
            this.Rbtn_Mn_Soir = new System.Windows.Forms.RadioButton();
            this.Rbtn_Mn_Re = new System.Windows.Forms.RadioButton();
            this.Rbtn_Mn_Ig = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Mn_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tv_Mn_ListRe
            // 
            this.Tv_Mn_ListRe.Location = new System.Drawing.Point(13, 71);
            this.Tv_Mn_ListRe.Name = "Tv_Mn_ListRe";
            this.Tv_Mn_ListRe.Size = new System.Drawing.Size(165, 318);
            this.Tv_Mn_ListRe.TabIndex = 0;
            this.Tv_Mn_ListRe.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tv_Mn_ListRe_NodeMouseClick);
            // 
            // Cal_Mn_Calendar
            // 
            this.Cal_Mn_Calendar.Location = new System.Drawing.Point(424, 122);
            this.Cal_Mn_Calendar.MaxSelectionCount = 1;
            this.Cal_Mn_Calendar.Name = "Cal_Mn_Calendar";
            this.Cal_Mn_Calendar.TabIndex = 2;
            // 
            // Tv_Mn_Menu
            // 
            this.Tv_Mn_Menu.Location = new System.Drawing.Point(233, 122);
            this.Tv_Mn_Menu.Name = "Tv_Mn_Menu";
            this.Tv_Mn_Menu.Size = new System.Drawing.Size(155, 267);
            this.Tv_Mn_Menu.TabIndex = 4;
            this.Tv_Mn_Menu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tv_Mn_Menu_NodeMouseClick);
            // 
            // Btn_Mn_Add
            // 
            this.Btn_Mn_Add.Location = new System.Drawing.Point(184, 182);
            this.Btn_Mn_Add.Name = "Btn_Mn_Add";
            this.Btn_Mn_Add.Size = new System.Drawing.Size(43, 23);
            this.Btn_Mn_Add.TabIndex = 5;
            this.Btn_Mn_Add.Text = ">>";
            this.Btn_Mn_Add.UseVisualStyleBackColor = true;
            this.Btn_Mn_Add.Click += new System.EventHandler(this.Btn_Mn_Add_Click);
            // 
            // Btn_Mn_Remove
            // 
            this.Btn_Mn_Remove.Location = new System.Drawing.Point(184, 235);
            this.Btn_Mn_Remove.Name = "Btn_Mn_Remove";
            this.Btn_Mn_Remove.Size = new System.Drawing.Size(43, 23);
            this.Btn_Mn_Remove.TabIndex = 6;
            this.Btn_Mn_Remove.Text = "<<";
            this.Btn_Mn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Mn_Remove.Click += new System.EventHandler(this.Btn_Mn_Remove_Click);
            // 
            // Mn_Menu
            // 
            this.Mn_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.fenêtreToolStripMenuItem});
            this.Mn_Menu.Location = new System.Drawing.Point(0, 0);
            this.Mn_Menu.Name = "Mn_Menu";
            this.Mn_Menu.Size = new System.Drawing.Size(685, 24);
            this.Mn_Menu.TabIndex = 7;
            this.Mn_Menu.Text = "Menu";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // fenêtreToolStripMenuItem
            // 
            this.fenêtreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingrédientsToolStripMenuItem,
            this.recettesToolStripMenuItem});
            this.fenêtreToolStripMenuItem.Name = "fenêtreToolStripMenuItem";
            this.fenêtreToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.fenêtreToolStripMenuItem.Text = "Fenêtre";
            // 
            // ingrédientsToolStripMenuItem
            // 
            this.ingrédientsToolStripMenuItem.Name = "ingrédientsToolStripMenuItem";
            this.ingrédientsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ingrédientsToolStripMenuItem.Text = "Ingrédients";
            this.ingrédientsToolStripMenuItem.Click += new System.EventHandler(this.ingrédientsToolStripMenuItem_Click);
            // 
            // recettesToolStripMenuItem
            // 
            this.recettesToolStripMenuItem.Name = "recettesToolStripMenuItem";
            this.recettesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.recettesToolStripMenuItem.Text = "Recettes";
            this.recettesToolStripMenuItem.Click += new System.EventHandler(this.recettesToolStripMenuItem_Click);
            // 
            // Btn_Mn_Sauvegarde
            // 
            this.Btn_Mn_Sauvegarde.Location = new System.Drawing.Point(424, 297);
            this.Btn_Mn_Sauvegarde.Name = "Btn_Mn_Sauvegarde";
            this.Btn_Mn_Sauvegarde.Size = new System.Drawing.Size(141, 23);
            this.Btn_Mn_Sauvegarde.TabIndex = 8;
            this.Btn_Mn_Sauvegarde.Text = "Sauvegarder le menu";
            this.Btn_Mn_Sauvegarde.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Mn_Midi
            // 
            this.Rbtn_Mn_Midi.AutoSize = true;
            this.Rbtn_Mn_Midi.Location = new System.Drawing.Point(17, 10);
            this.Rbtn_Mn_Midi.Name = "Rbtn_Mn_Midi";
            this.Rbtn_Mn_Midi.Size = new System.Drawing.Size(44, 17);
            this.Rbtn_Mn_Midi.TabIndex = 9;
            this.Rbtn_Mn_Midi.TabStop = true;
            this.Rbtn_Mn_Midi.Text = "Midi";
            this.Rbtn_Mn_Midi.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Mn_Soir
            // 
            this.Rbtn_Mn_Soir.AutoSize = true;
            this.Rbtn_Mn_Soir.Location = new System.Drawing.Point(78, 10);
            this.Rbtn_Mn_Soir.Name = "Rbtn_Mn_Soir";
            this.Rbtn_Mn_Soir.Size = new System.Drawing.Size(43, 17);
            this.Rbtn_Mn_Soir.TabIndex = 10;
            this.Rbtn_Mn_Soir.TabStop = true;
            this.Rbtn_Mn_Soir.Text = "Soir";
            this.Rbtn_Mn_Soir.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Mn_Re
            // 
            this.Rbtn_Mn_Re.AutoSize = true;
            this.Rbtn_Mn_Re.Location = new System.Drawing.Point(13, 48);
            this.Rbtn_Mn_Re.Name = "Rbtn_Mn_Re";
            this.Rbtn_Mn_Re.Size = new System.Drawing.Size(68, 17);
            this.Rbtn_Mn_Re.TabIndex = 11;
            this.Rbtn_Mn_Re.TabStop = true;
            this.Rbtn_Mn_Re.Text = "Recettes";
            this.Rbtn_Mn_Re.UseVisualStyleBackColor = true;
            this.Rbtn_Mn_Re.CheckedChanged += new System.EventHandler(this.Rbtn_Mn_Re_CheckedChanged);
            // 
            // Rbtn_Mn_Ig
            // 
            this.Rbtn_Mn_Ig.AutoSize = true;
            this.Rbtn_Mn_Ig.Location = new System.Drawing.Point(88, 48);
            this.Rbtn_Mn_Ig.Name = "Rbtn_Mn_Ig";
            this.Rbtn_Mn_Ig.Size = new System.Drawing.Size(77, 17);
            this.Rbtn_Mn_Ig.TabIndex = 12;
            this.Rbtn_Mn_Ig.TabStop = true;
            this.Rbtn_Mn_Ig.Text = "Ingrédients";
            this.Rbtn_Mn_Ig.UseVisualStyleBackColor = true;
            this.Rbtn_Mn_Ig.CheckedChanged += new System.EventHandler(this.Rbtn_Mn_Ig_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Rbtn_Mn_Midi);
            this.panel1.Controls.Add(this.Rbtn_Mn_Soir);
            this.panel1.Location = new System.Drawing.Point(233, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 45);
            this.panel1.TabIndex = 13;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Rbtn_Mn_Ig);
            this.Controls.Add(this.Rbtn_Mn_Re);
            this.Controls.Add(this.Btn_Mn_Sauvegarde);
            this.Controls.Add(this.Btn_Mn_Remove);
            this.Controls.Add(this.Btn_Mn_Add);
            this.Controls.Add(this.Tv_Mn_Menu);
            this.Controls.Add(this.Cal_Mn_Calendar);
            this.Controls.Add(this.Tv_Mn_ListRe);
            this.Controls.Add(this.Mn_Menu);
            this.MainMenuStrip = this.Mn_Menu;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Mn_Menu.ResumeLayout(false);
            this.Mn_Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView Tv_Mn_ListRe;
        private System.Windows.Forms.MonthCalendar Cal_Mn_Calendar;
        private System.Windows.Forms.TreeView Tv_Mn_Menu;
        private System.Windows.Forms.Button Btn_Mn_Add;
        private System.Windows.Forms.Button Btn_Mn_Remove;
        private System.Windows.Forms.MenuStrip Mn_Menu;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenêtreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingrédientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recettesToolStripMenuItem;
        private System.Windows.Forms.Button Btn_Mn_Sauvegarde;
        private System.Windows.Forms.RadioButton Rbtn_Mn_Midi;
        private System.Windows.Forms.RadioButton Rbtn_Mn_Soir;
        private System.Windows.Forms.RadioButton Rbtn_Mn_Re;
        private System.Windows.Forms.RadioButton Rbtn_Mn_Ig;
        private System.Windows.Forms.Panel panel1;
    }
}