using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DVD.process();
            Console.ReadLine();
        }
    }

    public class DVD
    {
        public string name;
        public int releaseYear;
        public string director;

        public DVD(string name, int relYear, string director)
        {
            this.name = name;
            releaseYear = relYear;
            this.director = director;
        }

        public override string ToString() => $"{name}, directed by {director}, released in {releaseYear}";

        public static void process()
        {
            DVD o = new DVD("QFLES", 2019, "bhanu");
            Console.WriteLine(o.ToString());
            DVD[] dvds = new DVD[15];
            dvds[7] = o;
            int[] arr = new int[4];
            Console.WriteLine(arr[3]);
        }
    }
}
