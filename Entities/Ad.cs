using System;
using Entities.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    [Table("Ad")]
    class Ad
    {
        public Ad(Guid id, Car car, string description)
        {
            Id = id;
            Car = car;
            Description = description;
        }

        [Key]
        public Guid Id { get; set; }

        public Car Car { get; set; }

        public int Price { get; set; }

        public Currency Currency { get; set; }

        public string Description { get; set; }
    }
}
