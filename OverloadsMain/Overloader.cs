using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadsMain
{
    internal class Overloader
    {
        public void Run()
        {
            PrintWelcomeMessage("Velkommen!", "Du ser godt ut i dag!");
            PrintWelcomeMessage();
            
        }
    
       private void PrintWelcomeMessage(string text = "Du er snill")
        {
            Console.WriteLine(text);
        } 
        private void PrintWelcomeMessage(string text, string text1)
        {
            Console.WriteLine($"Welcome message:{text} {text1}");
            
        } 
        










    
    }
}
