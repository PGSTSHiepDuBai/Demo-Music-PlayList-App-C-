using System;
using System.Reflection;

namespace MusicPlayList
{

    [Serializable]
    public class SongList
    {
        private string playlistName;
        private Node head, tail;
        private int length;

        public SongList()
        {
            length = 0;
            head = null;
            tail = null;
        }

        public Node Head { get => head; set => head = value; }
        public Node Tail { get => tail; set => tail = value; }
        public int Length { get => length; }
        public string PlayListName { get => playlistName; set => playlistName = value; }

        public void AddTail(Song song)
        {
            if (head == null)
            {
                head = tail = new Node(song);
            }
            else
            {
                Node newNode = new Node(song);
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
            length++;
        }
        public void AddHead(Song song)
        {
            if (head == null)
            {
                head = tail = new Node(song);
            }
            else
            {
                Node newNode = new Node(song);
                head.Prev = newNode;
                newNode.Next = head;
                head = newNode;
            }
            length++;
        }
        public Song[] toArray()
        {
            Node node = head;
            Song[] array = new Song[length];
            for (int i = 0; i < length ; i++, node = node.Next)
            {
                array[i] = node.Song;
            }
            return array;
        }
        public Node getNameSong(string songName)
        {
            Node temp = head;
            while(temp != null)
            {
                if(temp.Song.Name == songName)
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;
        }
        public void RemoveSong(string songName)
        {
            for (Node p = head; p != null; p = p.Next)
            {
                if (p.Song.Name == songName)
                {
                    if (p.Prev == null)
                    {
                        Head = Head.Next;
                        Head.Prev = null;
                        length--;
                        return;
                    }
                    else if (p.Next == null)
                    {
                        p.Prev.Next = null;
                        length--;
                        return;
                    }
                    else
                    {
                        p.Prev.Next = p.Next;
                        p.Next.Prev = p.Prev;
                        length--;
                        return;
                    }
                }
            }

        }
        public void RemoveAllSong()
        {
            head = null;
            tail = null;
            length = 0;
        }
        public void Sort()
        {
            if (length <= 1)
                return;
            Node s = head;
            Node index = null;
            bool swapped = false;
            while (s != null)
            {
                index = s.Next;
                while(index != null)
                {
                    if (string.Compare(s.Song.Name,index.Song.Name,StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        Song temp = s.Song;
                        s.Song = index.Song;
                        index.Song = temp;
                        swapped = true;
                    }
                    index = index.Next;
                }
                s = s.Next;
            }
        }

        public Node getSong_Index(int index)
        {
            Node s = head;
            for (int i = 0; i < index; i++)
            {
                s = s.Next;
            }
            return s;
        }
    }
}
