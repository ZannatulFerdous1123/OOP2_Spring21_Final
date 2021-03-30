using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile english = new MusicFile("baila conmigo","selena gomez",2021,300);
            MusicFile bangla = new MusicFile("Oniket Prantor", "Artcell", 2011, 300);
            MusicFile fav = new MusicFile("dukkho bilash", "Artcell", 2015, 300);
            Ipod ipod = new Ipod();
            Console.WriteLine("FOR IPOD");
            english.changeTitle("Naturally");
            ipod.addMusicFile(english,bangla,fav);
            ipod.showAllMusic();
            ipod.Switch(true);
            ipod.play(true);
            ipod.setVolume(10);
            ipod.playNext();
            ipod.playPrevious();

            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("FOR PHONE");
            Phone phone = new Phone();
            phone.addMusicFile(english, bangla, fav);
            phone.showAllMusic();
            phone.Switch(true);
            phone.play(true);
            phone.setVolume(9);

            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("RADIO PLAYER IN PHONE");
            phone.SwitchRadio(true);
            phone.setVolumeRadio(9);
            phone.retune(104);
            phone.changeChannel();
        }
    }
}
