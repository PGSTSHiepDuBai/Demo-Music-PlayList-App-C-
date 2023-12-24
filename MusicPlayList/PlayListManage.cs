using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MusicPlayList
{
    public partial class PlayListManage : Form
    {
        private List<SongList> list = new List<SongList>();
        private string fileName = "MP3.txt";
        public PlayListManage()
        {
            InitializeComponent();
        }

        private void PlayListManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Write();
        }

        private void PlayListManage_Load(object sender, EventArgs e)
        {
            dgvPlayListManage.AutoGenerateColumns = false;
            Read();
            DisPlay();
        }

        private void DisPlay()
        {
            dgvPlayListManage.DataSource = list.ToList();
        }
        private void dgvPlayListManage_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPlayListManage.SelectedRows.Count == 1)
            {
                int index = dgvPlayListManage.SelectedRows[0].Index;
                CreatePlayList callFormCreate = new CreatePlayList(list[index]);
                callFormCreate.ShowDialog();
            }
        }
        private void Read()
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                list = (List<SongList>)bf.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Write()
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, list);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (dgvPlayListManage.SelectedRows.Count == 1)
            {
                int index = dgvPlayListManage.SelectedRows[0].Index;
                Player f = new Player(list[index]);
                this.Hide();
                f.ShowDialog();
            }
        }

        private void btnAddPlayList_Click(object sender, EventArgs e)
        {
            SongList songlist = new SongList();
            bool cancel = false;
            NamedPlaylist newcrea = new NamedPlaylist(songlist, cancel);
            newcrea.ShowDialog();
            if (cancel == false)
            {
                list.Add(songlist);
            }
            DisPlay();
        }

        private void btnDeletePlaylist_Click(object sender, EventArgs e)
        {
            int index = dgvPlayListManage.SelectedRows[0].Index;
            list.Remove(list[index]);
            DisPlay();
        }

        private void btnDelAllPlayList_Click(object sender, EventArgs e)
        {
            if(dgvPlayListManage.Rows.Count > 0)
            {
                list.Clear();
                DisPlay();
            }
        }
    }
}
