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

        


        public WrapperIEI()
        {
            InitializeComponent();
            AmazonService amazon = new AmazonService();
            amazon.Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        




        
    }
}
