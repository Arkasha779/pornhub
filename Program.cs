using System;
using System.IO;

namespace pornhub
{
    class Program
    {
        static void Main(string[] args)
        {
            var pic = File.ReadAllBytes("1.jpg");
            var text = Convert.ToBase64String(pic);

            File.WriteAllText("1.txt", text);
            text = File.ReadAllText("1.txt");
            pic = Convert.FromBase64String(text);
        }
    }
}
