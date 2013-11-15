namespace ComMak.PresentationLogic
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1. Start"}, "appbar.door.enter.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2. Wczytaj projekt"}, "appbar.console.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3. Ustawienia"}, "mechanic.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "4. Komentowanie"}, "appbar.list.check.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "5. Zapisz"}, "appbar.disk.download.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listMenu = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.listMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 682F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 682);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // listMenu
            // 
            this.listMenu.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listMenu.BackgroundImageTiled = true;
            this.listMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMenu.FullRowSelect = true;
            listViewItem1.IndentCount = 4;
            listViewItem1.UseItemStyleForSubItems = false;
            this.listMenu.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listMenu.LargeImageList = this.iconList;
            this.listMenu.Location = new System.Drawing.Point(3, 3);
            this.listMenu.MultiSelect = false;
            this.listMenu.Name = "listMenu";
            this.listMenu.ShowGroups = false;
            this.listMenu.ShowItemToolTips = true;
            this.listMenu.Size = new System.Drawing.Size(154, 676);
            this.listMenu.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listMenu.TabIndex = 0;
            this.listMenu.TileSize = new System.Drawing.Size(100, 52);
            this.listMenu.UseCompatibleStateImageBehavior = false;
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "cogs1.png");
            this.iconList.Images.SetKeyName(1, "computer30.png");
            this.iconList.Images.SetKeyName(2, "connection2.png");
            this.iconList.Images.SetKeyName(3, "expand14.png");
            this.iconList.Images.SetKeyName(4, "mechanic.png");
            this.iconList.Images.SetKeyName(5, "thought2.png");
            this.iconList.Images.SetKeyName(6, "appbar.console.png");
            this.iconList.Images.SetKeyName(7, "appbar.diagram.png");
            this.iconList.Images.SetKeyName(8, "appbar.disk.download.png");
            this.iconList.Images.SetKeyName(9, "appbar.door.enter.png");
            this.iconList.Images.SetKeyName(10, "appbar.folder.ellipsis.png");
            this.iconList.Images.SetKeyName(11, "appbar.folder.open.png");
            this.iconList.Images.SetKeyName(12, "appbar.language.csharp.png");
            this.iconList.Images.SetKeyName(13, "appbar.language.java.png");
            this.iconList.Images.SetKeyName(14, "appbar.language.java.text.png");
            this.iconList.Images.SetKeyName(15, "appbar.language.python.png");
            this.iconList.Images.SetKeyName(16, "appbar.language.python.text.png");
            this.iconList.Images.SetKeyName(17, "appbar.list.check.png");
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(163, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 676);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(984, 682);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1000, 720);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listMenu;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Panel panel1;
    }
}