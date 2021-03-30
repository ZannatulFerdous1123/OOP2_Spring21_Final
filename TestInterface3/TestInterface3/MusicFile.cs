using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface3
{
    class MusicFile
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        private int yearOfRelease;

        public int YearOfRelease
        {
            get { return yearOfRelease; }
            set { yearOfRelease = value; }
        }
        private int durationInSeconds;

        public int DurationInSeconds
        {
            get { return durationInSeconds; }
            set { durationInSeconds = value; }
        }
        public MusicFile()
        {

        }
        public MusicFile(string Title, string Artist,int YearOfRelease, int DurationInSeconds)
        {
            title = Title;
            artist = Artist;
            yearOfRelease = YearOfRelease;
            durationInSeconds = DurationInSeconds;
        }
        public void changeTitle(string title)
        {
            this.title = title;
        }

        public void show()
        {
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Artist name: " + artist);
            Console.WriteLine("Year of release : " + yearOfRelease);
            Console.WriteLine("Music duration: " + durationInSeconds);
            Console.WriteLine("                      " );
        }
    }
}
