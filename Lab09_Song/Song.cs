using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Song
{
    enum SongGenre { Unclassified = 0, Pop = 1, Rock = 2, Blues = 4, Country = 8, Metal = 16, Soul = 32 }
    class Song
    {
        public string Artist { get; }
        public string Title { get; }
        public double Lenght { get; }
        public SongGenre Genre { get; }

        #region Constructor
        public Song (string title, string artist, double length, SongGenre genre)
        {
            Artist = artist;
            Title = title;
            Lenght = length;
            Genre = genre;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return $"{Title}, {Artist}, {Lenght}, {Genre}";
        }
        #endregion
    }
}
