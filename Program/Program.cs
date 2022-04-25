// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using Martin_Area_Calculator;

Options_Menu();

static void Options_Menu(){
    
    ConsoleKeyInfo userInput;

    do{
        Console.WriteLine("Choose from the following options:");
        Console.WriteLine("1. Get area of a square:");
        Console.WriteLine("2. Get area of a rectangle:");
        Console.WriteLine("3. Get area of a triangle:");
        Console.WriteLine("4. Get area of a parallelogram:");
        Console.WriteLine("5. Get radius of a circle:");
        Console.WriteLine("6. Get diameter of a circle:");
        Console.WriteLine("7. Exit:");

        userInput = Console.ReadKey();
        Console.WriteLine("");
        Console.Clear();
        ValidateInput_And_ProcessAreafunctions(userInput);

    } while (userInput.Key != ConsoleKey.D7 && userInput.Key != ConsoleKey.NumPad7);
}

static void ValidateInput_And_ProcessAreafunctions (ConsoleKeyInfo testInput){

    AreaCalculator ACM = new AreaCalculator();
    int CovertedHeight;
    int ConvertedWidth;

    if (!Regex.Match(testInput.Key.ToString(), ".*[1-7].*").Success){
        Bad_Input(testInput);
    }
    else if (testInput.Key == ConsoleKey.D1 || testInput.Key == ConsoleKey.NumPad1){
        Console.WriteLine("Enter a width: ");
        string NotCovertedWidth = Console.ReadLine();
        Console.WriteLine("Enter a height: ");
        string NotCovertedHeight = Console.ReadLine();
        Is_Square_Input_A_String(NotCovertedWidth, NotCovertedHeight, ACM);
        Press_Key();
    }
    else if (testInput.Key == ConsoleKey.D2 || testInput.Key == ConsoleKey.NumPad2){

        Console.WriteLine("Enter a width: ");
        ConvertedWidth = Convert_String_To_Int(Console.ReadLine());
        Console.WriteLine("Enter a height: ");
        CovertedHeight = Convert_String_To_Int(Console.ReadLine());

        if (ConvertedWidth != -1 || CovertedHeight != -1)
        {
            Console.WriteLine("The area is : " + ACM.getRectangleArea(ConvertedWidth, CovertedHeight));
        }
        else
        {
            Console.WriteLine("Error");
        }

        Press_Key();
    }
    else if (testInput.Key == ConsoleKey.D3 || testInput.Key == ConsoleKey.NumPad3){

        Console.WriteLine("Enter a width: ");
        ConvertedWidth = Convert_String_To_Int(Console.ReadLine());
        Console.WriteLine("Enter a height: ");
        CovertedHeight = Convert_String_To_Int(Console.ReadLine());

        if (ConvertedWidth != -1 || CovertedHeight != -1)
        {
            Console.WriteLine("The area is : " + ACM.getTriangleArea(ConvertedWidth, CovertedHeight));
        }
        else
        {
            Console.WriteLine("Error");
        }

        Press_Key();
    }
    else if (testInput.Key == ConsoleKey.D4 || testInput.Key == ConsoleKey.NumPad4){

        Console.WriteLine("Enter a width: ");
        ConvertedWidth = Convert_String_To_Int(Console.ReadLine());
        Console.WriteLine("Enter a height: ");
        CovertedHeight = Convert_String_To_Int(Console.ReadLine());

        if (ConvertedWidth != -1 || CovertedHeight != -1)
        {
            Console.WriteLine("The area is : " + ACM.getParallelogramArea(ConvertedWidth, CovertedHeight));
        }
        else
        {
            Console.WriteLine("Error");
        }

        Press_Key();
    }
    else if (testInput.Key == ConsoleKey.D5 || testInput.Key == ConsoleKey.NumPad5){
        
        Console.WriteLine("Enter a circumference: ");
        int CovertedCirc = Convert_String_To_Int(Console.ReadLine());
        if (CovertedCirc != -1)
        {
            Console.WriteLine("The radius is : " + ACM.getCircleRadius(CovertedCirc));
        }
        else
        {
            Console.WriteLine("Error");
        }
        
        Press_Key();
    }
    else if (testInput.Key == ConsoleKey.D6 ||testInput.Key == ConsoleKey.NumPad6){

        Console.WriteLine("Enter a circumference: ");
        int CovertedCirc = Convert_String_To_Int(Console.ReadLine());
        if (CovertedCirc != -1)
        {
            Console.WriteLine("The diameter is : " + ACM.getCircleDiameter(CovertedCirc));
        }
        else
        {
            Console.WriteLine("Error");
        }
        Press_Key();
    }
}

static void Bad_Input(ConsoleKeyInfo userInput){

    Console.WriteLine("Bad input please enter one of the following digits.");
    Options_Menu();
    ConsoleKeyInfo newKey = Console.ReadKey();
    userInput = newKey;
}

static void Press_Key(){

    Console.WriteLine("Press any key to return to the menu.");
    Console.ReadKey();
    Console.Clear();
}

static void Is_Square_Input_A_String(string firstValue, string secondValue, AreaCalculator acm){


    if (int.TryParse(firstValue, out int firstResult) && int.TryParse(secondValue, out int secondResult))
    {
        Console.WriteLine("The area is : " + acm.getSquareArea(firstResult, secondResult));
    }
    else
    {
        Console.WriteLine("The area is : " + acm.getSquareArea(firstValue, secondValue));
    }
}

static int Convert_String_To_Int(string convertMe)
{
    if (int.TryParse(convertMe, out int firstResult) && !firstResult.ToString().Contains("-"))
    {
        return firstResult;
    }
    else
    {
        return -1;
    }
}

