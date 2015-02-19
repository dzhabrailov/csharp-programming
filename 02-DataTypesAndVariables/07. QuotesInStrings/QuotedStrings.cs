using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInStrings
{
    class QuotedStrings
    {
        /// <summary> Problem 7
        /// Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
        /// Do the above in two different ways - with and without using quoted strings.
        /// Print the variables to ensure that their value was correctly defined.
        /// </summary>
        static void Main()
        {
            string quoted = "The \"use\" of quotations causes difficulties";
            string notQuoted = @"The ""use"" of quotations causes difficulties";

            Console.WriteLine("Quoted string : {0}", quoted);
            Console.WriteLine("Not quoted string : {0}", notQuoted);
        }
    }
}
