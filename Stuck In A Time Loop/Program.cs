using System;

namespace Stuck_In_A_Time_Loop{
    class Program{
        static void Main(string[] args){
            int runTimes = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < runTimes; i++){
                if (i == 0){
                    Console.WriteLine(i+1 + " Abracadabra");
                }
                else{
                    Console.WriteLine(i+1 + " Abracadabra");
                }  
            }
        }
    }
}
