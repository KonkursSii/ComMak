using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComMak
{
    class Dictionaries
    {
        Queue<string> p; 
        public Dictionary<string, string> AccessModifiers = new Dictionary<string, string>
        {
            {"public", ""},
            {"private", ""},
            {"internal", ""},
            {"protected", ""},
        };

        public Dictionary<string, string> Keywords = new Dictionary<string, string>
        {
            {"abstract", ""},
            {"async", ""},
            {"base", ""},
            {"bool", ""},
            {"byte", ""},
            {"char", ""},
            {"class", ""},
            {"decimal", ""},
            {"delegate", ""},
            {"double", ""},
            {"enum", ""},
            {"event", ""},
            {"explicit", ""},
            {"extern", ""},
            {"float", ""},
            {"global", ""},
            {"implicit", ""},
            {"int", ""},
            {"interface", ""},
            {"internal", ""},
            {"long", ""},
            {"namespace", ""},
            {"operator", ""},
            {"override", ""},
            {"partial", ""},
            {"sbyte", ""},
            {"sealed", ""},
            {"short", ""},
            {"static", ""},
            {"string", ""},
            {"this", ""},
            {"uint", ""},
            {"ulong", ""},
            {"unsafe", ""},
            {"ushort", ""},
            {"virtual", ""},
            {"void", ""},
        };
    }
}
