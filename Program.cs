class Program
{

    static void Main(string[] args)
    {
        
        //Coffee coffee = new Coffee();
        Late late = new Late();
        Expresso expresso = new Expresso();
        
        
        Console.ReadKey();

        
    }



    abstract class Coffee
    {
        public int temperature = 0;
        public int intensive = 0;

    }

    class Late : Coffee
    {
        public int temperature = 70;
        public int intensive = 2;
    }

    class Expresso : Coffee
    {
        public int temperature = 70;
        public int intensive = 5;
    }

}