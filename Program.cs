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

        public int MyYear{
            get { return year; }
            set { year = value; }
        }

        public virtual void sameMethodInBothClass(){
            System.Console.WriteLine("This is method of same name method...but in Painting class");
        } 

        public void methodOfPainting(){
            System.Console.WriteLine("Method Of Painting...");
        }

    }

    class Painter:Painting{
        public override void sameMethodInBothClass(){
            System.Console.WriteLine("This is a method of same name method...but in Painter Class");
        }

        public void methodPainter(){
            System.Console.WriteLine("Method Painter");
        }
    }
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Encapsulation
            Painting myPainting = new Painting();
            myPainting.MyName = "abcde";
            myPainting.MyArtist = "xyz";
            myPainting.MyMedium = "def";
            myPainting.MyYear = 2020;

            //Inheritance
            Painter newPaint = new Painter();

            System.Console.WriteLine("Name : "+myPainting.MyName);
            System.Console.WriteLine("Artist : "+myPainting.MyArtist);
            System.Console.WriteLine("Medium : "+myPainting.MyMedium);
            System.Console.WriteLine("Year : "+myPainting.MyYear);


            // Polymorphism
            Painting p1 = new Painting();
            Painting p2 = new Painter();
            p1.sameMethodInBothClass();
            p2.sameMethodInBothClass();

            // Abstraction
            Painter painter1 = new Painter();
            painter1.methodOfPainting();
            
        }
    }
}
