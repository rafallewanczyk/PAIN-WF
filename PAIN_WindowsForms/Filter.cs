using System;
using System.Linq;
using System.Windows.Forms;

namespace PAIN_WindowsForms
{
    public partial class Filter : Form
    {
        public int printed_values { get; set; }
        public Song selected_item { get; set; }

        private Parent parent;
        public Filter(Parent _parent)
        {
            printed_values = 0;
            InitializeComponent();
            parent = _parent;
            this.Reload();
        }

        public void Reload()
        {
            listView1.Items.Clear();
            foreach (Song song in parent.songs)
            {
                var row = new String[] { song.name, song.author, song.release_year.ToString(), song.genre };
                var lvi = new ListViewItem(row);
                lvi.Tag = song;
                if (comboBox1.SelectedIndex == 0) listView1.Items.Add(lvi);
                if (comboBox1.SelectedIndex == 1 && song.release_year < 2000) listView1.Items.Add(lvi);
                if (comboBox1.SelectedIndex == 2 && song.release_year >= 2000) listView1.Items.Add(lvi);
            }
            printed_values = listView1.Items.Count;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Reload();
            parent.refresh_status();
        }

        private void Filter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.parent.MdiChildren.Count() == 1 && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                selected_item = (Song)listView1.SelectedItems[0].Tag;
        }

        AddSong addWindow;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            addWindow = new AddSong(this.parent, 0, (Song)listView1.SelectedItems[0].Tag);
            addWindow.Show();
        }

        private void Filter_Load(object sender, EventArgs e)
        {

        }
    }
}
