using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Datatypes
    {

        // Number Type

        int num = 1; // Strores the numeric variable
        long longnum = 123568L; // Stores the long number format.
        double dub = 5.15D; // Stores in decimal format. Precision up to 15 decimal digits
        float floatnum = 1.0f;  // Stores in the decimal format. Precision up to 7 decimal digits

        bool ishuman = false;   // Stores the data in the boolean form (i.e. true or false).

        char grade = 'A';   // Stores the data in single character. The character must be sorrounded by single quote ''

        string greeting = "Good morning";   // Stores the sequence of characters. The string much be sorrounded by double quote "".
        public static void DataType(Datatypes data) 
        {


            Console.WriteLine(data.num);
            Console.WriteLine(data.longnum);
            Console.WriteLine(data.dub);
            Console.WriteLine(data.floatnum);

            Console.WriteLine(data.ishuman);

            Console.WriteLine(data.grade);

            Console.WriteLine(data.greeting);


        }



    }
    
}
