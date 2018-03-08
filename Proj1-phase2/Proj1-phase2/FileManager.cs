
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;


namespace Proj1_phase2
{
    public class FileManager
    {

        FileStream stream;
        JavaScriptSerializer jsSerializer = new JavaScriptSerializer();


        public bool LoadJsonFile(string str, out List<Student> students)
        {
            stream = new FileStream(str, FileMode.Open);
            students = new List<Student>();
            try
            {
                using (StreamReader r = new StreamReader(stream))
                {
                    str = r.ReadToEnd();
                    students = jsSerializer.Deserialize<List<Student>>(str);
                }

                    return (students.Count != 0);
                
                
            }
            catch (IOException e)
            {
                Console.WriteLine("Received an IOException");
                return false;
            }

        }

        public bool SaveJsonFile(string str, List<Student> students)
        {
            stream = new FileStream(str, FileMode.CreateNew);
            try
            {
                using (StreamWriter w = new StreamWriter(stream))
                {
                    string data = jsSerializer.Serialize(students);

                    w.Write(data);
                    
                }

                return (File.Exists(str));
            }
            catch (IOException e)
            {
                Console.WriteLine("Received an IOException");
                return false;
            }

        }





        static void Main(string[] args)
        {
        }


    }
}
	
