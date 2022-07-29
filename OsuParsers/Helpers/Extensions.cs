using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using UnityEngine;

namespace OsuParsers.Helpers
{
    internal static class Extensions
    {
        private static NumberFormatInfo NumFormat => new CultureInfo(@"en-US", false).NumberFormat;

        public static int ToInt32(this bool value) => value ? 1 : 0;
        public static string Format(this float value) => value.ToString(NumFormat);
        public static string Format(this double value) => value.ToString(NumFormat);
        public static string Format(this int value) => value.ToString(NumFormat);

        public static string Join(this IEnumerable<string> stringGroup, char splitter = ' ')
        {
            if (stringGroup != null)
            {
                string ret = string.Empty;
                stringGroup.ToList().ForEach(line => ret += line + splitter);
                return ret.TrimEnd(splitter);
            }
            else
                return string.Empty;
        }

        public static string Join(this IEnumerable<int> intGroup, char splitter = ' ')
        {
            if (intGroup != null)
                return intGroup.ToList().ConvertAll(e => e.ToString()).Join(splitter);
            else
                return string.Empty;
        }

        public static IEnumerable<string> ReadAllLines(this Stream stream)
        {
            using (var sr = new StreamReader(stream))
            {
                var full = sr.ReadToEnd();
                return full.Split(new string[] { Environment.NewLine }, 0);
            }
        }

        public static bool Equal(this Color32 a, Color32 b)
        {
            return a.r == b.r && a.g == b.g && a.b == b.b && a.a == b.a;
        }

        public static bool Equal(this Color32 a, byte br, byte bg, byte bb, byte ba)
        {
            return a.r == br && a.g == bg && a.b == bb && a.a == ba;
        }

        public static bool EqualWhite(this Color32 a)
        {
            return a.Equal(255, 255, 255, 255);
        }
    }
}
