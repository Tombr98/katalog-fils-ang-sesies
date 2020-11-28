using System;
using System.Windows.Forms;
using курсач.Films;
using курсач.Films.Film;



namespace курсач
{
    public partial class Form1 : Form
    
    {
        private FilmTemplate FilmForm { get; set; } = new FilmTemplate();
        private FrmReference HelpForm { get; set; } = new FrmReference();
        public Form1()
        {
            InitializeComponent();
            FillSideMenu();
            customizeDesing();
        }

        private void FillSideMenu()
        {
            FillNewFilms();
            FillSeries();
            FillFilms();
            
        }

        private void FillFilms()
        {
            foreach (FilmC film in FilmsC.FilmsList)
            {
                if (film.TypeF == TypeOfFilm.Film)
                    AddFilmToSideBar(film.Name, FilmsPanel);
            }
        }

        private void FillNewFilms()
        {
            foreach (FilmC film in FilmsC.FilmsList)
            {
                if (film.IsNew)
                    AddFilmToSideBar(film.Name, panelNewsMenu);
            }
            
        }

        private void FillSeries()
        {
            foreach (FilmC film in FilmsC.FilmsList)
            {
                if (film.TypeF == TypeOfFilm.Series)
                    AddFilmToSideBar(film.Name, PanelSeries);
            }
        }

        private void AddFilmToSideBar(string nameOfFilm, Panel panel)
        {
            Button button = new Button();
            button.Dock = DockStyle.Top;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = System.Drawing.Color.LightGray;
            button.Text = nameOfFilm;
            button.Padding = new Padding(25, 0, 0, 0);
            button.Size = new System.Drawing.Size(169, 26);
            button.Name = nameOfFilm;
            button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button.UseVisualStyleBackColor = true;
            panel.Controls.Add(button);
            panel.Tag = button;
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            foreach (FilmC film in FilmsC.FilmsList)
            {
                if(button.Text == film.Name)
                {
                    FilmForm.Film = film;
                    openChildForm(FilmForm);
                }
            }
        }

        private void customizeDesing()
        {
            panelNewsMenu.Visible = false;
            PanelSeries.Visible = false;
            FilmsPanel.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelNewsMenu.Visible == true)
                panelNewsMenu.Visible = false;
            if (PanelSeries.Visible == true)
                PanelSeries.Visible = false;
            if (FilmsPanel.Visible == true)
                FilmsPanel.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btnNews_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNewsMenu);
        }

        private void btnGenres_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSeries);
        }

        
        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(HelpForm);
            hideSubMenu();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            showSubMenu(FilmsPanel);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            //Width = panelSideMenu.Width + childForm.Width;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            activeForm.Hide();
        }
    }
}
