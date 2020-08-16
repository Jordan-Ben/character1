using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace character1
{
    class Char
    {
        public string Name;
        public string[] Petal = { "Images/Petal2.bmp", "Images/Petal52.bmp" };
        public string[] Stem = { "Images/Stem1.bmp", "Images/Stem2.bmp" };
        public string[] Leaf = { "Images/leaf1.bmp", "Images/leaf2.bmp" };
        int currentPetal = 0;
        int currentStem = 0;
        int currentLeaf = 0;

        public BitmapImage GetNextPetal()
        {

            if (currentPetal < Petal.Length - 1)
                currentPetal++;
            else
                currentPetal = 0;
            return new BitmapImage(new Uri(Petal[currentPetal], UriKind.Relative));
        }

        public BitmapImage GetNextStem()
        {

            if (currentStem < Stem.Length - 1)
                currentStem++;
            else
                currentStem = 0;
            return new BitmapImage(new Uri(Stem[currentStem], UriKind.Relative));
        }
        public BitmapImage GetNextLeaf()
        {

            if (currentLeaf < Leaf.Length - 1)
                currentLeaf++;
            else
                currentLeaf = 0;
            return new BitmapImage(new Uri(Leaf[currentLeaf], UriKind.Relative));
        }

    }
}
