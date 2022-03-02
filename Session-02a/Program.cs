// 1
Console.WriteLine("What's your name?");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name + "!");

//2 
Console.WriteLine("Give two numbers separated with space:");
while (true)
{
    try
    {
        List<float> numbers = Console.ReadLine().Trim().Split().Select(s => s.Replace(".", ",")).Select(s => float.Parse(s)).ToList();
        Console.WriteLine("Sum: " + (numbers[0] + numbers[1]) + "\n" + "Division: " + (numbers[0] / numbers[1]));
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Wrong numbers please try again...");
    }
}

//3
Console.WriteLine($"{-1 + 5 * 6}");
Console.WriteLine($"{38 + 5 % 7}");
Console.WriteLine($"{14 + (-3 * 6 / (double)7)}");
Console.WriteLine($"{2 + (13 / (double)6) * 6 + Math.Sqrt(7)}");
Console.WriteLine($"{(Math.Pow(6, 4) + Math.Pow(5, 7)) / (9 % 4)}");

//4
string[] genders = {"female", "male"};
while (true)
{
    try
    {
        Console.Write("Enter your age: ");
        string inputAge = Console.ReadLine();
        int age = int.Parse(inputAge);
        if(age < 10)
        {
            throw new ArgumentOutOfRangeException();
        }
        Console.Write("Enter your gender: ");
        string gender = Console.ReadLine();
        bool correct = false;
        foreach(string gen in genders)
        {
            if (gender.Trim().ToLower() == gen)
            {
                correct = true;
                break;
            }
        }
        if (!correct) throw new ArgumentException();

        Console.WriteLine($"You are {gender} and look younger than {age}.");
        break;

    }catch(ArgumentOutOfRangeException outOfRangeEx) 
    { 
    
        Console.WriteLine("You cannot enter less than 10!");
    }
    catch (ArgumentException ax)
    {
        Console.WriteLine("wrong gender!");
    }

    catch (Exception ex)
    {
        Console.WriteLine("Wrong input!");
    }
}

//5


static int ReadInteger()
{
    int seconds;
    while (true)
    {
        try
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            seconds = Int32.Parse(input);
            break;
        }
        catch (FormatException e)
        {
            Console.WriteLine("Please enter a valid integer number");
        }
    }
    return seconds;
}


//6
int seconds = ReadInteger();
   
int secs = seconds % 60;
int mins = seconds / 60 % 60;
int hours = seconds / 3600;
Console.WriteLine("Time without .NET libraries");
Console.WriteLine($"{hours}:{mins}:{secs}");




//7

TimeSpan time = TimeSpan.FromSeconds(seconds);

Console.WriteLine("\nTime using .NET libraries");
Console.WriteLine(time.ToString(@"hh\:mm\:ss\:fff"));



