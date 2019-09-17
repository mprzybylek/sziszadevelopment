using System;
using System.Collections.Generic;
using System.Text;

namespace MethodBasics
{
    class User
    {
        private string _name = "Pablito";
        protected string sex = "undefined";

        public void ShowName()  //public - private - protected - modyfikator dostepu
                                //void - 
        {
            Console.WriteLine(_name);
        }
        private void ShowAge()
        {

        }
        
    }
    
}
