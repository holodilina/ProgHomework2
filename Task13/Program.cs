// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");

while(true)
{
    string input = Console.ReadLine();
    if(!input.Equals("exit"))
       Console.WriteLine("Третья цифра числа {0} -> {1}", input, input[2]);    

    else

       break;
}
