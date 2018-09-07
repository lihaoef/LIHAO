using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

using System.Xml.Serialization;

namespace RegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //string line = "lane=1;speed=30.5mph;acceleration=2.5mph/s";
            //Regex reg = new Regex(@"speed\s*=\s*([\d\.]+)\s*(mph|km/h|m/s)*");
            //Match match = reg.Match(line);
            ////那么在返回的结果中match.Groups[1].Value将含有数值，而match.Groups[2].Value将含有单位。
            //var 值 = match.Groups[1].Value;//此处方便演示，在实际开发中请勿使用中文命名变量
            //var 单位 = match.Groups[2].Value;
            //Console.WriteLine("speed的值为：{0} speed的单位是:{1}", 值, 单位);
            string block = File.ReadAllText(@".\test.txt");
            //Regex reg = new Regex(@"FN .*?ENDFN.*", RegexOptions.Singleline);
            //Regex reg = new Regex(@"\d1234+");
            var matches = Regex.Matches(block, @"", RegexOptions.Singleline);

            foreach (Match item in matches)
            {
                foreach (Group group in item.Groups)
                {
                    
                }
            }
            //var matches = reg.Matches(block);
            //foreach (Match item in matches)
            //{
            
            //}
            string sab = "ab    c  \t de";
            var matchers =  Regex.Matches(sab, @"\w+");
            Console.Read();
        }
    }
}
