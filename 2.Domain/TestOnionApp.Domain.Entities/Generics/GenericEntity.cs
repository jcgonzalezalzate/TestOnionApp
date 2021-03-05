using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestOnionApp.Domain.Entities.Generics
{
    public class GenericEntity
    {
        [Key] 
        public int Id { get; set; }
    }
}
