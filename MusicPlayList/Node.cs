using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayList
{
    [Serializable]
    public class Node
    {
        private Song song;
        private Node next;
        private Node prev;
        public Node() { }
        public Node(Song _song)
        {
            Song = _song;
            next = null;
            prev = null;
        }

        public Song Song { get => song; set => song = value; }
        public Node Next { get => next; set => next = value; }
        public Node Prev { get => prev; set => prev = value; }
    }

}
