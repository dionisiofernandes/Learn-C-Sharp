using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Static_Class_Attributes
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(string aTitel, string aArtist, int ADuration)
        {
            title = aTitel;
            artist = aArtist;
            duration = ADuration;
            songCount++;
        }

        public int getSongCount()
        {
            return  songCount;
        }

    }
}
