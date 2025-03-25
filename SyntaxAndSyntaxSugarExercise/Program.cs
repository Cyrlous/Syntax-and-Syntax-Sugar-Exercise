namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //initializes two implicitly typed variables
            var answer = 4;
            var response =" ";
            
            //uses ternary operator to display one of two possible interpolated statements
            response = answer < 9 ? $"{answer} is less than 9" : $"{answer} is greater than or equal to 9";
            
            Console.WriteLine(response);
        }
    }
}
