using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MusicPlayList
{
    [Serializable]
    public class Song
    {
        private string m_name;//tên bài hát
        private string m_singer;//tên ca sỹ
        private string m_duration;//thời lượng
        private string m_filename;//đường dẫn
        private string m_genre;//thể loại

        public string Name { get => m_name; set => m_name = value; }
        public string Singer { get => m_singer; set => m_singer = value; }
        public string Duration { get => m_duration; set => m_duration = value; }
        public string Genre { get => m_genre; set => m_genre = value; }

        public string getFileName()
        {
            return m_filename;
        }
        public void setFileName(string filename)
        {
            m_filename = filename;
        }
        public Song()
        {
            m_name = "";
            m_singer = "";
            m_duration = "";
            m_filename = "";
            m_genre = "";
        }

        public Song(string name,string singer,string duration,string filename,string genre)
        {
            m_name = name;
            m_singer = singer;
            m_duration = duration;
            m_filename = name;
            m_genre = genre;
        }

    }
}
