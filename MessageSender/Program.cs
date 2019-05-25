using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSender
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0) { return; }
            string message = args[0];
            using (var stream = new NamedPipeClientStream("SEServer"))
            {
                stream.Connect(10000);
                using (var writer = new BinaryWriter(stream, Encoding.UTF8))
                {
                    writer.Write(message);
                }
            }
        }
    }
}
