// Напишите программу, которая выводит 
        //третью цифру заданного числа или сообщает, что третьей цифры нет.

        
        Console.WriteLine("Введите число");
        Chislo3(Console.ReadLine());

        void Chislo3(string currentNumber)
        {
       
            if (currentNumber.Length < 3)
            {
                Console.WriteLine("Третьей цифры нет");
            }
            else
            {
                Console.WriteLine(currentNumber[2]);
            }

        }



        //Задача 15: Напишите программу, которая принимает на вход цифру, 
        //обозначающую день недели, и проверяет, является ли этот день выходным.

        Console.WriteLine("Введите число:");
        int Day = Convert.ToInt32(Console.ReadLine());
       
        DayOff(Day);
      
        void DayOff(int currentNumber)
        {
            if (currentNumber == 1) Console.WriteLine("Не выходной");

            else if (currentNumber == 2)Console.WriteLine("Не выходной");

            else if (currentNumber == 3)Console.WriteLine("Не выходной");

            else if (currentNumber == 4)Console.WriteLine("Не выходной");

            else if (currentNumber == 5) Console.WriteLine("Не выходной");

            else if (currentNumber == 6) Console.WriteLine("Суббота,выходной");

            else  if (currentNumber == 7) Console.WriteLine("Воскресенье, выходной");

            else Console.WriteLine("Такого дня недели нет");
            
        }
        