using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayList
{
    public partial class NamedPlaylist : Form
    {
        SongList songList;
        Boolean cancel;
        public NamedPlaylist(SongList songList, Boolean cancel)
        {
            this.songList = songList;
            this.cancel = cancel;
            InitializeComponent();
        }

        private void btnNamedPlaylist_Click(object sender, EventArgs e)
        {
            songList.PlayListName = txtEnterNamePlaylist.Text;
            CreatePlayList f = new CreatePlayList(songList);
            this.Hide();
            f.ShowDialog();

            this.Close();
        }

        private void btnExitNamedPlaylist_Click(object sender, EventArgs e)
        {
            cancel = true;
            Close();
        }
    }
}
