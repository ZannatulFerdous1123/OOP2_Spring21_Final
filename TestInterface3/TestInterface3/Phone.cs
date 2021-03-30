using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface3
{
    class Phone:IMusicPlayer,IRadioPlayer
    {
        public int TotalNumberOfMusic { get; set; }

        MusicFile[] musicfile;
        public Phone()
        {
            musicfile = new MusicFile[500];
        }

        public void addMusicFile(params MusicFile[] musicfile)
        {
            foreach( var a in musicfile)
            {
                this.musicfile [TotalNumberOfMusic++] = a;
            }
        }

        public void showAllMusic()
        {
            for (int i = 0; i < TotalNumberOfMusic; i++)
            {
                musicfile[i].show();
            }
        }


        public void Switch(bool on)
        {
            if (on == true)
            {
                Console.WriteLine("Music Player is ON");
            }
            else
            {
                Console.WriteLine("Music Player is OFF");
            }
        }

        public void play(bool on)
        {
            if (on == true)
            {
                Console.WriteLine("Music Player is playing");
            }
            else
            {
                Console.WriteLine("Music Player is OFF");
            }

        }

        public void setVolume(int loud)
        {
            if (loud >= 7 && loud <= 10)
            {
                Console.WriteLine("WARNING!!! Load Sound can damage your ears ");
            }
            else if (loud >= 1 && loud < 7)
            {
                Console.WriteLine("normal sound");

            }
            else if (loud == 0)
            {
                Console.WriteLine("Muted");
            }
            else
            {

                Console.WriteLine("Volume range is 0 to 10");
            }
        }



        public void playNext()
        {
            Console.WriteLine("Playing Next");

        }

        public void playPrevious()
        {
            Console.WriteLine("Playing Previous");

        }

        public void SwitchRadio(bool on)
        {
            if (on == true)
            {
                Console.WriteLine("Radio Player is ON");
            }
            else
            {
                Console.WriteLine("Radio Player is OFF");
            }
        }

        public void retune(double freq)
        {
            if (freq == 89.6)
            {
                Console.WriteLine("Radio Today");
            }
            else if (freq == 88.0)
            {
                Console.WriteLine("Radio Foorti");
            }
            else if (freq == 104)
            {
                Console.WriteLine("Bangladesh Betar");
            }
            else
            {
                Console.WriteLine("Please Select Frequency!! 89.6 or 88.0 or 104");
            }





        }

        public void setVolumeRadio(int loud)
        {
            if (loud >= 7 && loud <= 10)
            {
                Console.WriteLine("WARNING!!! Load Sound can damage your ears ");
            }
            else if (loud >= 1 && loud < 7)
            {
                Console.WriteLine("normal sound");

            }
            else if (loud == 0)
            {
                Console.WriteLine("Muted");
            }
            else
            {

                Console.WriteLine("Volume range is 0 to 10");
            }

        }

        public void changeChannel()
        {
            Console.WriteLine("Channel Changed");

        }
    }
}
