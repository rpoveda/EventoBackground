using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;

namespace EventoBackground
{
    public static class MyThread
    {
        private static AutoResetEvent objAutoResetEvent;
        private static string path;
        public static void GravaArquivo()
        {
            objAutoResetEvent = new AutoResetEvent(true);
            ThreadPool.QueueUserWorkItem(Executa);
        }
        private static void Executa(object state)
        {
            path = @"c:\temp\";
            var file = path + DateTime.Now.ToString("ddMMyyyHHmmss") + ".txt";
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine("Ola mundo");
                writer.WriteLine("Escrevendo um txto em BackGround");
            }
            objAutoResetEvent.Set();
        }
    }
}