using System;
using System.Windows.Forms;

namespace PAIN_WindowsForms
{
    public partial class AddSong : Form
    {
        private Parent _parent;
        private Song initial_song;

        public AddSong(Parent parent, int image_index, Song init)
        {
            InitializeComponent();
            genreSelector1.current_index = image_index; 
            _parent = parent;
            initial_song = init; 

            if(initial_song != null)
            {
                nameBox.Text = initial_song.name;
                authorBox.Text = initial_song.author;
                yearBox.Text = initial_song.release_year.ToString();
                switch (initial_song.genre)
                {
                    case "Pop":
                        genreSelector1.current_index = 0;
                        break;
                    case "Rock":
                        genreSelector1.current_index = 1;
                        break;
                    case "Rap":
                        genreSelector1.current_index = 2;
                        break; 
                    default:
                        break;
                }
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            nameBox_Validated(null, null);
            authorBox_Validated(null, null);
            yearBox_Validated(null, null); 
            if(errorProvider1.GetError(nameBox) == String.Empty &&
                errorProvider1.GetError(authorBox) == String.Empty &&
                errorProvider1.GetError(yearBox) == String.Empty)
            {
                if (initial_song == null)
                {
                    Song _song = new Song(nameBox.Text, authorBox.Text, Int32.Parse(yearBox.Text), genreSelector1.Selected);
                    _parent.AddSongToBase(_song);
                    this.Close();
                }
                else
                {
                    Song _song = new Song(nameBox.Text, authorBox.Text, Int32.Parse(yearBox.Text), genreSelector1.Selected);
                    _parent.RemoveSongFromBase(initial_song);
                    _parent.AddSongToBase(_song);
                    this.Close();
                }
            }
           


        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (nameBox.Text == "")
            {
                errorProvider1.SetError(nameBox, "pole wymagane"); 
            }
        }

        private void authorBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (nameBox.Text == "")
            {
                errorProvider1.SetError(authorBox, "pole wymagane");
            }
        }

        private void yearBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (nameBox.Text == "")
            {
                errorProvider1.SetError(yearBox, "pole wymagane");
            }
            try
            {
                Int32.Parse(yearBox.Text);
            }
            catch(System.FormatException)
            {
                errorProvider1.SetError(yearBox, "dozwolone tylko cyfry");
            }
        }

        private void genreChanged(object sender, GenreChanged e)
        {
            genre_text.Text = e.new_genre;
            Console.WriteLine("event"); 
        }
    }

}
