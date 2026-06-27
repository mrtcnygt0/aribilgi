using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tekrar
{
    public class  Document
    {
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public string Path { get; set; }
        public string Size { get; set; }

        public virtual void Yazdir()
        {
            Console.WriteLine("Document has been printed.");
        }

        public static void Yazdir(Document d)
        {
            Console.WriteLine(d.DocumentName + " has been printed.");
        }
    }
    public class WordDocument : Document
    {
        public override void Yazdir()
        {
            Console.WriteLine("Word document has been printed.");
        }
    }

    public class PDFDocument : Document
    {
        
    }

    public class PPointDocument : Document
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            WordDocument d1 = new WordDocument();
            d1.DocumentName = "OOP Ders Notları.docx";
            d1.DocumentType = "Word Document";
            d1.Size = "100000";
            d1.Path = @"C:\Users\Asus\Desktop\OOP Ders Notları.docx";
            
            d1.Yazdir();

            Document.Yazdir(d1);
        }
    }
}
