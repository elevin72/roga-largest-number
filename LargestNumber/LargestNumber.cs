﻿using System.Xml.Linq;

namespace LargestNumber
{
    public class LargestNumber
    {
        static public long GetLargestNumber(List<long> list)
        {
            return list.Max();
        }

        static public long GetLargestNumberFromXml(XDocument xml)
        {
            List<long> list = xml.Descendants("Number")
                .Select(element => long.Parse(element.Value))
                .ToList();

            return GetLargestNumber(list);
        }
    }
}
