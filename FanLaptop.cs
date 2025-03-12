using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mod4_103022330036
{
    internal class FanLaptop
    {
        public enum FanState { Quiet, Balanced, Performance, Turbo };
        private FanState currentState;
        public FanLaptop()
        {
            currentState = FanState.Quiet;
        }
        public void Turbo()
        {
            currentState == FanState.Turbo)
            {
                currentState = FanState.Turbo;
                Console.WriteLine("Fan Quiet berubah menjadi Turbo");
            }
        }
        public void Quite()
        {
            if (currentState == FanState.Quiet)
            {
                currentState = FanState.Quiet;
                Console.WriteLine("Fan Quiet berubah menjadi Quite");
            }
        }
        public void Balanced()
        {
            if (currentState == FanState.Balanced)
            {
                currentState = FanState.Balanced;
                Console.WriteLine("Fan Quiet berubah menjadi Balanced");
            }
        }
        public void Performance()
        {
            if (currentState == FanState.Performance)
            {
                currentState = FanState.Performance;
                Console.WriteLine("Fan Quiet berubah menjadi Performance");
            }

             public void ShowState()
        {
            Console.WriteLine($"Status fan saat ini: {currentState}");
        }
    
    }

}
       
