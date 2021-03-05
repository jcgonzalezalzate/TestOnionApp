namespace TestOnionApp.Domain.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Generics;

    [Table("Student")]
    public class Student : GenericEntity
    {
        public string Name { get; set; }
    }
}