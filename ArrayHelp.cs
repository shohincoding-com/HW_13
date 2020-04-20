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
    }
}