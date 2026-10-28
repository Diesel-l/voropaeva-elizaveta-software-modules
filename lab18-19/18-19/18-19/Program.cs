//char[] alfanit = new char[26];
//for (int i = 0; i < alfanit.Length; i++)
//    alfanit[i] = (char)('A' + i);
//foreach (char letter in alfanit)
//    Console.Write(letter + " ");
//Console.WriteLine();
//Console.WriteLine($"Длина: {alfanit.Length}");
//Console.WriteLine($"Первая: {alfanit[0]}, последняя: {alfanit[25]}");

//char[] Rusalfavit = new char[33];
//int index = 0;
//for (char c = 'А'; c <= 'Я'; c++)
//{
//    Rusalfavit[index++] = c;
//    if (c == 'Е')
//        Rusalfavit[index++] = 'Ё';
//}
//foreach (char letter in Rusalfavit)
//    Console.Write(letter + " ");
//Console.WriteLine();
//Console.WriteLine($"Позиция 6: {Rusalfavit[5]}, позиция 7: {Rusalfavit[6]}");
//Console.WriteLine($"Последняя: {Rusalfavit[32]}");


//int[] num =  new int[5];
//long sum = 0;
//for (int i = 0; i < num.Length; i++)
//{
//    num[i] = i + 1;
//}
//foreach (int znach in num)
//    sum += znach;
//Console.WriteLine($"Сумма: {sum}");


//string[] stroka = { "Polina", "Arina", "", "Karina" };
//List<string> res = new List<string>();
//foreach (string s in stroka)
//    if (s.Length > 0)
//        res.Add(s);
//foreach (string s in res)
//    Console.WriteLine("Отобрано: " + s);


//int[] empty = { };
//int[] one = { 7 };
//foreach (int v in empty) Console.Write("Пустой массив: " +  v);
//Console.WriteLine("(пустой массив, тело не выполнилось)");
//foreach (int v in one) Console.Write("Массив с одним элементом: " + v);

//int[] zero = [-3, 1, 5, 0, 7, 0, 0, 0];
//for (int i = 0; i < zero.Length; i++)
//{
//    if (zero[i] == 0)
//        Console.WriteLine(i + "");
//}


//int[] place = [1, 0, 0, 1, 1, 0, 0, 0];
//for (int i = 0; i < place.Length; i++)
//{
//    if (place[i] == 0)
//        Console.WriteLine((i + 1) + "");
//}


//string[] names = { "Анна", "", "Иван", "", "" };
//int count = 0;

//foreach (string s in names)
//{
//    if (s.Length == 0)
//        count++;
//}

//Console.WriteLine($"Пустых строк: {count}");
//string[] names = { "Анна", "  ", "\t", "Иван", "  " };
//int empty = 0;
//foreach (string s in names)
//{
//    if (s.Trim().Length == 0)
//        empty++;
//}
//Console.WriteLine($"Пустых после Trim: {empty}");