using ConsoleApp6;

static class Tetris
{

    static void Main(string[] args)
    {

            Area a1 = new Area(MyColorEnum.Magenta, "Peter", 20, 10);
            //udskriv objekterne ved hjælp af override string ToString() metoden
            Console.WriteLine(a1);

            Console.ForegroundColor
                = ConsoleColor.Red;
            Area a2 = new Area(MyColorEnum.Red, "Oliver", 172, 25);
            Console.WriteLine(a2);
            Console.ForegroundColor
                = ConsoleColor.Green;
            Area a3 = new Area(MyColorEnum.Green, "Subarna", 16, 7);

            Area[] areas = new Area[5];
            areas[0] = a1;
            areas[1] = a2;
            areas[2] = a3;
            Console.ForegroundColor
                = ConsoleColor.Cyan;
            areas[3] = new Area(MyColorEnum.Cyan, "Hansen", 3, 4);
            Console.ForegroundColor
                = ConsoleColor.Blue;
            areas[4] = new Area(MyColorEnum.Blue, "Babuska", 456, 567);
            foreach (Area a in areas)
                Console.WriteLine(a);
            Array.Sort(areas);

            int result = a1.CompareTo(a2);

            object o5 = new Area();
            Area a5 = (Area)o5;
            a5.GetName();


            Console.ForegroundColor
                = ConsoleColor.White;
            // Cubic
            Console.WriteLine("\n\tCubic is here");
            Cubic c1 = new Cubic();

            c1.setName("Monkey");
            c1.Height = 23;
            c1.Width = 12;
            c1.Length = 7;

            Cubic c2 = new Cubic();
            c2.setName("Monkey");
            c2.Height = 3423;
            c2.Width = 12;
            c2.Length = 7;

            Object[] objects = new object[8];
            objects[0] = c1;
            objects[1] = a1;
            objects[2] = c2;
            objects[3] = a2;
            objects[4] = a3;
            Console.ForegroundColor
                = ConsoleColor.Yellow;
            objects[5] = new Cubic(MyColorEnum.Yellow, "victor", 23, 45, 8);
            Console.ForegroundColor
                = ConsoleColor.Green;
            objects[6] = new Area(MyColorEnum.Green, "Joshi", 3, 4);
            objects[7] = new Cubic(MyColorEnum.Green, "@czehl", 45, 75, 56);

            foreach (Object o in objects)
                Console.WriteLine(o);


            Console.ForegroundColor
                = ConsoleColor.Red;
            Console.WriteLine("\n" + c1.ToString());
            Console.WriteLine(c2.ToString());

            Console.ReadKey();
        
        
    }
}


