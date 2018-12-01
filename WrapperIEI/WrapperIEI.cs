using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WrapperIEI.DTO;
using WrapperIEI.Business.Services;

namespace WrapperIEI
{
    public partial class WrapperIEI : Form
    {

        List<BookDTO> _books;

        int mov, movX, movY;

        #region Properties

        string _titleBook;
        string TitleBook
        {
            get => _titleBook;

            set => _titleBook = value;
        }

        string _authorBook;
        string AuthorBook
        {
            get => _authorBook;

            set => _authorBook = value;
        }

        bool _amazonChecked;
        bool AmazonChecked
        {
            get => _amazonChecked;

            set => _amazonChecked = value;
        }

        bool _elCorteInglesChecked;
        bool ElCorteInglesChecked
        {
            get => _elCorteInglesChecked;

            set => _elCorteInglesChecked = value;
        }

        #endregion

        public WrapperIEI()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void SetProperties()
        {
            this.TitleBook = (!String.IsNullOrEmpty(titleTxt.Text) && titleTxt.Text != Constants.TITLE_PLACEHOLDER) ? titleTxt.Text : null;
            this.AuthorBook = (!String.IsNullOrEmpty(authorTxt.Text) && authorTxt.Text != Constants.AUTHOR_PLACEHOLDER) ? authorTxt.Text : null;
            this.AmazonChecked = amazonCbx.Checked;
            this.ElCorteInglesChecked = elCorteInglesCbx.Checked;

        }

        private List<BookDTO> PrepareListOfBooks()
        {

            List<BookDTO> localList = new List<BookDTO>();
            List<BookDTO> AmazonList = new List<BookDTO>();
            List<BookDTO> ElCorteInglesList = new List<BookDTO>();

            if (AmazonChecked)
            {
                AmazonService amazon = new AmazonService(new ChromeDriver());
                amazon.Init(TitleBook);
                AmazonList = localList = amazon.GetList();
            }

            if (ElCorteInglesChecked)
            {
                ElCorteInglesService elCorteIngles = new ElCorteInglesService(new ChromeDriver());
                elCorteIngles.Init(TitleBook);
                ElCorteInglesList = localList = elCorteIngles.GetList();
            }

            if (AmazonChecked && ElCorteInglesChecked)
            {
                AmazonList.AddRange(ElCorteInglesList);
                localList = AmazonList;
            }

            return localList;
        } 

        #region Events

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SetProperties();
            _books = PrepareListOfBooks();

            foreach (BookDTO book in _books)
            {
                ListViewItem item = booksList.Items.Add(book.Provider);
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.Price.ToString() + "€");
                item.SubItems.Add((!String.IsNullOrEmpty(book.Discount)) ? book.Discount + " %" : "No discount");
            }

            

        }




        //// STYLE FORM EVENTS

        private void ButtonsBar_ChangeColorEnter(object sender, EventArgs e)
        {
            if( sender.GetType() == typeof(Label) )
                ((Label)sender).BackColor = Color.FromArgb(49, 49, 60);
        }

        private void ButtonsBar_ChangeColorLeave(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Label))
                ((Label)sender).BackColor = Color.FromArgb(34, 36, 49);
        }

        private void BarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void BarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }

        }

        private void BarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void FormTxt_Enter(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                TextBox textBox = ((TextBox)sender);

                if (textBox.Text == Constants.TITLE_PLACEHOLDER || textBox.Text == Constants.AUTHOR_PLACEHOLDER)
                {
                    textBox.Text = "";
                }

                if (textBox.Name == "titleTxt")
                {
                    titlePanel.BackColor = Color.Aqua;
                }

                if (textBox.Name == "authorTxt")
                {
                    authorPanel.BackColor = Color.Aqua;
                }

            }
        }

        private void FormTxt_Leave(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                TextBox textBox = ((TextBox)sender);
                if (textBox.Name == "titleTxt")
                {
                    if (String.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Text = Constants.TITLE_PLACEHOLDER;
                    }

                    titlePanel.BackColor = Color.White;
                }

                if (textBox.Name == "authorTxt")
                {
                    if (String.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.Text = Constants.AUTHOR_PLACEHOLDER;
                    }

                    authorPanel.BackColor = Color.White;
                }

            }
        }

        private void MinifyWindow(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
