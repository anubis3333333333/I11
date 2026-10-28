// Console.Write("Число:");
// string input = Console.ReadLine();

// int number = int.Parse(input);
// Console.Write("Делитель:");
// string divInput = Console.ReadLine();
// int divisor = int.Parse(divInput);

// int res = number / divisor;
// Console.WriteLine(res);

// Console.Write("Число:");
// string input = Console.ReadLine();
// try{
//     int number = int.Parse(input);
//     Console.WriteLine(number);
//     Console.WriteLine(number * number);
// }
// catch (FormatException ex){
//     Console.WriteLine(input);
//     Console.WriteLine(ex.Message);
// }
// catch (OverflowException ex) {
//     Console.WriteLine("число слишком большое для int");
//     Console.WriteLine(int.MaxValue);
//     Console.WriteLine(ex.Message);

// }

// Console.WriteLine("Тестирование метода SafeParseInt");
// int result1 = SafeParseInt("42", 10);
// Console.WriteLine($"Ввод: \"42\" -> Результат: {result1}");

// int result2 = SafeParseInt("abc", 10);
// Console.WriteLine($"Ввод: \"abc\" -> Результат: {result2} (использовано значение по умолчанию)");

// int result3 = SafeParseInt("99999999999", 10);
// Console.WriteLine($"Ввод: \"99999999999\" -> Результат: {result3} (использовано значение по умолчанию)");



// static int SafeParseInt(string input, int defaultValue){
// try{
//     return int.Parse(input);
// }
// catch (FormatException){
   
//     return defaultValue;
// }
// catch (OverflowException){
   
//     return defaultValue;
// }


// }


