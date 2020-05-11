using System;

namespace oop_c_sharp_assignment {

    class Painting {
        private string name;
        private string artist;
        private string medium;
        private int year;

        public string MyName{
            get { return name; }
            set { name = value; }
        }

        public string MyArtist{
            get { return artist; }
            set { artist = value; }
        }

        public string MyMedium{
            get { return medium; }
            set { medium = value; }
        }

        public string MyYear{
            get { return year; }
            set { year = value; }
        }

    }
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
