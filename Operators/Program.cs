namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a + b); //output is 13
            Console.WriteLine(a / b); //output is 3 cuz both a and b are integers
            Console.WriteLine((float)a / (float)b); //if you want a float you have to cast to a float 
            Console.WriteLine(a + b * c); //output is 7 since it uses PEMDAS
            Console.WriteLine((a + b) * c); //output is 9 since it uses PEMDAS
            Console.WriteLine(a > b); //output is False, comparison operator output is always a boolean
            Console.WriteLine(a == b); //output is False
            Console.WriteLine(a != b); //output is True
            Console.WriteLine(!(a != b)); //output is False, first parenthesis comparison value is found then the outer ! is determined
            Console.WriteLine(c > b && c > a); //output is True, true and true results in true
            Console.WriteLine(c > b && c == a); //output is False, true and false results in false
            Console.WriteLine(c > b || c == a); //output is True, one true side of an Or operator makes it True
            Console.WriteLine(!(c > b || c == a)); //output is Falsee

        }
    }
}
