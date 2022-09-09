// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");

while(true)
{
    string input = Console.ReadLine(); 
    if(string.IsNullOrWhiteSpace(input)||!input.Equals("exit"))

      if(string.IsNullOrWhiteSpace(input)||input.Length<3)
      {
         Console.WriteLine(" -> нет третьей цифры");
      }
      else 
      {
       Console.WriteLine($"Третья цифра числа {input} -> {input[2]}"); 
      }   

    else

       break;
}
