using System;
using System.Collections.Generic;
using HW_13_Array;

namespace HW_13
{
    class UserCommand
    {
    public string Cmd { get; set; }

    
    }
    class Program
    {
        static void Main(string[] args)
        {
            int [] IntMass = new int [] {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000};

            List<UserCommand> listOfCommmands = new List<UserCommand>()
            {
                new UserCommand() { Cmd ="1. Удалит последний элемент"},
                new UserCommand() { Cmd ="2. Добавить элемент с конца"},
                new UserCommand() { Cmd ="3. Удалит первий элемент"},
                new UserCommand() { Cmd ="4. Добавить элемент в начало"},
                new UserCommand() { Cmd ="5. Возвращат новый массив"},
            };

            for(int j = 0; j < listOfCommmands.Count; j++)
            {
                Console.WriteLine(listOfCommmands[j].Cmd );
            }

            int UserCmd = int.Parse(Console.ReadLine());
            
            if(UserCmd == 1)
            {
                Console.Write("Удалено слейдущий элемент: ");
                int NewElem = ArrayHelp<int>.Pop(ref IntMass);
                Console.WriteLine(NewElem);
                for(int j = 0; j < IntMass.Length; j++)
                Console.Write(IntMass[j] + " ");
            }
            else if(UserCmd == 2)
            {
                Console.Write("Новый елемент для добавления: ");
                int NewNum = int.Parse(Console.ReadLine());
                int SizeMass = ArrayHelp<int>.Push(ref IntMass, NewNum);
                Console.WriteLine($"Размер нового массива {SizeMass}");
                Console.Write("Созданный новыий массив: ");
                for(int j = 0; j < IntMass.Length; j++)
                Console.Write($"{IntMass[j]} ");
            }
            else if(UserCmd == 3)
            {
                int NewElem = ArrayHelp<int>.Shift(ref IntMass);
                Console.WriteLine(NewElem);
                for(int j = 0; j < IntMass.Length; j++)
                Console.Write($"{IntMass[j]} ");
            }
            else if(UserCmd == 4)
            {
                Console.Write("Новый елемент для добавления: ");
                int NewNum = int.Parse(Console.ReadLine());
                int SizeMass = ArrayHelp<int>.Unshift(ref IntMass, NewNum);
                Console.WriteLine(SizeMass);
            }
            else if(UserCmd == 5)
            {
                System.Console.WriteLine("Выбирите Индекса ");
                int[]Arr = ArrayHelp<int>.Slice(IntMass);
            }
                
            
        }
    }
}
