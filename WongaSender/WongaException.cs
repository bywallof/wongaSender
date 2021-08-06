using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WongaSender
{
    public class WongaException : Exception
    {
        /// <summary>Class <c>WongaException</c> for sending a messaging in JSON-format to the Wonga Application
        /// </summary>
        ///
        public WongaException(String errorMessage) : base(errorMessage) 
        {
            
        }

    }
}
