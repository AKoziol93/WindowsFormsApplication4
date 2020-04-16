namespace WindowsFormsApplication1
{
    partial class OpenToll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenToll));
            this.richText = new System.Windows.Forms.RichTextBox();
            this.ContexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuPlik = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOtwórz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuZapisz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuZamknij = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdycja = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCofnij = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuWytnij = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKopiuj = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuWklej = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuWidok = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.Narzedzia = new System.Windows.Forms.ToolStrip();
            this.TollOpen = new System.Windows.Forms.ToolStripButton();
            this.TollSave = new System.Windows.Forms.ToolStripButton();
            this.TollClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TollUndo = new System.Windows.Forms.ToolStripButton();
            this.TollCut = new System.Windows.Forms.ToolStripButton();
            this.TollCopy = new System.Windows.Forms.ToolStripButton();
            this.TollPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TollFont = new System.Windows.Forms.ToolStripButton();
            this.TollColor = new System.Windows.Forms.ToolStripButton();
            this.zamnknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ClipartStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ContexMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Narzedzia.SuspendLayout();
            this.SuspendLayout();
            // 
            // richText
            // 
            this.richText.ContextMenuStrip = this.ContexMenu;
            this.richText.Location = new System.Drawing.Point(0, 129);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(1015, 566);
            this.richText.TabIndex = 0;
            this.richText.Text = "";
            // 
            // ContexMenu
            // 
            this.ContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wklejToolStripMenuItem,
            this.toolStripSeparator4,
            this.copyToolStripMenuItem,
            this.wytnijToolStripMenuItem,
            this.toolStripSeparator3,
            this.zamnknijToolStripMenuItem});
            this.ContexMenu.Name = "contextMenuStrip1";
            this.ContexMenu.Size = new System.Drawing.Size(128, 104);
            this.ContexMenu.Text = "Wstaw";
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.wklejToolStripMenuItem.Text = "Wklej";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyToolStripMenuItem.Text = "Kopiój";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPlik,
            this.MenuEdycja,
            this.MenuWidok,
            this.MenuFormat,
            this.MenuInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuPlik
            // 
            this.MenuPlik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOtwórz,
            this.toolStripMenuItem1,
            this.MenuZapisz,
            this.toolStripMenuItem2,
            this.MenuZamknij});
            this.MenuPlik.Name = "MenuPlik";
            this.MenuPlik.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.MenuPlik.Size = new System.Drawing.Size(34, 20);
            this.MenuPlik.Text = "Plik";
            // 
            // MenuOtwórz
            // 
            this.MenuOtwórz.Name = "MenuOtwórz";
            this.MenuOtwórz.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuOtwórz.Size = new System.Drawing.Size(161, 22);
            this.MenuOtwórz.Text = "Otwórz";
            this.MenuOtwórz.Click += new System.EventHandler(this.MenuOtwórz_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
            // 
            // MenuZapisz
            // 
            this.MenuZapisz.Name = "MenuZapisz";
            this.MenuZapisz.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuZapisz.Size = new System.Drawing.Size(161, 22);
            this.MenuZapisz.Text = "Zapisz";
            this.MenuZapisz.Click += new System.EventHandler(this.MenuZapisz_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(158, 6);
            // 
            // MenuZamknij
            // 
            this.MenuZamknij.Name = "MenuZamknij";
            this.MenuZamknij.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuZamknij.Size = new System.Drawing.Size(161, 22);
            this.MenuZamknij.Text = "Zamknij";
            this.MenuZamknij.Click += new System.EventHandler(this.MenuZamknij_Click);
            // 
            // MenuEdycja
            // 
            this.MenuEdycja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCofnij,
            this.toolStripMenuItem3,
            this.MenuWytnij,
            this.MenuKopiuj,
            this.MenuWklej});
            this.MenuEdycja.Name = "MenuEdycja";
            this.MenuEdycja.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.MenuEdycja.Size = new System.Drawing.Size(51, 20);
            this.MenuEdycja.Text = "Edycja";
            // 
            // MenuCofnij
            // 
            this.MenuCofnij.Name = "MenuCofnij";
            this.MenuCofnij.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MenuCofnij.Size = new System.Drawing.Size(154, 22);
            this.MenuCofnij.Text = "Cofnij";
            this.MenuCofnij.Click += new System.EventHandler(this.MenuCofnij_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(151, 6);
            // 
            // MenuWytnij
            // 
            this.MenuWytnij.Name = "MenuWytnij";
            this.MenuWytnij.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MenuWytnij.Size = new System.Drawing.Size(154, 22);
            this.MenuWytnij.Text = "Wytnij";
            this.MenuWytnij.Click += new System.EventHandler(this.MenuWytnij_Click);
            // 
            // MenuKopiuj
            // 
            this.MenuKopiuj.Name = "MenuKopiuj";
            this.MenuKopiuj.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuKopiuj.Size = new System.Drawing.Size(154, 22);
            this.MenuKopiuj.Text = "Kopiuj";
            this.MenuKopiuj.Click += new System.EventHandler(this.MenuKopioj_Click);
            // 
            // MenuWklej
            // 
            this.MenuWklej.Name = "MenuWklej";
            this.MenuWklej.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MenuWklej.Size = new System.Drawing.Size(154, 22);
            this.MenuWklej.Text = "Wklej";
            this.MenuWklej.Click += new System.EventHandler(this.MenuWklej_Click);
            // 
            // MenuWidok
            // 
            this.MenuWidok.Name = "MenuWidok";
            this.MenuWidok.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.MenuWidok.Size = new System.Drawing.Size(48, 20);
            this.MenuWidok.Text = "Widok";
            // 
            // MenuFormat
            // 
            this.MenuFormat.Name = "MenuFormat";
            this.MenuFormat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.MenuFormat.Size = new System.Drawing.Size(53, 20);
            this.MenuFormat.Text = "Format";
            // 
            // MenuInfo
            // 
            this.MenuInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAutor});
            this.MenuInfo.Name = "MenuInfo";
            this.MenuInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.MenuInfo.Size = new System.Drawing.Size(39, 20);
            this.MenuInfo.Text = "Info";
            // 
            // MenuAutor
            // 
            this.MenuAutor.Name = "MenuAutor";
            this.MenuAutor.Size = new System.Drawing.Size(112, 22);
            this.MenuAutor.Text = "Autor";
            this.MenuAutor.Click += new System.EventHandler(this.MenuAutor_Click);
            // 
            // Narzedzia
            // 
            this.Narzedzia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TollOpen,
            this.TollSave,
            this.TollClose,
            this.toolStripSeparator1,
            this.TollUndo,
            this.TollCut,
            this.TollCopy,
            this.TollPaste,
            this.toolStripSeparator2,
            this.TollFont,
            this.TollColor,
            this.toolStripSeparator5,
            this.ClipartStripButton1});
            this.Narzedzia.Location = new System.Drawing.Point(0, 24);
            this.Narzedzia.MaximumSize = new System.Drawing.Size(1016, 50);
            this.Narzedzia.MinimumSize = new System.Drawing.Size(1016, 50);
            this.Narzedzia.Name = "Narzedzia";
            this.Narzedzia.Size = new System.Drawing.Size(1016, 50);
            this.Narzedzia.TabIndex = 2;
            this.Narzedzia.Text = "Narzedzia Główne";
            // 
            // TollOpen
            // 
            this.TollOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TollOpen.Image = ((System.Drawing.Image)(resources.GetObject("TollOpen.Image")));
            this.TollOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TollOpen.Name = "TollOpen";
            this.TollOpen.Size = new System.Drawing.Size(23, 47);
            this.TollOpen.Text = "TollOpen";
            this.TollOpen.Click += new System.EventHandler(this.TollOpen_Click);
            // 
            // TollSave
            // 
            this.TollSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TollSave.Image = ((System.Drawing.Image)(resources.GetObject("TollSave.Image")));
            this.TollSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TollSave.Name = "TollSave";
            this.TollSave.Size = new System.Drawing.Size(23, 47);
            this.TollSave.Text = "TollSave";
            this.TollSave.Click += new System.EventHandler(this.TollSave_Click);
            // 
            // TollClose
            // 
            this.TollClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TollClose.Image = ((System.Drawing.Image)(resources.GetObject("TollClose.Image")));
            this.TollClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TollClose.Name = "TollClose";
            this.TollClose.Size = new System.Drawing.Size(23, 47);
            this.TollClose.Text = "TollClose";
            this.TollClose.Click += new System.EventHandler(this.TollClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // TollUndo
            // 
            this.TollUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TollUndo.Image = ((System.Drawing.Image)(resources.GetObject("TollUndo.Image")));
            this.TollUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TollUndo.Name = "TollUndo";
            this.TollUndo.Size = new System.Drawing.Size(23, 47);
            this.TollUndo.Text = "TollUndo";
            this.TollUndo.Click += new System.EventHandler(this.TollUndo_Click);
            // 
            // TollCut
            // 
            this.TollCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TollCut.Image = ((System.Drawing.Image)(resources.GetObject("TollCut.Image")));
            this.TollCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TollCut.Name = "TollCut";
            this.TollCut.Size = new System.Drawing.Size(23, 47);
            this.TollCut.Text = "TollCut";
            this.TollCut.Click += new System.EventHandler(this.TollCut_Click);
            // 
            // TollCopy
            // 
            this.TollCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TollCopy.Image = ((System.Drawing.Image)(resources.GetObject("TollCopy.Image")));
            this.TollCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TollCopy.Name = "TollCopy";
            this.TollCopy.Size = new System.Drawing.Size(23, 47);
            this.TollCopy.Text = "TollCopy";
            this.TollCopy.Click += new System.EventHandler(this.TollCopy_Click_1);
            // 
            // TollPaste
            // 
            this.TollPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TollPaste.Image = ((System.Drawing.Image)(resources.GetObject("TollPaste.Image")));
            this.TollPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TollPaste.Name = "TollPaste";
            this.TollPaste.Size = new System.Drawing.Size(23, 47);
            this.TollPaste.Text = "TollPaste";
            this.TollPaste.Click += new System.EventHandler(this.TollPaste_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // TollFont
            // 
            this.TollFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TollFont.Image = ((System.Drawing.Image)(resources.GetObject("TollFont.Image")));
            this.TollFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TollFont.Name = "TollFont";
            this.TollFont.Size = new System.Drawing.Size(23, 47);
            this.TollFont.Text = "toolStripButton1";
            this.TollFont.Click += new System.EventHandler(this.TollFont_Click);
            // 
            // TollColor
            // 
            this.TollColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TollColor.Image = ((System.Drawing.Image)(resources.GetObject("TollColor.Image")));
            this.TollColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TollColor.Name = "TollColor";
            this.TollColor.Size = new System.Drawing.Size(23, 47);
            this.TollColor.Text = "toolStripButton2";
            this.TollColor.Click += new System.EventHandler(this.TollColor_Click);
            // 
            // zamnknijToolStripMenuItem
            // 
            this.zamnknijToolStripMenuItem.Name = "zamnknijToolStripMenuItem";
            this.zamnknijToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.zamnknijToolStripMenuItem.Text = "Zamnknij";
            this.zamnknijToolStripMenuItem.Click += new System.EventHandler(this.zamnknijToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(124, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(124, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 50);
            // 
            // ClipartStripButton1
            // 
            this.ClipartStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClipartStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ClipartStripButton1.Image")));
            this.ClipartStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClipartStripButton1.Name = "ClipartStripButton1";
            this.ClipartStripButton1.RightToLeftAutoMirrorImage = true;
            this.ClipartStripButton1.Size = new System.Drawing.Size(23, 47);
            this.ClipartStripButton1.Text = "Clipart";
            this.ClipartStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // OpenToll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 698);
            this.Controls.Add(this.Narzedzia);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1024, 732);
            this.MinimumSize = new System.Drawing.Size(1024, 732);
            this.Name = "OpenToll";
            this.Text = " Edytor Tekstu";
            this.Load += new System.EventHandler(this.OpenToll_Load);
            this.ContexMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Narzedzia.ResumeLayout(false);
            this.Narzedzia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuPlik;
        private System.Windows.Forms.ToolStripMenuItem MenuOtwórz;
        private System.Windows.Forms.ToolStripMenuItem MenuZapisz;
        private System.Windows.Forms.ToolStripMenuItem MenuEdycja;
        private System.Windows.Forms.ToolStripMenuItem MenuCofnij;
        private System.Windows.Forms.ToolStripMenuItem MenuWytnij;
        private System.Windows.Forms.ToolStripMenuItem MenuKopiuj;
        private System.Windows.Forms.ToolStripMenuItem MenuWklej;
        private System.Windows.Forms.ToolStripMenuItem MenuWidok;
        private System.Windows.Forms.ToolStripMenuItem MenuFormat;
        private System.Windows.Forms.ToolStripMenuItem MenuInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuZamknij;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuAutor;
        private System.Windows.Forms.ToolStrip Narzedzia;
        private System.Windows.Forms.ToolStripButton TollOpen;
        private System.Windows.Forms.ToolStripButton TollSave;
        private System.Windows.Forms.ToolStripButton TollClose;
        private System.Windows.Forms.ToolStripButton TollUndo;
        private System.Windows.Forms.ToolStripButton TollCut;
        private System.Windows.Forms.ToolStripButton TollCopy;
        private System.Windows.Forms.ToolStripButton TollPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TollFont;
        private System.Windows.Forms.ToolStripButton TollColor;
        private System.Windows.Forms.ContextMenuStrip ContexMenu;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamnknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ClipartStripButton1;
    }
}

