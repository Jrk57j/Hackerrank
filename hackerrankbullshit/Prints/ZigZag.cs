using System;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Linq;

namespace hackerrankbullshit.Prints
{
    public class ZigZag
    {
        public ZigZag() { }

        public List<int> Run()
        {
            string str = "7, 1, 1, 2, 3, 4, 5, 6, 7";
            List<int> arr = new();
            List<int> nl = new();
            List<int> ol = new();
            var fst = str[0];
            var send = str[3];
            for (int i = 4; i < str.Length; i++)
            {
                if (str[i] != ' ' && str[i] != ',')
                {
                    arr.Add(int.Parse($"{str[i]}"));
                }
            }
            int k = (arr.Count + 1) / 2;
            for (int i = k - 1; i < arr.Count; i++)
            {
                nl.Add(arr[i]);
            }
            for (int i = 0; i < k - 1; i++)
            {
                ol.Add(arr[i]);
            }
            List<int> revOrder = new();// nl.OrderByDescending(x => x).ToList();
            for (int i = nl.Count - 1; i >= 0; i--)
            {
                revOrder.Add(nl[i]);
            }
            ol.AddRange(revOrder);

            return ol;

        }
    }
}

/*
 List<int> arr = new List<int>();
        List<int> nl = new List<int>();
        List<int> ol = new List<int>();
        using (var sr = new StreamReader(Console.OpenStandardInput(), Console.InputEncoding))
        {
            var input = sr.ReadToEnd();
            string tokens = input.Replace(Environment.NewLine, " ");
            var fst = tokens[0];
            var send = tokens[3];
            
            for(int i = 4; i < tokens.Length; i++)
            {
                if(tokens[i] != ' ' && tokens[i] != ','){
                    arr.Add(int.Parse($"{tokens[i]}"));
                }
            }
            Console.Read();   
        }
        int k = ( arr.Count + 1 ) / 2;
        for(int i = k-1; i < arr.Count; i++)
        {
            nl.Add(arr[i]);
        }
        for(int i = 0; i < k-1; i++)
        {
            ol.Add(arr[i]);
        }
        List<int> revOrder = new List<int>();
        for(int i = nl.Count - 1; i >= 0; i--){
            revOrder.Add(nl[i]);
        }
        ol.AddRange(revOrder);
        string answer = string.Empty;
        foreach(var item in ol){
            answer += item.ToString() + " ";
        }
        
            Console.Write(answer.Trim());
*/
