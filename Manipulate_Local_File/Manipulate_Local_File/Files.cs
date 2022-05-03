using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Manipulate_Local_File
{
    public class Files
    {


        public void Filee()
        {
            try
            {
                string writeText = "Hello World!";  // Create a text string
                File.WriteAllText("kashyap.txt", writeText);  // Create a file and write the contents of writeText to it

                string readText = File.ReadAllText("kashyap.txt"); // Read the contents of the file
                Console.WriteLine(readText); // Output the content
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


           
        }

    
        public void filee2()
        {
            string filePath = @"D:\Himanshu\C Sharp\Manipulate_LocalFilein_CSharp\Manipulate_Local_File\Name.txt";
            var lines = File.ReadAllLines(filePath).ToList();    
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            lines.Add("Anurag Thakur");
            File.WriteAllLines(filePath, lines);
         
        }
      
    }
    

}
