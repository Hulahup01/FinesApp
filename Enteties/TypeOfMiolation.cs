using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInesApp.Enteties
{
    internal class TypeOfMiolation
    {
        string Article { get; set; }
        int Part { get; set; }
        string Description { get; set; }

        public TypeOfMiolation(string article, int part, string description)
        {
            Article = article;
            Part = part;
            Description = description;
        }
    }
}
