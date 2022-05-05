using System;
//using System means that we can use classes from the System 
/*
*
int myNum = 5;               // Integer (whole number)
double myDoubleNum = 5.99D;  // Floating point number
char myLetter = 'D';         // Character
bool myBool = true;          // Boolean
string myText = "Hello";     // String

*/

/*              \n New Line
                \t Tab	
                \b Back space
*/


//namespace is used to organize your code, and it is a container for classes and other namespaces.
namespace MainNameSpace.Part1
{

    //class is a container for data and methods
    public class Basic1
    {
        public int h = 5;

        public string concateName(string fname, string middlename)
        {
            return fname + middlename;
        }
        public string concateName(string fname, int Lastname)
        {
            return fname;
        }

        public void concateName(string fname, string middlename, string lastName)
        {

            Console.WriteLine(fname + middlename + lastName);
        }
       
    public void arr()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
                Console.WriteLine("\n");
            }
        }
     public void test1()
        {
            float num1 = 0.0f;
            double num2 = 0.0d;
            decimal num3 = 0.0m;
            num1 = 1/5.5f;
            num2 = 1/5.5d;
            num3 = 1/5.5m;
            Console.WriteLine("float is {0}",num1);
            Console.WriteLine("double is {0}",num2);
            Console.WriteLine("decimal is {0}", num3);
        }
         
        


    }
}
