using System;
using System.IO;




namespace file_logger
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("program started");
            Console.WriteLine("please type file path");
            //file path input
            string mainpath = Console.ReadLine();



            Console.WriteLine("what are you lookng for");
           //first seach trum 
            string FileType = "*" + Console.ReadLine() + "*";

           //tests if file type is left blank
            if (FileType == "" )
            {
                FileType = "*.*";



            }

            string FileType2 = "*" + Console.ReadLine() + "*";

            //tests if file type is left blank
            if (FileType2 == "")
            {
                FileType2 = "*.*";



            }





            Console.WriteLine("what will you name you text file");
            //text file name 
            string textfilename = Console.ReadLine();
            
            
            
            //counter set 0
            int nuboffiles = 0;
            //gets name of all files with the given information
            string[] filePaths = Directory.GetFiles(mainpath , FileType + FileType2 , SearchOption.AllDirectories);


            //makes a date string for file name 
            string date = DateTime.Now.ToString("yyyy-MM-dd-HH;mm;ss");

            //creates new text file to be written to
            using (StreamWriter writer = new StreamWriter(textfilename+date+".txt", true))


            //changes to string and types out all files names to console and text file
            foreach (var value in filePaths)
            {
                Console.WriteLine(value);
               
                    //nuber file counter value
                nuboffiles++;

                    //writes in text file in /bin/debug in a text file
                    writer.WriteLine(value);

                    

             }
            using (StreamWriter writer = new StreamWriter(textfilename + date + ".txt", true))


                writer.WriteLine("nuber of "+ FileType + " files and " + FileType2 + "  files are: " + nuboffiles);
                Console.WriteLine("Nuber of files = " + nuboffiles);
                Console.ReadLine();
            
           
        }


    }
}

