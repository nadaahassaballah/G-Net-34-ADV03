using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV03
{
    public class Helper
    {
        
            public static void PrintHashSet<T>(string SetName, HashSet<T> items)
            {
                Console.WriteLine($"{SetName}:[{string.Join(",", items)}]");
            }
            public static void PrintList<T>(string ListName, List<T> items)
            {
                Console.WriteLine($"{ListName}:[{string.Join(",", items)}]");
            }
            public static void PrintQueue<T>(string QueueName, Queue<T> items)
            {
                Console.WriteLine($"{QueueName}:[{string.Join(",", items)}]");
            }
            public static void PrintStack<T>(string StackName, Stack<T> items)
            {
                Console.WriteLine($"{StackName}:[{string.Join(",", items)}]");
            }
            public static void PrintArray<T>(string ArrayName, T[] items)
            {
                Console.WriteLine($"{ArrayName}:[{string.Join(",", items)}]");
            }
            public static void PrintSpan<T>(string Name, Span<T> Span)
            {
                Console.Write($"{Name}");
                foreach (var item in Span)
                {
                    Console.Write($"{item}");
                }
            }
        }
    }

