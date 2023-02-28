

public class Program
{
    public static void Main()
    {

        StringManipulation();//function call // this can be called by it's class name,Program.StringManipulation()

        ShowFullName();  //function call   // but no need to write class name, bcz it's in same code

        CalculateLengthOfString();

        CalculateVowels();


    }

    //stringManipulationOfAnything  camelCase
    //StringManipulationOfAnything  PascalCase

    private static void StringManipulation()
    {

        Console.WriteLine("Enter any string");
        var str = Console.ReadLine();         

        int spaceCounter = 0;
        int consonantCounter = 0;

        foreach (char ch in str)
        {
            if (ch == ' ')
            {
                spaceCounter++;
            }

            if (!(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == ' ' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U'))
            {
                consonantCounter++;
            }
        }

        Console.WriteLine("Number of spaces = " + spaceCounter);
        Console.WriteLine("Number of words = " + (spaceCounter + 1));
        Console.WriteLine("Number of consonants = " + consonantCounter);

        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    }



    private static void ShowFullName()
    {
        // Show the full Name //

        string fName, mName, lName, fullName;
        Console.WriteLine("Enter your First Name ");
        fName = Console.ReadLine();

        Console.WriteLine("Enter your Middle Name ");
        mName = Console.ReadLine();

        Console.WriteLine("Enter your Last Name ");
        lName = Console.ReadLine();

        fullName = fName + " " + mName + " " + lName;
        Console.WriteLine(fullName);

        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    }


    private static void CalculateLengthOfString()
    {
        //Calculate lenght of the string//

        Console.WriteLine("Enter any string :");
        var str = Console.ReadLine();

        int counter = 0;

        foreach (var item in str)
        {
            counter++;
        }

        Console.WriteLine("length of character is = " + counter);

        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    }


    private static void CalculateVowels()
    {
        //caluculate the vowels from the string//

        Console.WriteLine("Please Enter any string : ");
        var str = Console.ReadLine();

        int vowelsCounter = 0;

        foreach (var item in str)
        {
            if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' ||
                item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
            {
                vowelsCounter++;
            }

        }
        Console.WriteLine("total number of vowels are : " + vowelsCounter);
    }
}
