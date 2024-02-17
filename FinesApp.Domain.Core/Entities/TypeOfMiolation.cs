using System;


namespace FinesApp.Domain.Entities
{
    public class TypeOfMiolation
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public string  Part { get; set; }
        public string Description { get; set; }

        public TypeOfMiolation()
        {

        }
        public TypeOfMiolation(string article, string  part, string description)
        {
            Article = article;
            Part = part;
            Description = description;
        }
    }
}
