using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BinaryWriter bw = new BinaryWriter(File.Open("1.dat", FileMode.OpenOrCreate));
                Console.WriteLine("Введите количество слов строке: ");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите слова: ");
                for (int i = 0; i < d; i++)
                {
                    string s2 = Console.ReadLine();
                    bw.Write(s2);
                }
                bw.Close();
                string s3 = "";
                BinaryReader br = new BinaryReader(File.Open("1.dat", FileMode.Open));
                while (br.PeekChar() > -1)
                {
                    s3 = br.ReadString();

                }
                br.Close();
                br = new BinaryReader(File.Open("1.dat", FileMode.Open));
                Console.WriteLine("Слова, начинающиеся на ту же букву, что и последнее слово: ");
                while (br.PeekChar() > -1)
                {
                    string s4 = br.ReadString();
                    if (s4[0] == s3[0])
                    {
                        Console.WriteLine(s4);
                    }
                }
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }
            Console.ReadKey();
        }
    }
}
