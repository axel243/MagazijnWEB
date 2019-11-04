using System;

namespace WebTest.Models
{
    public class HelloWorld
    {
        public String[] differentHello = new string[] {"Bonjour", "Ola", "Hallo" };

        public string[] DifferentHello
        {
            get => differentHello;
            set => differentHello = value;
        }

        public HelloWorld()
        {
            differentHello = differentHello;
        }
        
    }
}