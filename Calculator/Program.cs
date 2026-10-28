// Console.Write("Число:");
// string input = Console.ReadLine();

// int number = int.Parse(input);
// Console.Write("Делитель:");
// string divInput = Console.ReadLine();
// int divisor = int.Parse(divInput);

// int res = number / divisor;
// Console.WriteLine(res);

Console.Write("Число:");
string input = Console.ReadLine();
try{
    int number = int.Parse(input);
    Console.WriteLine(number);
    Console.WriteLine(number * number);
}
catch (FormatException ex){
    Console.WriteLine(input);
    Console.WriteLine(ex.Message);
}
catch (OverflowException ex) {
    Console.WriteLine("число слишком большое для int");
    Console.WriteLine(int.MaxValue);
    Console.WriteLine(ex.Message);

}
