using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class OpenToll : Form
    {
        public OpenToll()
        {
            InitializeComponent();
        }

        private void MenuZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        AboutBox autor = new AboutBox();
        private void MenuAutor_Click(object sender, EventArgs e)
        {
            autor.ShowDialog();
        }

        OpenFileDialog otworz = new OpenFileDialog();
        private void MenuOtwórz_Click(object sender, EventArgs e)
        {
            otworz.ShowDialog();
            otworz.InitialDirectory="C:\\Windows";
            otworz.Filter = " Plik rtf(*.rtf)|*.rtf| Plik tekstowy(*.txt)|*.txt| Wszystkie pliki(*.*)|*.*";
            string plik;
            plik = otworz.FileName;
            richText.LoadFile(plik, RichTextBoxStreamType.RichText);
            StreamReader f = new StreamReader(plik);
            richText.Text = f.ReadToEnd();
           
        }

        SaveFileDialog Zapisz = new SaveFileDialog();
        private void MenuZapisz_Click(object sender, EventArgs e)
        {
            string plik;
            Zapisz.Filter=" Plik rtf(*.rtf)|*.rtf| Plik tekstowy(*.txt)|*.txt| Wszystkie pliki(*.*)|*.*";
            Zapisz.ShowDialog();
            plik = Zapisz.FileName;
            richText.SaveFile(plik, RichTextBoxStreamType.RichText);

        }

        private void MenuKopioj_Click(object sender, EventArgs e)
        {
            richText.Copy();
        }

        private void MenuCofnij_Click(object sender, EventArgs e)
        {
            richText.Undo();
        }

        private void MenuWytnij_Click(object sender, EventArgs e)
        {
            richText.Cut();
        }

        private void MenuWklej_Click(object sender, EventArgs e)
        {
            richText.Paste();
        }


        private void TollOpen_Click(object sender, EventArgs e)
        {

            otworz.ShowDialog();
            otworz.InitialDirectory = "C:\\Windows";
            otworz.Filter = " Plik rtf(*.rtf)|*.rtf| Plik tekstowy(*.txt)|*.txt| Wszystkie pliki(*.*)|*.*";
            string plik;
            plik = otworz.FileName;
            richText.LoadFile(plik, RichTextBoxStreamType.RichText);
            StreamReader f = new StreamReader(plik);
            richText.Text = f.ReadToEnd();
        }

        private void TollSave_Click(object sender, EventArgs e)
        {
            string plik;
            Zapisz.Filter = " Plik rtf(*.rtf)|*.rtf| Plik tekstowy(*.txt)|*.txt| Wszystkie pliki(*.*)|*.*";
            Zapisz.ShowDialog();
            plik = Zapisz.FileName;
            richText.SaveFile(plik, RichTextBoxStreamType.RichText);
        }

        private void TollClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TollUndo_Click(object sender, EventArgs e)
        {
            richText.Undo();
        }

        private void TollCut_Click(object sender, EventArgs e)
        {
            richText.Cut();
        }

        private void TollCopy_Click(object sender, EventArgs e)
        {
            richText.Copy();
        }

        private void TollPaste_Click(object sender, EventArgs e)
        {
            richText.Paste();
        }

        private void TollAutor_Click(object sender, EventArgs e)
        {
            autor.ShowDialog();
        }

        private void TollDelete_Click(object sender, EventArgs e)
        {
            richText.ClearUndo();
        }

        private void TollFont_Click(object sender, EventArgs e)
        {
            FontDialog font =new FontDialog();
            font.ShowColor = true;
            font.ShowDialog();
            richText.SelectionFont = font.Font;
        }

        private void TollPaste_Click_1(object sender, EventArgs e)
        {
            richText.Paste();
        }

        private void TollColor_Click(object sender, EventArgs e)
        {
            ColorDialog kolor=new ColorDialog();
            kolor.ShowDialog();
            richText.SelectionColor=kolor.Color;
        }

        private void TollCopy_Click_1(object sender, EventArgs e)
        {
            richText.Copy();
        }

        private void OpenToll_Load(object sender, EventArgs e)
        {

        }

      
        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.Copy();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.Cut();
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.Clear();
        }

        private void zamnknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string strNazwaPliku;
            Image rysunek;
            otworz.InitialDirectory="C:\\Documents and Settings\\klasa3\\Moje dokumenty\\Moje obrazy";
            otworz.Title="Otwórz Plik";
            otworz.Filter="Plik jpeg|*.jpg|Pliki Gif|*.gif|Pliki bmp|*.bmp";
            otworz.FileName="";
            otworz.Multiselect=false;

            try
            {
                otworz.ShowDialog();
                if(otworz.FileName != "")
                {
                    strNazwaPliku=otworz.FileName;
                    strNazwaPliku=otworz.FileName;
                    rysunek=Image.FromFile(strNazwaPliku);
                    Clipboard.SetImage(rysunek);
                    richText.Paste();
                    Clipboard.Clear();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bład odczytu Pliku."+ex.Message,"Zakończenie Programu",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
        }
        

        

           
      

 
    }
}
