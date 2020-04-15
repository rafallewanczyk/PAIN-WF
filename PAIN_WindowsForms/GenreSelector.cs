using System;
using System.Windows.Forms;

namespace PAIN_WindowsForms
{
    public partial class GenreSelector : UserControl
    {
        public event genreChangedHandler genreChanged; 
        int index_;
        public int current_index
        {
            get
            {
                return index_;
            }
            set
            {
                index_ = value;
                pictureBox1.Image = imageList1.Images[current_index];
                genreChanged?.Invoke(this, new GenreChanged(value));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            current_index = (current_index + 1) % 3;
            pictureBox1.Image = imageList1.Images[current_index];
        }

        public GenreSelector()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];
            current_index = 2;
        }

        public String Selected
        {
            get
            {
                if (current_index == 0)
                {
                    return "Pop";
                }
                else if (current_index == 1)
                {
                    return "Rock";
                }
                else if (current_index == 2)
                {
                    return "Pop";
                }
                else throw new unknownGenre(); 
            }
        }
    }

    public class GenreChanged : EventArgs
    {
        public int new_index { get; set; } 
        public string new_genre { get; set; }

        public GenreChanged(int newIndex_)
        {
            new_index = newIndex_;
            new_genre = Selected(new_index);
        }

        public String Selected(int index)
        {                                    
            if (index == 0)
            {
                return "Pop";
            }
            else if (index == 1)
            {
                return "Rock";
            }
            else if (index == 2)
            {
                return "Rap";
            }
            else throw new unknownGenre();
        }
    }
        class unknownGenre : Exception { }
        public delegate void genreChangedHandler(object sender, GenreChanged e); 
    }
    