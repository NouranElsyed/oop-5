namespace secondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters.Call each method in Main().
            // Modify the program so that you do not have to create an instance of class to call the four methods.
            Maths result = new Maths();
    
            Console.WriteLine(result.Add(2, 5));
            Console.WriteLine(result.Subtract(2, 5));
            Console.WriteLine(result.Multiply(2, 5));
            Console.WriteLine(result.Divide(2, 5));





        }
    }
}
