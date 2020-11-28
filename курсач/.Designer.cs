
namespace курсач
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.FilmsPanel = new System.Windows.Forms.Panel();
            this.btnFilm = new System.Windows.Forms.Button();
            this.PanelSeries = new System.Windows.Forms.Panel();
            this.btnSeries = new System.Windows.Forms.Button();
            this.btnGenres = new System.Windows.Forms.Button();
            this.panelNewsMenu = new System.Windows.Forms.Panel();
            this.btnNews = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.FilmsPanel);
            this.panelSideMenu.Controls.Add(this.btnFilm);
            this.panelSideMenu.Controls.Add(this.PanelSeries);
            this.panelSideMenu.Controls.Add(this.btnSeries);
            this.panelSideMenu.Controls.Add(this.btnGenres);
            this.panelSideMenu.Controls.Add(this.panelNewsMenu);
            this.panelSideMenu.Controls.Add(this.btnNews);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(170, 599);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.Location = new System.Drawing.Point(0, 231);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(170, 30);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // FilmsPanel
            // 
            this.FilmsPanel.AutoSize = true;
            this.FilmsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.FilmsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilmsPanel.Location = new System.Drawing.Point(0, 231);
            this.FilmsPanel.Name = "FilmsPanel";
            this.FilmsPanel.Size = new System.Drawing.Size(170, 0);
            this.FilmsPanel.TabIndex = 12;
            // 
            // btnFilm
            // 
            this.btnFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilm.FlatAppearance.BorderSize = 0;
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFilm.Location = new System.Drawing.Point(0, 199);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFilm.Size = new System.Drawing.Size(170, 32);
            this.btnFilm.TabIndex = 10;
            this.btnFilm.Text = "Фільми";
            this.btnFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // PanelSeries
            // 
            this.PanelSeries.AutoSize = true;
            this.PanelSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSeries.Location = new System.Drawing.Point(0, 199);
            this.PanelSeries.Name = "PanelSeries";
            this.PanelSeries.Size = new System.Drawing.Size(170, 0);
            this.PanelSeries.TabIndex = 9;
            // 
            // btnSeries
            // 
            this.btnSeries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeries.FlatAppearance.BorderSize = 0;
            this.btnSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeries.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSeries.Location = new System.Drawing.Point(0, 169);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSeries.Size = new System.Drawing.Size(170, 30);
            this.btnSeries.TabIndex = 6;
            this.btnSeries.Text = "Серіали";
            this.btnSeries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeries.UseVisualStyleBackColor = true;
            this.btnSeries.Click += new System.EventHandler(this.btnSeries_Click);
            // 
            // btnGenres
            // 
            this.btnGenres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenres.FlatAppearance.BorderSize = 0;
            this.btnGenres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenres.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGenres.Location = new System.Drawing.Point(0, 139);
            this.btnGenres.Name = "btnGenres";
            this.btnGenres.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGenres.Size = new System.Drawing.Size(170, 30);
            this.btnGenres.TabIndex = 3;
            this.btnGenres.Text = "Жанри";
            this.btnGenres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenres.UseVisualStyleBackColor = true;
            this.btnGenres.Click += new System.EventHandler(this.btnGenres_Click);
            // 
            // panelNewsMenu
            // 
            this.panelNewsMenu.AutoSize = true;
            this.panelNewsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelNewsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNewsMenu.Location = new System.Drawing.Point(0, 139);
            this.panelNewsMenu.Name = "panelNewsMenu";
            this.panelNewsMenu.Size = new System.Drawing.Size(170, 0);
            this.panelNewsMenu.TabIndex = 2;
            // 
            // btnNews
            // 
            this.btnNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNews.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNews.FlatAppearance.BorderSize = 0;
            this.btnNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNews.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNews.Location = new System.Drawing.Point(0, 109);
            this.btnNews.Name = "btnNews";
            this.btnNews.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNews.Size = new System.Drawing.Size(170, 30);
            this.btnNews.TabIndex = 1;
            this.btnNews.Text = "Новинки";
            this.btnNews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.iconPictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(170, 109);
            this.panelLogo.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ErrorImage = global::курсач.Properties.Resources.КрастныйГлаз;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PhotoVideo;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonShadow;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 75;
            this.iconPictureBox1.InitialImage = global::курсач.Properties.Resources.КрастныйГлаз;
            this.iconPictureBox1.Location = new System.Drawing.Point(46, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(75, 75);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(170, 0);
            this.panelChildForm.MinimumSize = new System.Drawing.Size(551, 499);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(764, 599);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::курсач.Properties.Resources.Иконка;
            this.pictureBox1.Location = new System.Drawing.Point(120, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 599);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 638);
            this.Name = "Form1";
            this.Text = "Каталог фільмів та серіалів";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnSeries;
        private System.Windows.Forms.Button btnGenres;
        private System.Windows.Forms.Panel panelNewsMenu;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel FilmsPanel;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Panel PanelSeries;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

