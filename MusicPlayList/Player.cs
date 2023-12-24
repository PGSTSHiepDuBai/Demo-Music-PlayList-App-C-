using System;
using System.Windows.Forms;

namespace MusicPlayList
{
    [Serializable]
    public partial class Player : Form
    {
        private SongList songList;
        public Player(SongList songList)
        {
            this.songList = songList;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPlaylist.AutoGenerateColumns = false;
            DisPlay();
        }

        private void DisPlay()
        {
            dgvPlaylist.DataSource = this.songList.toArray();
        }

        private void Play(int index)
        {
            WMPplaylist.URL = songList.getSong_Index(index).Song.getFileName();
            WMPplaylist.Ctlcontrols.play();
        }
        private void dgvPlaylist_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPlaylist.SelectedRows.Count == 1)
            {
                Play(dgvPlaylist.SelectedRows[0].Index);
            }

        }
        private void btnBackPlayList_Click(object sender, EventArgs e)
        {
            WMPplaylist.Ctlcontrols.stop();
            this.Hide();
            this.Close();
        }

        private void Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMPplaylist.Ctlcontrols.stop();
            this.Hide();
            PlayListManage f = new PlayListManage();
            f.Show();
            this.Close();
        }
    }
}
