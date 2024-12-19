//double point = Convert.ToDouble(Console.ReadLine());
//int x = 15;
//int y = Convert.ToInt32(Console.ReadLine());
//double point_two = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Привет мир");
//Console.WriteLine("Добро пожаловать в C#");
//Console.WriteLine("Пока мир");
//Console.WriteLine(point);

//Console.WriteLine(" ");

//Console.WriteLine(point + x);
//Console.WriteLine(x * y);
//Console.WriteLine(x - point_two);
//Console.WriteLine(Convert.ToInt32(point));


//int name = 2;
//int a1 = 3;
//int a2 = 4;
//int DoOperaion(int a1, int a2, int b)
//{
//    switch (b)
//    {
//        case 1: return a1 + a2;
//        case 2: return a1 - a2;
//        case 3: return a1 * a2;
//        default: return 0;
//    }
//}

//switch (name)
//{
//    case 1:
//        Console.WriteLine("Вы - Боб");
//        break;
//    case 2:
//        Console.WriteLine("Вы - Alex");
//        goto case 3;
//    case 3:
//        Console.WriteLine("Кейс 3");
//        break;
//    default:
//        Console.WriteLine("Нет имени");
//        break;
//}

//using System.Linq.Expressions;

//string? input = Console.ReadLine();

//bool result = int.TryParse(input, out var value);
//if (result == true)
//{
//    Console.WriteLine("Запарсил");
//}
//else
//{
//    Console.WriteLine("Не вышло");
//}

// Пользователь вводит минимум 2 числа. Выбирает какое действие с числами +-*/. После операции пользователь заноо выбирает. Как числа, так и операцию

//int x = 3;
//int y = 2;

//int z = x < y ? (x+y) : (x-y);


//try
//{ 
//    int x = 5;
//    int y = x / 0;
//    Console.WriteLine(y);
//}
//catch(Exception er)
//{
//    string message = er.Message;
//    Console.WriteLine(message);
//}

//var rand = new Random();
//byte[] bytes = new byte[5];
//rand.NextBytes(bytes);
//Console.WriteLine("Числа");

//foreach (byte b in bytes)
//{
//    Console.WriteLine(b);
//}

//double r = 50;
//double area = Math.PI * Math.Pow(r, 2);
//Console.WriteLine(area);
//static void Main()
//{

//}

//class Person
//{
//    public string name = "Flex";
//    public int age;
//    public void Print()
//    {
//        Console.WriteLine($"Имя = {name} \nВозраст = {age}");
//    }
//}



//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine(i);
//}

//List<int> zetka = new() { 0, 1, 3, 4, 1 };

//foreach (var el in zetka)
//{
//    Console.WriteLine($"{el} ");
//}

//await PrintAs();
//Console.WriteLine("123");

//void Print()
//{
//    Thread.Sleep(3000);
//    Console.WriteLine("Передачка");
//}

//async Task PrintAs()
//{
//    Console.WriteLine("Начало");
//    await Task.Run(() => Print());
//    Console.WriteLine("Конец");
//}


//Console.WriteLine("На сколько месяцев?");
//double month = double.Parse(Console.ReadLine());

//Console.WriteLine("\nСколько денег?");
//double money = double.Parse(Console.ReadLine());

//double procent = 3.1;

//for (int i = 0; i < month; i++)
//{
//    money = money + (money * (procent / 100));
//    Console.WriteLine(Math.Round(money));
//}

//string[] a = { "Arling", "Vera", "Sory", "Mona" };

//var empl = new string[3];

//Array.Copy(a, 1, empl, 0, 3);

//foreach  (string s in empl)
//{
//    Console.WriteLine(s);
//}


//int[] arr = { 800, 100, 200, 55, 12, 54 };

//int temp = 0;

//for (int write = 0; write < arr.Length; write++)
//{
//    for (int sort = 0; sort < arr.Length - 1; sort++)
//    {
//        if (arr[sort] > arr[sort + 1])
//        {
//            temp = arr[sort + 1];
//            arr[sort + 1] = arr[sort];
//            arr[sort] = temp;
//        }
//    }
//}

//foreach (int a in arr)
//{
//    Console.WriteLine(a);
//}

//void Say() => Console.WriteLine("Hi");

//Say();

//int[,] a = { { 1, 4 }, { 2, 3 } };

//int raws = a.GetUpperBound(0) + 1;
//int columns = a.Length / raws;

//for (int i = 0; i < raws; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"{a[i, j]}");
//    }
//    Console.WriteLine();
//}

//int[][] a = new int[3][];
//a[0] = new int[2] { 1, 2 };
//a[1] = new int[3] { 3, 4 };
//a[2] = new int[4] { 5, 6 };

//List<string> problem = new List<string>() { "One", "Two", "Three"};

//var n = new List<string>();
//List<string> error = { "One" };

//string[] people = { "Dar", "Mar", "Ar", "Iv", "Den" };

//var select = from p in people
//             where p.ToUpper().StartsWith("D")
//             orderby p
//             select p;

//foreach (var person in people)
//{
//    if (person.ToUpper().StartsWith("D"))
//    {
//        select.Add(person);
//    }
//}

//select.Sort();

//foreach (var person in select)
//{
//    Console.WriteLine(person);
//}



//string m = "help";
//string r = "hegp";
//string w = m + " " + r;
//string q = string.Concat(w, "11");

//Console.WriteLine(q);

//string m = "help w";
//string m1 = "help me";

//char fchar = m[1];
//Console.WriteLine(m.Length);

