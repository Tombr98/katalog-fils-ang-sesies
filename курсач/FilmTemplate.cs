using System;
using System.Windows.Forms;
using курсач.Films.Film;

namespace курсач
{
    public partial class FilmTemplate : Form
    {
        private FilmC _Film = new FilmC();

        public FilmC Film 
        { 
            get => _Film;
            set
            {
                _Film = value;
                RefreshLabels();
            } 
        }


        public FilmTemplate()
        {
            InitializeComponent();
        }

        private void RefreshLabels()
        {
            LabelName.Text = "Назва: " + _Film.Name;
            LabelCountry.Text = "Країна: " + _Film.Country;
            LabelDescription.Text = _Film.Description;
            LabelDuration.Text = "Тривалість: " + _Film.Duration.ToString() + " хв.";
            LabelPremier.Text = "Дата прем'єри: " + _Film.ReleaseData.ToString();
            LabelProducer.Text = "Режисер: " + _Film.Producer;
            LabelRaiting.Text = "Рейтинг: " + _Film.Rating;
            LabelTranslation.Text = "Переклад: " + _Film.Translation;
            LabelType.Text = "Тип: " + (_Film.TypeF == TypeOfFilm.Film ? "Фільм" : "Серіал");
            LabelGenres.Text = "Жанр: " + _Film.Jenres;
            IsNewLabel.Visible = _Film.IsNew;
            PosterPictureBox.Image = _Film.Poster;
            

        }

        private void TrailerButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_Film.TrailerURL);
        }

        private void FilmTemplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void ExitForm3_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
