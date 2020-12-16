using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace SecondAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\MuyiwaOlalekan\\OneDrive - Enov8 Solutions Ltd\\Desktop\\InputOutputFileStream\\new.txt";
            int countThevalue = 0;
            DateTime todayDate = DateTime.Now;
            List <string> textContent = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                countThevalue++;
                Console.WriteLine("Please input the text content {0}",todayDate);
                string contentTopics = Console.ReadLine();
                Thread.Sleep(3000);
                textContent.Add(contentTopics);
            }

            textContent.Reverse();

            File.AppendAllLines(filePath, textContent);

            Console.ReadLine();
        }
    }
}
