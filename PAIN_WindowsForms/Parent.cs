using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace PAIN_WindowsForms
{
    public partial class Parent : Form
    {
        public ArrayList songs { get; }

        private Filter filterWindow;
        private AddSong addSongWindow;
        public Parent()
        {
            InitializeComponent();
            songs = new ArrayList();
            filterWindow = new Filter(this);
            filterWindow.MdiParent = this;
            filterWindow.Show();
            filterWindow.Activate();



            AddSongToBase(new Song("ILOVEITWHENTHEYRUN", "XXXTENTACION", 2017, "Rap"));
            AddSongToBase(new Song("Highway to Hell", "AC/DC", 1917, "Rock"));
            AddSongToBase(new Song("Beat it", "Michael Jackson", 1928, "Pop"));


        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



          public void AddSongToBase(Song song)
        {

            this.songs.Add(song);
            foreach (Filter fw in MdiChildren)
            {
                fw.Reload();
            }
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterWindow = new Filter(this);
            filterWindow.MdiParent = this;
            filterWindow.Show();
        }

        private void Parent_MdiChildActivate(object sender, EventArgs e)
        {
            refresh_status();
        }

        public void refresh_status()
        {
            status.Text = "Liczba piosenek w widoku: " + ((Filter)ActiveMdiChild).printed_values;
        }

        private void usunToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MdiChildren.Count() > 1)
            {
                Form toDelete = this.ActiveMdiChild;
                toDelete.Close();
            }
            

        }

        private void usunToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filter temp = (Filter)ActiveMdiChild;
            RemoveSongFromBase(temp.selected_item);
            refresh_status();
        }

        public void RemoveSongFromBase(Song song_)
        {
            songs.Remove(song_);
            foreach (Filter fw in MdiChildren)
            {
                fw.Reload();
            }
        }

        private void popToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSongWindow = new AddSong(this, 0, null);
            addSongWindow.Show();
        }

        private void rockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSongWindow = new AddSong(this, 1, null);
            addSongWindow.Show();
        }

        private void rapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSongWindow = new AddSong(this, 2, null);
            addSongWindow.Show();
        }
    }
}
