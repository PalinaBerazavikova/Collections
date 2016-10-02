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
            TimeSpan minAdding = new TimeSpan(0);
            TimeSpan listAdding = ListPerfomance.AddingTime();
            minAdding = listAdding;
            string listAddingString = String.Format($"{listAdding.Minutes:00}:{listAdding.Seconds:00}.{listAdding.Milliseconds:0000}");
            TimeSpan linkedListAdding = LinkedListPerfomance.AddingTime();
            if (minAdding > linkedListAdding)
            {
                minAdding = linkedListAdding;
            }
            string linkedListAddingString = String.Format($"{linkedListAdding.Minutes:00}:{linkedListAdding.Seconds:00}.{linkedListAdding.Milliseconds:0000}");
            TimeSpan dictionaryAdding = DictionaryPerfomance.AddingTime();
            if (minAdding > dictionaryAdding)
            {
                minAdding = dictionaryAdding;
            }
            string dictionaryAddingString = String.Format($"{dictionaryAdding.Minutes:00}:{dictionaryAdding.Seconds:00}.{dictionaryAdding.Milliseconds:0000}");
            TimeSpan queueAdding = QueuePerfomance.AddingTime();
            if (minAdding > queueAdding)
            {
                minAdding = queueAdding;
            }
            string queueAddingString = String.Format($"{queueAdding.Minutes:00}:{queueAdding.Seconds:00}.{queueAdding.Milliseconds:0000}");
            TimeSpan stackAdding = StackPerfomance.AddingTime();
            if (minAdding > stackAdding)
            {
                minAdding = stackAdding;
            }
            string stackAddingString = String.Format($"{stackAdding.Minutes:00}:{stackAdding.Seconds:00}.{stackAdding.Milliseconds:0000}");
            TimeSpan sortedSetAdding = SortedSetPerfomance.AddingTime();
            if (minAdding > sortedSetAdding)
            {
                minAdding = sortedSetAdding;
            }
            string sortedSetAddingString = String.Format($"{sortedSetAdding.Minutes:00}:{sortedSetAdding.Seconds:00}.{sortedSetAdding.Milliseconds:0000}");
            TimeSpan sortedDictionaryAdding = SortedDictionaryPerfomance.AddingTime();
            if (minAdding > sortedDictionaryAdding)
            {
                minAdding = sortedDictionaryAdding;
            }
            string sortedDictionaryAddingString = String.Format($"{sortedDictionaryAdding.Minutes:00}:{sortedDictionaryAdding.Seconds:00}.{sortedDictionaryAdding.Milliseconds:0000}");

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
            lines.Add($@"<tr><td class = ""type"">List</td><td>{listAddingString}</td><td>{ListPerfomance.ReadingTime()}</td><td>{ListPerfomance.SearchTime()}</td><td>{ListPerfomance.RemovingTime()}</td></tr>");
            Console.WriteLine("Analyze LinkedList");
            lines.Add($@"<tr><td class = ""type"">LinkedList</td><td>{linkedListAddingString}</td><td>{LinkedListPerfomance.ReadingTime()}</td><td>{LinkedListPerfomance.SearchTime()}</td><td>{LinkedListPerfomance.RemovingTime()}</td></tr>");
            Console.WriteLine("Analyze Dictionary");
            lines.Add($@"<tr><td class = ""type"">Dictionary</td><td>{dictionaryAddingString}</td><td>{DictionaryPerfomance.ReadingTime()}</td><td>{DictionaryPerfomance.SearchTime()}</td><td>{DictionaryPerfomance.RemovingTime()}</td></tr>");
            Console.WriteLine("Analyze Queue");
            lines.Add($@"<tr><td class = ""type"">Queue</td><td>{queueAddingString}</td><td>{QueuePerfomance.ReadingTime()}</td><td>{QueuePerfomance.SearchTime()}</td><td>{QueuePerfomance.RemovingTime()}</td></tr>");
            Console.WriteLine("Analyze Stack");
            lines.Add($@"<tr><td class = ""type"">Stack</td><td>{stackAddingString}</td><td>{StackPerfomance.ReadingTime()}</td><td>{StackPerfomance.SearchTime()}</td><td>{StackPerfomance.RemovingTime()}</td></tr>");
            Console.WriteLine("Analyze SortedSet");
            lines.Add($@"<tr><td class = ""type"">SortedSet</td><td>{sortedSetAddingString}</td><td>{SortedSetPerfomance.ReadingTime()}</td><td>{SortedSetPerfomance.SearchTime()}</td><td>{SortedSetPerfomance.RemovingTime()}</td></tr>");
            Console.WriteLine("Analyze SortedDictionary");
            lines.Add($@"<tr><td class = ""type"">SortedDictionary</td><td>{sortedDictionaryAddingString}</td><td>{SortedDictionaryPerfomance.ReadingTime()}</td><td>{SortedDictionaryPerfomance.SearchTime()}</td><td>{SortedDictionaryPerfomance.RemovingTime()}</td></tr>");
            
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

