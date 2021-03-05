using System;

namespace TestOnionApp.Domain.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Generics;

    [Table("Teacher")]
    public class Teacher : GenericEntity
    {
        public string Name { get; set; }

        [NotMapped]
        public DateTime BirthDate { get; set; }

        public int? Age { get; set; }
    }
}