//for (int i = 0; i < m.Length; i++)
//{
//    Console.WriteLine(m[i]);
//}

//foreach ( var item in m)
//{
//    Console.WriteLine(item);
//}

//string user = "mm";
//string stringtime = DateTime.Today.ToShortDateString();

//string vr = $"Hello {user}. Today is {stringtime}." ;
//Console.WriteLine(vr);

//vr = $"{vr} kill me";
//Console.WriteLine(vr);

//DriveInfo[] drives = DriveInfo.GetDrives();

//foreach (DriveInfo drive in drives)
//{
//    Console.WriteLine($"Название: {drive.Name}");
//    Console.WriteLine($"Тип: {drive.DriveType}");

//    if (drive.IsReady)
//    {
//        Console.WriteLine($"Объем диска: {drive.TotalSize / Math.Pow(1024, 3)} Гб");
//        Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace / Math.Pow(1024, 3)} Гб");
//    }
//    Console.WriteLine();
//}

//string dirName = "C:\\";
//// если папка существует
//if (Directory.Exists(dirName))
//{
//    Console.WriteLine("Подкаталоги:");
//    string[] dirs = Directory.GetDirectories(dirName);
//    foreach (string s in dirs)
//    {
//        Console.WriteLine(s);
//    }
//    Console.WriteLine();
//    Console.WriteLine("Файлы:");
//    string[] files = Directory.GetFiles(dirName);
//    foreach (string s in files)
//    {
//        Console.WriteLine(s);
//    }
//}


//using System.IO;

//DriveInfo[] drives = DriveInfo.GetDrives();

//foreach (DriveInfo drive in drives)
//{
//    Console.WriteLine($"Название: {drive.Name}");
//    Console.WriteLine($"Тип: {drive.DriveType}");

//    if (drive.IsReady)
//    {
//        Console.WriteLine($"Объем диска: {drive.TotalSize / Math.Pow(1024, 3)} Гб");
//        Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace / Math.Pow(1024, 3)} Гб");
//    }
//    Console.WriteLine();
//}

//using System.Data;

//Console.WriteLine("Что сделать?\nСоздать Удалить Переместить");
//string work = "e";
//string choose = "0";

//switch (work)
//{
//    case "s":
//        switch (choose)
//        {
//            case "Создать":
//                Console.WriteLine("Введите путь создания новой папки");
//                string path = @Console.ReadLine();

//                DirectoryInfo dirInfo = new DirectoryInfo(path);
//                dirInfo.Create();

//                Console.WriteLine("Готовао");
//                break;
//            case "Удалить":
//                Console.WriteLine("Введите папку, которую нужно удалить");
//                string del = @Console.ReadLine();

//                if (Directory.Exists(del))
//                {
//                    Directory.Delete(del, true);
//                    Console.WriteLine("Папка удалена");
//                }
//                else
//                {
//                    Console.WriteLine("Папки не существует");
//                }

//                Console.WriteLine("Готовао");
//                break;
//            case "Переместить":
//                Console.WriteLine("Введите старый путь до папки");
//                string oldpath = @Console.ReadLine();

//                Console.WriteLine("Введите куда перенести");
//                string newpath = @Console.ReadLine();

//                DirectoryInfo dir = new DirectoryInfo(oldpath);
//                dir.MoveTo(newpath);

//                Console.WriteLine("Готовао");
//                break;
//            default:
//                Console.WriteLine("Нет такого");
//                break;

//        }
//        goto case "e";

//    case "e":
//        choose = Console.ReadLine();
//        goto case "s";

//}


//string path1 = @"C:\Users\eugene\Documents\content.txt";  // для Windows
//string path4 = "MyDir\\content.txt";  // для Windows

////пути к файлам

//string path = @"D:\terr\123.txt";
//FileInfo fileInfo = new FileInfo(path);

//Console.WriteLine($"Имя файла: {fileInfo.Name}");
//Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
//Console.WriteLine($"Размер: {fileInfo.Length}");

//string path = @"D:\terr\123.txt";
//string newPath = @"D:\terr\456.txt";
//FileInfo fileInf = new FileInfo(path);

//File.Move(path, newPath);


//string path = @"D:\terr\456.txt";

//string originalText = "Hello Grand.com";
//// запись строки
//await File.WriteAllTextAsync(path, originalText);
//// дозапись в конец файла
//await File.AppendAllTextAsync(path, "\nHello work");

//// чтение файла
//string fileText = await File.ReadAllTextAsync(path);
//Console.WriteLine(fileText);

//using static System.Net.Mime.MediaTypeNames;

//string path = "1234.txt";
//string text = "1gefwdd";
//// асинхронное чтение

//using (StreamWriter writer = new StreamWriter(path, false))
//{
//    await writer.WriteLineAsync(text);
//}
//using (StreamReader writer = new StreamReader(path))
//{
//    string text_n = await writer.ReadToEndAsync();
//    Console.WriteLine(text_n);
//    //await writer.WriteLineAsync(text);
//}


//string path = "person.dat";

//// создаем объект BinaryWriter
//using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
//{
//    // записываем в файл строку
//    writer.Write("Tom");
//    // записываем в файл число int
//    writer.Write(37);
//    Console.WriteLine("File has been written");
//}

//using (BinaryReader reader = new BinaryReader(File.Open("person.dat", FileMode.Open)))
//{
//    // считываем из файла строку
//    string name = reader.ReadString();
//    // считываем из файла число 
//    int age = reader.ReadInt32();
//    Console.WriteLine($"Name: {name}  Age: {age}");
//}


using TestLib;

Class1 tom = new("Tom");
tom.Print();