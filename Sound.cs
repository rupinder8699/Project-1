using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    public class Sound
    {
        public void load_sound()
        {
            System.Media.SoundPlayer loadobj = new System.Media.SoundPlayer(@"C:\Users\Rupinder Singh Com\source\repos\project 1\project 1\sources\sound\load.wav");
            loadobj.Play();
        }

        public void Spin_sound()
        {
            System.Media.SoundPlayer spinobj = new System.Media.SoundPlayer(@"C:\Users\Rupinder Singh Com\source\repos\project 1\project 1\sources\sound\scroll.wav");
            spinobj.Play();
        }

        public void shot_sound()
        {
            System.Media.SoundPlayer shotobj = new System.Media.SoundPlayer(@"C:\Users\Rupinder Singh Com\source\repos\project 1\project 1\sources\sound\gun shot.wav"); ;
            shotobj.Play();
        }
    }
}
