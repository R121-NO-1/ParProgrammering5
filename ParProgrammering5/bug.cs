using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering5
{

    // Lag en baseklasse som heter “bug” og la de andre insektstypene arve hovedegenskapene til insekter fra denne (kan bite, har bein, kan bevege seg f.eks:) ,)

    //bite is "abstract" abstract can change property value. abstract can be defined other places too. <-- easier
    //virtual is the similar to abstract, can write a little bit of the function here and another place.
    internal abstract class bug
    {
        public int HPBar = 100; 

        public string name { get; set; }
        public int legs { get; set; }

        public bool isPoisonous { get; set; }
        public bool isAnnoying { get; set; }

        public abstract void Bite();


        public abstract void Movement();



    }
}
