string[] array = new string[] { "hello", "world", "visual", "studio", "code", "kva", "it", "work", "q" };
string[] group = Array.FindAll(array, arrayLessFour => arrayLessFour.Length <= 3);
foreach (var arrayLessFour in group)
    Console.WriteLine(arrayLessFour);
Console.WriteLine(" ");