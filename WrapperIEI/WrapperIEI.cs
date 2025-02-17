﻿using OpenQA.Selenium;
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
using WrapperIEI.Business;
using WrapperIEI.Business.Services;
using System.Threading;

namespace WrapperIEI
{
    public partial class WrapperIEI : Form
    {

        ChromeDriver _driver;

        List<BookDTO> _books = new List<BookDTO>();

        int mov, movX, movY;

        bool _amazonError, _elCorteInglesError;


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

        string _errorMessage;
        string ErrorMessage
        {
            get => _errorMessage;

            set => _errorMessage = value;
        }

        #endregion

        public WrapperIEI()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorPanel.Hide();
            loadingPanel.Hide();
        }


        private void SetProperties()
        {
            this.TitleBook = (!String.IsNullOrEmpty(titleTxt.Text) && titleTxt.Text != Constants.TITLE_PLACEHOLDER) ? titleTxt.Text : null;
            this.AuthorBook = (!String.IsNullOrEmpty(authorTxt.Text) && authorTxt.Text != Constants.AUTHOR_PLACEHOLDER) ? authorTxt.Text : null;
            this.AmazonChecked = amazonCbx.Checked;
            this.ElCorteInglesChecked = elCorteInglesCbx.Checked;

        }

        private void ConfigureWebDriver() {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            _driver = new ChromeDriver(chromeDriverService, options);
        }

        private async Task<List<BookDTO>> PrepareListOfBooks()
        {
            ConfigureWebDriver();
            List<BookDTO> localList = new List<BookDTO>();
            List<BookDTO> AmazonList = new List<BookDTO>();
            List<BookDTO> ElCorteInglesList = new List<BookDTO>();
            await Task.Run(() =>
            {
                if (AmazonChecked)
                {
                    AmazonService amazon = new AmazonService(_driver);

                    try
                    {
                        amazon.Init(TitleBook, AuthorBook);
                        AmazonList = localList = amazon.GetList();
                    }
                    catch (NoResultsException e)
                    {
                        _amazonError = true;
                        ErrorMessage = e.Message;
                    }

                    
                    
                }

                if (ElCorteInglesChecked)
                {
                    ElCorteInglesService elCorteIngles = new ElCorteInglesService(_driver);

                    try
                    {
                        elCorteIngles.Init(TitleBook, AuthorBook);
                        ElCorteInglesList = localList = elCorteIngles.GetList();
                    }
                    catch (NoResultsException e)
                    {
                        _elCorteInglesError = true;
                        ErrorMessage = e.Message;
                    }


                }

                if (AmazonChecked && ElCorteInglesChecked)
                {
                    AmazonList.AddRange(ElCorteInglesList);
                    localList = AmazonList;
                }
            });
           

            return  localList;
        }


        #region Events

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            _books.Clear();

            booksList.Items.Clear();
            SetProperties();

            if (CanSearch())
            {
                searchBtn.Enabled = false;
                loadingPanel.Show();
                loadingPicture.Show();
                loadingLabel.Show();
                loadingPanel.Refresh();
                loadingPicture.Update();

                _books = await PrepareListOfBooks();

                if (((!_amazonError && !_elCorteInglesError)  && (AmazonChecked || ElCorteInglesChecked)) ||
                    ((AmazonChecked && ElCorteInglesChecked) && !(_amazonError && _elCorteInglesError) ) )
                {
                    foreach (BookDTO book in _books)
                    {
                        ListViewItem item = booksList.Items.Add(book.Provider);
                        item.SubItems.Add(book.Title);
                        item.SubItems.Add(book.Author);
                        item.SubItems.Add(book.Price.ToString() + Constants.MONEY_SYMBOL);
                        item.SubItems.Add((!String.IsNullOrEmpty(book.Discount)) ? book.Discount + Constants.DISCOUNT_SYMBOL : "No discount");
                    }
                    
                    searchBtn.Enabled = true;
                }
                else
                {
                    errorPanel.Show();
                    errorLabel.Text = ErrorMessage;
                }

                loadingPanel.Hide();



            }
            else
            {
                MessageBox.Show(Constants.EMPTY_CONTENT_MESSAGE, Constants.EMPTY_TITLE_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private bool CanSearch()
        {
            return ((!String.IsNullOrEmpty(titleTxt.Text) && titleTxt.Text != Constants.TITLE_PLACEHOLDER) ||
                    (!String.IsNullOrEmpty(authorTxt.Text) && authorTxt.Text != Constants.AUTHOR_PLACEHOLDER)) &&
                    (AmazonChecked || ElCorteInglesChecked);
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

        private void ErrorBtn_Click(object sender, EventArgs e)
        {
            _amazonError = false;
            _elCorteInglesError = false;
            errorPanel.Hide();
            searchBtn.Enabled = true;
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
