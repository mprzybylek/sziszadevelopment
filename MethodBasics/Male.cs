using System;
using System.Collections.Generic;
using System.Text;

namespace MethodBasics
{
    class Male : User
    {
        public void SetSex()
        {
            sex = "Male";

        }

        public void ShowUserProffesion()
        {
          //  ShowProffession();  //inaccessible level 
        }
    }
}
