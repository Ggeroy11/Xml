using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("https://habrahabr.ru/rss/interesting/");
            List<Item> items = new List<Item>();
            

        }
    }
}
