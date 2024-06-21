using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering5
{
    // Lag klasser for mygg med dens unike egenskaper (kan fly, suger blod, gir følgende plage: kløe) 
    // alt er camilla sin feil - Camilla
    internal class mygg:bug

    {
      
        public int legs => 6; //similar to default values 
        public bool isPoisonous => false;
        public bool isAnnoying => true;
        public string Name { get; set; }

        public mygg(string name)
        {
            name = name;
        }
    public override void Bite()
    {
        int damageMosquito = 12; 

     Console.WriteLine($"Deals {damageMosquito} damage!");
    }

    public override void Movement() //override changes the function in the original method
    {

    }
    }
}
