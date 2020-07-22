using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class MediaOperator
    {
        public void soundPlay() 
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Kodowanie\poker-chips-daniel_simon.wav");
            player.Play();
        }

    }
}
