using System;
namespace HW_13_Array
{
    public static class ArrayHelp<S>
    {
        public static S Pop(ref S[] Mass)
        {
            S FinalMass;
            FinalMass = Mass[Mass.Length - 1];
            S[] NewMass = new S[Mass.Length -1];
            for(int j = 0; j < Mass.Length - 1; j++)
            NewMass[j] = Mass[j];
            Mass = NewMass;
            return FinalMass;
        }
        public static int Push(ref S[] Mass, S NewElem)
        {
            S[] NewMass = new S[Mass.Length + 1];
            for (int j = 0; j < Mass.Length; j++ )
            NewMass[j] = Mass[j]; 
            NewMass[Mass.Length] = NewElem;
            Mass = NewMass;
            return Mass.Length; 
        }

        public static S Shift(ref S[] Mass)
        {
            S FinalMass;
            FinalMass = Mass[0];
            S[] NewMass = new S[Mass.Length-1];
            for ( int j = 1; j < Mass.Length; j++ )
            NewMass[j - 1] = Mass[j]; 
            Mass = NewMass;
            return FinalMass;
        }

        public static int Unshift(ref S[] Mass, S NewElem)
        {
            S[] NewMass = new S [Mass.Length + 1];
            NewMass[0] = NewElem;
            for (int j = 1; j < Mass.Length + 1; j++ )
            NewMass[j] = Mass[j - 1]; 
            NewMass [Mass.Length] = NewElem;
            return Mass.Length;
            
        }

        public static S[] Slice(S[] Mass, int beginIndex = 0, int endIndex = 0)
        {   
            Console.WriteLine("1. beginIndex\n2. endIndex");
            string UsCmd = Console.ReadLine();

            if (UsCmd == "1")
            {
                Console.WriteLine("Введите значение beginIndex ");
                int l = int.Parse(Console.ReadLine());
                if(beginIndex>=0 && beginIndex <= Mass.Length)
                {
                    
                    S FinalMass;
                    
                    FinalMass = Mass[Mass.Length-l];
                    
                    for ( int j = l; j < Mass.Length; j++ )
                    Console.Write($"{Mass[j]} ");
                    
                }
                return Mass ;
            }
            else if (UsCmd == "2")
            {
                Console.WriteLine("Введите значение EndIndex ");
                int l = int.Parse(Console.ReadLine());
                if(endIndex>=0 && endIndex <= Mass.Length)
                {
                    
                    S FinalMass;
                    FinalMass = Mass[Mass.Length - l];
                    for ( int j = 0; j < l; j++ )
                    Console.Write($"{Mass[j]} ");

                }
                return Mass ;
            }
            else{
                Console.WriteLine("Error!");
            }
            return Mass;


           
        }
    }
}