using System;
using System.Collections.Generic;
using System.Text;

namespace MethodBasics
{
    class User  // class is internal by default 
    {
        private string _name = "Pablito";  // bardziej restrykcyjne, widocznosc w ramach tej klasy
        protected string sex = "undefined";
        string ShowProffesion()
        {
            return "ProffesionalRider";
        }

        public void ShowName()  //public - private - protected - modyfikator dostepu
                                //void - 
        {
            Console.WriteLine(_name);
        }
        private void ShowAge()
        {

        }
        //internal vs internal protected (class or method)
        //
        internal void ShowAddress()
        {

        }


    } 

}
