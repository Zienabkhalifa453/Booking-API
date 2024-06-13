﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Booking_API.Models
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        //Foreign Keys



        //Navigation Properties
        [JsonIgnore]
        public ICollection<Hotel> Photos { get; set; } = new HashSet<Hotel>();

    }
}
