using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;

namespace MusicPlayList
{
    [Serializable]
    public partial class CreatePlayList : Form
    {
        SongList musicPlayLists;
        Song song;
        public CreatePlayList(SongList songList)
        {
            musicPlayLists = songList;
            InitializeComponent();
            Display();

        }
        private void dgvCreatePlaylist_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSongName.Text = dgvCreatePlaylist.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSinger.Text = dgvCreatePlaylist.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbDuration.Text = dgvCreatePlaylist.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtGenre.Text = dgvCreatePlaylist.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 File (*.mp3)|*.mp3";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPaths.Text = ofd.FileName;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Song song = new Song();
            song.Name = txtSongName.Text;
            song.Singer = txtSinger.Text;
            song.Duration = lbDuration.Text;
            song.Genre = txtGenre.Text;
            song.setFileName(txtPaths.Text);
            musicPlayLists.AddHead(song);
            Display();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            string name = dgvCreatePlaylist.SelectedRows[0].Cells[0].Value.ToString();
            musicPlayLists.RemoveSong(name);
            Display();
        }

        private void Display()
        {
            dgvCreatePlaylist.DataSource = musicPlayLists.toArray();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = dgvCreatePlaylist.SelectedRows[0].Cells[0].Value.ToString();
            Song bh = musicPlayLists.getNameSong(name).Song;
            bh.Name = txtSongName.Text;
            bh.Singer = txtSinger.Text;
            bh.Genre = txtGenre.Text;
            bh.Duration = lbDuration.Text;
            bh.setFileName(txtPaths.Text);
            Display();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (dgvCreatePlaylist.Rows.Count > 0)
            {
                musicPlayLists.RemoveAllSong();
                Display();
            }
        }

        private void txtPaths_TextChanged(object sender, EventArgs e)
        {
            Mp3FileReader reader = new Mp3FileReader(txtPaths.Text);
            TimeSpan duration = reader.TotalTime;
            lbDuration.Text = duration.ToString().Substring(0, 8);
            string songname = Path.GetFileName(txtPaths.Text);
            string text = "";
            text = songname;
            string[] arr = text.Split('-');
            txtSongName.Text = arr[0];
            
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (dgvCreatePlaylist.Rows.Count > 0)
            {
                musicPlayLists.Sort();
                Display();
            }
        }

    }
}
