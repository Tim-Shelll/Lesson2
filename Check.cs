using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    class Check
    {
        public static string name = "";
        public static string Write()
        {
            string result = "";
            if (System.IO.File.Exists(name))
            {
                StreamReader read = new StreamReader((new FileStream(Check.name, FileMode.Open, FileAccess.Read)));
                string[] text = File.ReadAllLines(Check.name);
                for (int i = 0; i < text.Length; i++)
                    result += text[i] + "\r\n";
                read.Close();
            }
            return result;
        }

        public static void Read(string put, string name)
        {
            if (System.IO.File.Exists(name))
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(name, true);
                writer.WriteLine(put);
                writer.Close();
                Check.name = name;
            }
            else
            {
                if (name != "" && name.Substring(1, 2).Equals(":\\"))
                {
                    FileInfo fi1 = new FileInfo(name);
                    StreamWriter writer = fi1.CreateText();
                    writer.WriteLine(put);
                    writer.Close();
                    Check.name = name;
                }
            }
        }
    }
}
