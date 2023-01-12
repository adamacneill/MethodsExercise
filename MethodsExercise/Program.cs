namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userColorName = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userAnimalName = Console.ReadLine();

            Console.WriteLine("Who is your favorite band?");
            string userBandName = Console.ReadLine();

            Console.WriteLine($"There is a person named {userName}. They are {age} years old.");
            Console.WriteLine($"{userName} enjoyed being {age}. They thought it was an interesting age to be, filled with lots of excitement.");
            Console.WriteLine($"Their favorite color is {userColorName}, which has nothing to do with a {userAnimalName}, their favorite animal.");
            Console.WriteLine($"They enjoyed music from their favorite band, {userBandName}. They often listened to them in their spare time.");
            Console.WriteLine($"{userName} bought concert tickets to {userBandName} and will be seeing them soon.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2, 2, 3, 5, 7);
            Console.WriteLine($"The Sum is: {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The Sum is: {product}");
        }

        public static int Sum(params int[] list)
        {
            int sum = 0;
            for(int i = 0; i < list.Length; i++)
            {
                sum=sum+list[i];
            }
           
            return sum;
        }
        
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}
