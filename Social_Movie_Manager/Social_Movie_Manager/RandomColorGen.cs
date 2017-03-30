using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Social_Movie_Manager
{
    public static class RandomColorGen
    {
        private static Color[] Colors = new Color[5]
        {
            Color.FromArgb(200,38,35,34),
            Color.FromArgb(200,54,65,86),
            Color.FromArgb(200,75,40,78),
            Color.FromArgb(200,75,100,74),
            Color.FromArgb(200,124,54,38)
        };

        public static Color GetRandomColor()
        {
            Random rnd = new Random();
            return Colors[rnd.Next(0, 5)];
        }


    }
}
