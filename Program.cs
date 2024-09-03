namespace staticVSnonstatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static
            //Myclass.staticMethods();
            //int value = Myclass.staticvalue;
            //Console.WriteLine(value);

            //Myclass obj1 = new Myclass();
            //Myclass obj2 = new Myclass();

            //obj1.IncrementStaticValue(); // 11
            //obj2.IncrementStaticValue(); // 12

            //int value = Myclass.staticvalue;
            //Console.WriteLine(value);

            // Non-static
            //Myclass obj = new Myclass();
            //obj.NonstaticMethods();
            //int value = obj.Nonstaticvalue;
            //Console.WriteLine(value);

            Myclass obj1 = new Myclass();
            Myclass obj2 = new Myclass();

            obj1.IncrementNonStaticValue();
            obj2.IncrementNonStaticValue();

            //int value1 = obj1.Nonstaticvalue;
            int value2 = obj2.Nonstaticvalue;
            //Console.WriteLine(value1);
            Console.WriteLine(value2);

        }
    }

    // Non-static
    public class Myclass
    {
        public int Nonstaticvalue = 20;
        public void IncrementNonStaticValue()
        {
            Nonstaticvalue++; // Nonstaticvalue = Nonstaticvalue + 1
        }
        public void NonstaticMethods()
        {
            Console.WriteLine("This is a Non-static methods.");
        }
    }

    //Static
    //public class Myclass
    //{
    //    public static int staticvalue = 10;
    //    public void IncrementStaticValue()
    //    {
    //        staticvalue++; // staticvalue = staticvalue + 1
    //    }
    //    public static void staticMethods()
    //    {
    //        Console.WriteLine("This is a static methods.");
    //    }
    //}
}
