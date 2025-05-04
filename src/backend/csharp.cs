Console.WriteLine("Console bassed calculator\n");
Console.WriteLine("========================");

bool continueCalculating = true;

while (continueCalculating)
{
  Console.WriteLine("Enter your first number: ");
  string? firstInput = Console.ReadLine();
  if (firstInput == null)
  {
    Console.WriteLine("First input cannot be null.");
    return;
  }
  double number1 = double.Parse(firstInput);

  Console.WriteLine("Enter the second number: ");
  string? secondInput = Console.ReadLine();
  if (secondInput == null)
  {
    Console.WriteLine("Second input cannot be null.");
    return;
  }
  double number2 = double.Parse(secondInput);

  Console.WriteLine("Choose an operation (multiply, divide, subtract, add, exponent, modulo) ");
  string? operation = Console.ReadLine().ToLower();

  switch (operation)
  {
    case "multiply":
      Console.WriteLine($"Result: {Math.Round(number1 * number2, 2)}");
      break;
    case "divide":
      if (number2 != 0)
        Console.WriteLine($"Result: {Math.Round(number1 / number2, 2)}");
      else
        Console.WriteLine("Error: Division by zero is not allowed.");
      break;
    case "subtract":
      Console.WriteLine($"Result: {Math.Round(number1 - number2, 2)}");
      break;
    case "add":
      Console.WriteLine($"Result: {Math.Round(number1 + number2, 2)}");
      break;
    case "exponent":
      Console.WriteLine($"Result: {Math.Round(Math.Pow(number1, number2), 2)}");
      break;
    case "modulo":
      if (number2 != 0)
      {
        Console.WriteLine($"Result: {number1 % number2}");
      }
      else
      {
        Console.WriteLine("Error: Modulo by zero is not allowed.");
      }
      break;
    default:
      Console.WriteLine("Error: Unsupported operator. Please use 'multiply', 'divide', 'subtract', or 'add'.");
      break;
  }
  Console.WriteLine("Would you like to perform another calculation? (yes to continue, no to exit): ");
  string? response = Console.ReadLine()?.Trim().ToLower();

  if (response != "yes")
  {
    Console.WriteLine("Thank you for using the calculator. Goodbye!");
    break;
  }
}