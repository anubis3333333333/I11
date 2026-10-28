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


// DemoFormatException();
// DemoDivideByZero();
// DemoIndexOutOfRange();
// DemoNullReference();


// Console.WriteLine("Тестирование DemoCustomException");
// DemoCustomException(20);
// DemoCustomException(-5);
// static void DemoCustomException(int age){
// Console.WriteLine($"Вызов DemoCustomException с возрастом: {age}");
// try{
// if (age < 0){
// throw new ArgumentException("Возраст не может быть отрицательным.");
// }
// Console.WriteLine($"✔ Возраст {age} успешно принят.");
// }
// catch (ArgumentException ex){
// Console.WriteLine($"✕ Перехвачено исключение: {ex.Message}");
// }
// Console.WriteLine();
// }


// static void DemoFormatException()
// {
// Console.WriteLine("DemoFormatException");
// string[] inputs = { "42", "3.14", "abc", "", " " };
// foreach (string s in inputs)
// {
// try
// {
// int n = int.Parse(s);
// Console.WriteLine($"\"{s}\" -> {n}");
// }
// catch (FormatException)
// {
// Console.WriteLine($"\"{s}\" -> ✕ не число");
// }
// }
// Console.WriteLine();
// }

// static void DemoDivideByZero()
// {
// Console.WriteLine("DemoDivideByZeroException");
// int[] divisors = { 5, 2, 0, -1 };
// foreach (int d in divisors)
// {
// try
// {
// int result = 100 / d;
// Console.WriteLine($"100 / {d} = {result}");
// }
// catch (DivideByZeroException)
// {
// Console.WriteLine($"100 / {d} = ✕ деление на ноль недопустимо");
// }
// }
// Console.WriteLine();
// }

// static void DemoIndexOutOfRange()
// {
// Console.WriteLine("DemoIndexOutOfRangeException");
// int[] arr = { 10, 20, 30 };
// int[] indices = { 0, 1, 2, 3, -1 };
// foreach (int i in indices)
// {
// try{
// Console.WriteLine($"arr[{i}] = {arr[i]}");
// }
// catch (IndexOutOfRangeException){
// Console.WriteLine($"arr[{i}] = ✕ индекс за пределами массива");
// }
// }
// Console.WriteLine();
// }

// static void DemoNullReference()
// {
// Console.WriteLine("DemoNullReferenceException");
// string validString = "Привет";
// string nullString = null;
// try
// {
// Console.WriteLine($"Длина \"{validString}\": {validString.Length}");
// Console.WriteLine($"Длина null: {nullString.Length}");
// }
// catch (NullReferenceException)
// {
// Console.WriteLine("✕ Обращение к null-объекту");
// }
// Console.WriteLine();
// }


