using System;
using RestSharp;
using System.IO;
using System.Collections;

namespace StockInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var watchList = new ArrayList();
            if (args.Length > 0)
            {
                if (System.IO.File.Exists(args[0] + ".txt") == true)
                {
                    string[] companies = System.IO.File.ReadAllLines(args[0] + ".txt");
                    File.Delete(args[0] + ".txt");
                    foreach (string company in companies)
                    {
                        watchList.Add(company);
                    }
                }
            }
            char command = 'h';
            string currCompany = "NO COMPANY";
            Commands.PrintC();
            while (command != 'q')
            {
                command = (char)Console.Read();
                while (Console.In.Peek() != -1) Console.In.Read();
                switch (command)
                {
                    case 'q':
                        if (args.Length > 0)
                        {
                            using (System.IO.StreamWriter file = new System.IO.StreamWriter($"{args[0]}.txt", true))
                            {
                                foreach (string company in watchList)
                                {
                                    file.WriteLine(company);
                                }
                            }
                        }
                        return;
                    case 'a':
                        Console.WriteLine("Please Enter a Company Code");
                        string c = Console.ReadLine();
                        if (watchList.Contains(c) == false)
                        {
                            watchList.Add(c);
                        }
                        else
                        {
                            Console.WriteLine("This Company is Already in the Watch List");
                        }
                        watchList.Sort();
                        break;
                    case 'r':
                        Console.WriteLine("Please Enter a Company Code");
                        watchList.Remove(Console.ReadLine());
                        break;
                    case 'c':
                        Console.WriteLine("Please Enter a Company Code");
                        currCompany = Console.ReadLine();
                        break;
                    case 'p':
                        Commands.PriceQuery(currCompany);
                        break;
                    case 'w':
                        Console.WriteLine("Prices of Each Company in your WatchList : ");
                        if (watchList.Count == 0)
                        {
                            Console.WriteLine("Oops, You have no Companies here!");
                        }
                        foreach (string company in watchList)
                        {
                            Commands.PriceQuery(company);
                        }
                        break;
                    case 'l':
                        Console.Write("Your Watch List Consists of : ");
                        if (watchList.Count == 0)
                        {
                            Console.WriteLine("Nothing!");
                        }
                        else
                        {
                            Console.WriteLine(" ");
                        }
                        int i = 0;
                        foreach (string company in watchList)
                        {
                            i++;
                            Console.WriteLine(i + ". " + company);
                        }
                        break;
                    case 'h':
                        Commands.PrintC();
                        break;
                    default:
                        Console.WriteLine("Command Does Not Exist. Please Enter New Command");
                        break;
                }
                while (Console.In.Peek() != -1) Console.In.Read();
            }
        }
    }
    public class Commands
    {
        public static void PrintC()
        {
            Console.WriteLine("'c' to Change Company");
            Console.WriteLine("'p' to Query Prices");
            Console.WriteLine("'a' to Add to Watch List");
            Console.WriteLine("'r' to Remove from Watch List");
            Console.WriteLine("'l' to See your Watch List");
            Console.WriteLine("'w' to Query Prices of All Companies on Watch List");
            Console.WriteLine("'h' to See All Commands");
            Console.WriteLine("'q' to Quit the Program");
        }
        public static void PriceQuery(string company)
        {
            var client = new RestClient("https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=" + company + "&apikey=5KN8H2V0G4OQPZV4");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            string reqRes = response.Content;
            string[] data = reqRes.Split(',');
            bool found = false;
            foreach (var property in data)
            {
                bool isPrice = property.Contains("price");
                if (isPrice)
                {
                    string[] parts = property.Split(':');
                    string x = parts[1].Replace("\"", string.Empty);
                    string price = x.Replace(" ", string.Empty);
                    int wS = 6 - company.Length;
                    Console.Write($"Price of {company} :");
                    for (int i = 0; i < wS; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine($" {price}");
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("INVALID COMPANY CODE");
            }
        }
    }
}
