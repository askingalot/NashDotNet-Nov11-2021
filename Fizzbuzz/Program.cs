using static System.Console;
/*
 * numbers 1 to 100
 * when we get a number divisable by 3 we say Fizz
 * when we get a number divisable by 5 we say Buzz
 * when we get a number divisable by 15 we say FizzBuzz
 * otherise print the number
 */

var fizzFuncArray = new[] {
    (int n) => "Fizz",
    n => n.ToString(),
    n => n.ToString()
};

var buzzFuncArray = new[] {
    (int n) => "Buzz",
    n => n.ToString(),
    n => n.ToString(),
    n => n.ToString(),
    n => n.ToString()
};

var fizzArray = new[] { "Fizz", "", "" };
var buzzArray = new[] { "Buzz", "", "", "", "" };

for (var num = 1; num <= 100; num++)
{
    var fizz = fizzArray[num % 3];
    var buzz = buzzArray[num % 5];
    var fizzbuzz = $"{num.ToString().PadRight(8)}{fizz}{buzz}";

    WriteLine(fizzbuzz);
    WriteLine(fizzbuzz.Substring(fizzbuzz.Length - 8).Trim());

    if (num % 15 == 0)
    {
        Write("FizzBuzz");
    }
    else if (num % 3 == 0)
    {
        Write("Fizz");
    }
    else if (num % 5 == 0)
    {
        Write("Buzz");
    }
    else
    {
        Write(num);
    }

    WriteLine();

    var output = num switch
    {
        int n when n % 15 == 0 => "FizzBuzz",
        int n when n % 3 == 0 => "Fizz",
        int n when n % 5 == 0 => "Buzz",
        int n => n.ToString()
    };

    WriteLine(output);

    WriteLine("-------");
}


