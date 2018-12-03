namespace WrapperIEI
{
    partial class WrapperIEI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WrapperIEI));
            this.titleLbl = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.authorPanel = new System.Windows.Forms.Panel();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.amazonCbx = new System.Windows.Forms.CheckBox();
            this.elCorteInglesCbx = new System.Windows.Forms.CheckBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.booksList = new System.Windows.Forms.ListView();
            this.providerColumnHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleColumnHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorColumnHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumnHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discountColumnHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeLbl = new System.Windows.Forms.Label();
            this.minifyLbl = new System.Windows.Forms.Label();
            this.barPanel = new System.Windows.Forms.Panel();
            this.logoPB = new System.Windows.Forms.PictureBox();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.loadingPicture = new System.Windows.Forms.PictureBox();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.crossIcon = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.errorBtn = new System.Windows.Forms.Button();
            this.barPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.loadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).BeginInit();
            this.errorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.titleLbl.Location = new System.Drawing.Point(266, 21);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(280, 60);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "BuscaLibros";
            // 
            // titleTxt
            // 
            this.titleTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.titleTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.titleTxt.Location = new System.Drawing.Point(54, 129);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(250, 19);
            this.titleTxt.TabIndex = 2;
            this.titleTxt.Text = "Titulo del libro";
            this.titleTxt.Enter += new System.EventHandler(this.FormTxt_Enter);
            this.titleTxt.Leave += new System.EventHandler(this.FormTxt_Leave);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.White;
            this.titlePanel.Location = new System.Drawing.Point(54, 154);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(250, 1);
            this.titlePanel.TabIndex = 3;
            // 
            // authorPanel
            // 
            this.authorPanel.BackColor = System.Drawing.Color.White;
            this.authorPanel.Location = new System.Drawing.Point(349, 154);
            this.authorPanel.Name = "authorPanel";
            this.authorPanel.Size = new System.Drawing.Size(250, 1);
            this.authorPanel.TabIndex = 5;
            // 
            // authorTxt
            // 
            this.authorTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.authorTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.authorTxt.Location = new System.Drawing.Point(349, 129);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(250, 19);
            this.authorTxt.TabIndex = 4;
            this.authorTxt.Text = "Autor";
            this.authorTxt.Enter += new System.EventHandler(this.FormTxt_Enter);
            this.authorTxt.Leave += new System.EventHandler(this.FormTxt_Leave);
            // 
            // amazonCbx
            // 
            this.amazonCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.amazonCbx.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.amazonCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amazonCbx.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amazonCbx.ForeColor = System.Drawing.SystemColors.Control;
            this.amazonCbx.ImageKey = "(none)";
            this.amazonCbx.Location = new System.Drawing.Point(648, 123);
            this.amazonCbx.Name = "amazonCbx";
            this.amazonCbx.Size = new System.Drawing.Size(85, 25);
            this.amazonCbx.TabIndex = 10;
            this.amazonCbx.Text = "Amazon";
            this.amazonCbx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.amazonCbx.UseVisualStyleBackColor = true;
            // 
            // elCorteInglesCbx
            // 
            this.elCorteInglesCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elCorteInglesCbx.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.elCorteInglesCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elCorteInglesCbx.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elCorteInglesCbx.ForeColor = System.Drawing.SystemColors.Control;
            this.elCorteInglesCbx.ImageKey = "(none)";
            this.elCorteInglesCbx.Location = new System.Drawing.Point(648, 154);
            this.elCorteInglesCbx.Name = "elCorteInglesCbx";
            this.elCorteInglesCbx.Size = new System.Drawing.Size(116, 25);
            this.elCorteInglesCbx.TabIndex = 11;
            this.elCorteInglesCbx.Text = "El Corte Inglés";
            this.elCorteInglesCbx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elCorteInglesCbx.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(104)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.searchBtn.Location = new System.Drawing.Point(801, 139);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(93, 36);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "BUSCAR";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // booksList
            // 
            this.booksList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.booksList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.providerColumnHead,
            this.titleColumnHead,
            this.authorColumnHead,
            this.priceColumnHead,
            this.discountColumnHead});
            this.booksList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksList.GridLines = true;
            this.booksList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.booksList.Location = new System.Drawing.Point(12, 215);
            this.booksList.Name = "booksList";
            this.booksList.Size = new System.Drawing.Size(925, 300);
            this.booksList.TabIndex = 20;
            this.booksList.TileSize = new System.Drawing.Size(600, 30);
            this.booksList.UseCompatibleStateImageBehavior = false;
            this.booksList.View = System.Windows.Forms.View.Details;
            // 
            // providerColumnHead
            // 
            this.providerColumnHead.Text = "Sitio";
            this.providerColumnHead.Width = 100;
            // 
            // titleColumnHead
            // 
            this.titleColumnHead.Text = "Titulo";
            this.titleColumnHead.Width = 400;
            // 
            // authorColumnHead
            // 
            this.authorColumnHead.Text = "Autor";
            this.authorColumnHead.Width = 200;
            // 
            // priceColumnHead
            // 
            this.priceColumnHead.Text = "Precio";
            this.priceColumnHead.Width = 100;
            // 
            // discountColumnHead
            // 
            this.discountColumnHead.Text = "Descuento";
            this.discountColumnHead.Width = 100;
            // 
            // closeLbl
            // 
            this.closeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.closeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeLbl.Location = new System.Drawing.Point(926, 0);
            this.closeLbl.Name = "closeLbl";
            this.closeLbl.Size = new System.Drawing.Size(24, 24);
            this.closeLbl.TabIndex = 14;
            this.closeLbl.Text = "X";
            this.closeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeLbl.Click += new System.EventHandler(this.CloseWindow);
            this.closeLbl.MouseEnter += new System.EventHandler(this.ButtonsBar_ChangeColorEnter);
            this.closeLbl.MouseLeave += new System.EventHandler(this.ButtonsBar_ChangeColorLeave);
            // 
            // minifyLbl
            // 
            this.minifyLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.minifyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minifyLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minifyLbl.Location = new System.Drawing.Point(902, 0);
            this.minifyLbl.Name = "minifyLbl";
            this.minifyLbl.Size = new System.Drawing.Size(24, 24);
            this.minifyLbl.TabIndex = 15;
            this.minifyLbl.Text = "_";
            this.minifyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minifyLbl.Click += new System.EventHandler(this.MinifyWindow);
            this.minifyLbl.MouseEnter += new System.EventHandler(this.ButtonsBar_ChangeColorEnter);
            this.minifyLbl.MouseLeave += new System.EventHandler(this.ButtonsBar_ChangeColorLeave);
            // 
            // barPanel
            // 
            this.barPanel.BackColor = System.Drawing.Color.Transparent;
            this.barPanel.Controls.Add(this.titleLbl);
            this.barPanel.Controls.Add(this.logoPB);
            this.barPanel.Location = new System.Drawing.Point(2, 0);
            this.barPanel.Name = "barPanel";
            this.barPanel.Size = new System.Drawing.Size(892, 89);
            this.barPanel.TabIndex = 0;
            this.barPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarPanel_MouseDown);
            this.barPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarPanel_MouseMove);
            this.barPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BarPanel_MouseUp);
            // 
            // logoPB
            // 
            this.logoPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPB.BackgroundImage")));
            this.logoPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoPB.Location = new System.Drawing.Point(552, 21);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(64, 64);
            this.logoPB.TabIndex = 0;
            this.logoPB.TabStop = false;
            // 
            // loadingPanel
            // 
            this.loadingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadingPanel.Controls.Add(this.loadingPicture);
            this.loadingPanel.Controls.Add(this.loadingLabel);
            this.loadingPanel.Location = new System.Drawing.Point(12, 215);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(925, 300);
            this.loadingPanel.TabIndex = 16;
            // 
            // loadingPicture
            // 
            this.loadingPicture.Image = ((System.Drawing.Image)(resources.GetObject("loadingPicture.Image")));
            this.loadingPicture.Location = new System.Drawing.Point(365, 15);
            this.loadingPicture.Name = "loadingPicture";
            this.loadingPicture.Size = new System.Drawing.Size(192, 185);
            this.loadingPicture.TabIndex = 2;
            this.loadingPicture.TabStop = false;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadingLabel.Location = new System.Drawing.Point(398, 203);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(138, 18);
            this.loadingLabel.TabIndex = 1;
            this.loadingLabel.Text = "Buscando Libros...";
            // 
            // errorPanel
            // 
            this.errorPanel.Controls.Add(this.errorBtn);
            this.errorPanel.Controls.Add(this.errorLabel);
            this.errorPanel.Controls.Add(this.crossIcon);
            this.errorPanel.Location = new System.Drawing.Point(12, 215);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(926, 300);
            this.errorPanel.TabIndex = 21;
            // 
            // crossIcon
            // 
            this.crossIcon.AutoSize = true;
            this.crossIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossIcon.ForeColor = System.Drawing.Color.DarkRed;
            this.crossIcon.Location = new System.Drawing.Point(445, 47);
            this.crossIcon.Name = "crossIcon";
            this.crossIcon.Size = new System.Drawing.Size(43, 42);
            this.crossIcon.TabIndex = 0;
            this.crossIcon.Text = "X";
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.errorLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(0, 127);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(922, 24);
            this.errorLabel.TabIndex = 1;
            this.errorLabel.Text = "Ups. Algo salio mal!";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorBtn
            // 
            this.errorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.errorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.errorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorBtn.FlatAppearance.BorderSize = 0;
            this.errorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(104)))));
            this.errorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.errorBtn.Location = new System.Drawing.Point(435, 206);
            this.errorBtn.Name = "errorBtn";
            this.errorBtn.Size = new System.Drawing.Size(75, 35);
            this.errorBtn.TabIndex = 2;
            this.errorBtn.Text = "OK";
            this.errorBtn.UseVisualStyleBackColor = false;
            this.errorBtn.Click += new System.EventHandler(this.ErrorBtn_Click);
            // 
            // WrapperIEI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(950, 525);
            this.Controls.Add(this.errorPanel);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.barPanel);
            this.Controls.Add(this.minifyLbl);
            this.Controls.Add(this.closeLbl);
            this.Controls.Add(this.booksList);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.elCorteInglesCbx);
            this.Controls.Add(this.amazonCbx);
            this.Controls.Add(this.authorPanel);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.titleTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WrapperIEI";
            this.Text = "Wrapper IEI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.barPanel.ResumeLayout(false);
            this.barPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).EndInit();
            this.errorPanel.ResumeLayout(false);
            this.errorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPB;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel authorPanel;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.CheckBox amazonCbx;
        private System.Windows.Forms.CheckBox elCorteInglesCbx;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListView booksList;
        private System.Windows.Forms.ColumnHeader providerColumnHead;
        private System.Windows.Forms.ColumnHeader titleColumnHead;
        private System.Windows.Forms.ColumnHeader authorColumnHead;
        private System.Windows.Forms.ColumnHeader priceColumnHead;
        private System.Windows.Forms.ColumnHeader discountColumnHead;
        private System.Windows.Forms.Label closeLbl;
        private System.Windows.Forms.Label minifyLbl;
        private System.Windows.Forms.Panel barPanel;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.PictureBox loadingPicture;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.Button errorBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label crossIcon;
    }
}

