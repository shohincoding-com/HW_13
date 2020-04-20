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

            List<UserCommand> listOfUsers = new List<UserCommand>()
            {
                new UserCommand() { Cmd ="1. Удалит последний элемент"},
                new UserCommand() { Cmd ="1. Добавить элемент с конца"},
                new UserCommand() { Cmd ="1. Удалит первий элемент"},
                new UserCommand() { Cmd ="1. Добавить элемент в начало"},
                new UserCommand() { Cmd ="1. Возвращат новый массив"},
            };

            for(int i = 0; i < listOfUsers.Count; i++)
            {
                Console.WriteLine(listOfUsers[i].Cmd );
            }

            int UserCmd = int.Parse(Console.ReadLine());
            
            if(UserCmd == 1)
            {
                Console.Write("Удалено слейдущий элемент: ");
                int NewElem = ArrayHelp<int>.Pop(ref IntMass);
                Console.WriteLine(NewElem);
                for(int i = 0; i < IntMass.Length; i++)
                Console.Write(IntMass[i] + " ");
                   
            }
                
            
        }
    }
}
