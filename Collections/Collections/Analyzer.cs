using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Analyzer
    {
        public void CreateHTMLFile()
        {
            List<string> lines = new List<string>();
            lines.Add("<!DOCTYPE HTML>");
            lines.Add("<html>");
            lines.Add(" <head>");
            lines.Add(@"<meta charset=""utf - 8"">");
            lines.Add(" <title>Analysys</title>");
            lines.Add(@"<style type=""text/css"">");
            lines.Add(" td.type {");
            lines.Add(" padding: 15px;");
            lines.Add(" background: #CEF6E3;");
            lines.Add(" }");
            lines.Add("</style>");
            lines.Add("</head>");
            lines.Add("<body>");
            lines.Add(@"<table border=""1"">");
            lines.Add("<caption>Analysis</caption>");
            lines.Add("<tr><td>Type</td><td>Adding (1 000 000 elements)</td><td>Reading (1 000 000 elements)</td><td>Search (1 000 000 elements)</td><td>Removing (100 000 elements)</td></tr>");
            Console.WriteLine("Analyze List");
            lines.Add($@"<tr><td class = ""type"">List</td><td>{ListPerfomance.AddingTime()}</td><td>{ListPerfomance.ReadingTime()}</td><td>{ListPerfomance.SearchTime()}</td><td>{ListPerfomance.RemovingTime()}</td></tr>");
            Console.WriteLine("Analyze LinkedList");
            lines.Add($@"<tr><td class = ""type"">LinkedList</td><td>{LinkedListPerfomance.AddingTime()}</td><td>{LinkedListPerfomance.ReadingTime()}</td><td>{LinkedListPerfomance.SearchTime()}</td><td>{LinkedListPerfomance.RemovingTime()}</td></tr>");
            Console.WriteLine("Analyze Dictionary");
            lines.Add($@"<tr><td class = ""type"">Dictionary</td><td>{DictionaryPerfomance.AddingTime()}</td><td>{DictionaryPerfomance.ReadingTime()}</td><td>{DictionaryPerfomance.SearchTime()}</td><td>{DictionaryPerfomance.RemovingTime()}</td></tr>");
            Console.WriteLine("Analyze Queue");
            lines.Add($@"<tr><td class = ""type"">Queue</td><td>{QueuePerfomance.AddingTime()}</td><td>{QueuePerfomance.ReadingTime()}</td><td>{QueuePerfomance.SearchTime()}</td><td>{QueuePerfomance.RemovingTime()}</td></tr>");
            Console.WriteLine("Analyze Stack");
            lines.Add($@"<tr><td class = ""type"">Stack</td><td>{StackPerfomance.AddingTime()}</td><td>{StackPerfomance.ReadingTime()}</td><td>{StackPerfomance.SearchTime()}</td><td>{StackPerfomance.RemovingTime()}</td></tr>");
            Console.WriteLine("Analyze SortedSet");
            lines.Add($@"<tr><td class = ""type"">SortedSet</td><td>{SortedSetPerfomance.AddingTime()}</td><td>{SortedSetPerfomance.ReadingTime()}</td><td>{SortedSetPerfomance.SearchTime()}</td><td>{SortedSetPerfomance.RemovingTime()}</td></tr>");
            Console.WriteLine("Analyze SortedDictionary");
            lines.Add($@"<tr><td class = ""type"">SortedDictionary</td><td>{SortedDictionaryPerfomance.AddingTime()}</td><td>{SortedDictionaryPerfomance.ReadingTime()}</td><td>{SortedDictionaryPerfomance.SearchTime()}</td><td>{SortedDictionaryPerfomance.RemovingTime()}</td></tr>");
            lines.Add("</table>");
            lines.Add("</body>");
            lines.Add("</html>");
            using (System.IO.StreamWriter file = new System.IO.StreamWriter($@"{Environment.CurrentDirectory}\Analysis.html"))
            {

                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
            Console.WriteLine($@"File was saved in {Environment.CurrentDirectory}\Analysis.html");
        }
    }
}

