﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp_1._2.Exceptions
{
    namespace PersException
    {
        class UserExistsException : AuthentificationException
        {
            public UserExistsException(String message, String log)
                : base(message, log)
            { }

            public void displayError()
            {
                Console.WriteLine(this.Message);
            }

        }
    }
}
