using System;

    class Addition
    {
      void Add(int x,int y)
        {
            Console.WriteLine(x + y);

        }
        void Add(int x, float y)
        {
            Console.WriteLine(x + y);

        }
        void Add(float x, int y)
        {
            Console.WriteLine(x + y);

        }
        void Add(float x, float y)
        {
            Console.WriteLine(x + y);

        }

        public static void Main()
        {
            Addition kp = new Addition();

            Console.WriteLine("enter the first value:-");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the Second value:-");
            int y = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("The sum of the values is:-");

        kp.Add(x ,y);
            Console.ReadLine();
        }

      
    
}
