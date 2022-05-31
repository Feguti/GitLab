var operation = args[0];
var n1 = Convert.ToDouble(args[1]);
var n2 = Convert.ToDouble(args[2]);

if (operation == "Sum")
{
    Console.WriteLine("\nResult:\n");
    Console.WriteLine(n1 + n2);
}

if (operation == "Subtract")
{
    Console.WriteLine("\nResult:\n");
    Console.WriteLine(n1 - n2);
}

if (operation == "Multiply")
{
    Console.WriteLine("\nResult:\n");
    Console.WriteLine(n1 * n2);
}

if (operation == "Divide")
{
    Console.WriteLine("\nResult:\n");
    Console.WriteLine(n1 / n2);
}



