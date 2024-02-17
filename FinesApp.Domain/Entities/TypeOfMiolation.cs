using System;


namespace FinesApp.Domain.Entities
{
    public class TypeOfMiolation
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
