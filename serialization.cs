using Microsoft.SqlServer.Server;
using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
//serialization using binary serialization
namespace serialize0
{
    [Serializable]
    class student
    {
        public int id;
        public string name;
        public long phoneno;
        public student(int id, string name,long phoneno)
        {
            this.id = id;
            this.name = name;
            this.phoneno = phoneno;
        }
    }
    class seri
    {
        static void Main(String[] args)
        {
            Console.WriteLine("What do U want to do today: Read or Write");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "read")
                deserialize();
            else
                serialize();



        



         void serialize()
            {
                FileStream f = new FileStream("C:\\Users\\CTEA\\Documents\\c#\\Binary.txt", FileMode.OpenOrCreate);//Where to serialize
                BinaryFormatter f1 = new BinaryFormatter();//Binary serialization
                student s = new student(10, "Girish", 1234567890);//What to serialize
                f1.Serialize(f, s);
                f.Close();
                Console.WriteLine("serialization is done");
            }
            void deserialize()
            {
                
                    FileStream fs = new FileStream("C:\\Users\\CTEA\\Documents\\c#\\vid.txt", FileMode.Open, FileAccess.Read);
                    BinaryFormatter fm = new BinaryFormatter();
                    student s = fm.Deserialize(fs) as student;
                    Console.WriteLine(s.name);
                    Console.WriteLine(s.id);
                    Console.WriteLine(s.phoneno);
                    fs.Close();
                
            }

        }
    }


}