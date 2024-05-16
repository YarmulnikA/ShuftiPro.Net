using System;
using System.ComponentModel.DataAnnotations;
using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProBackgroundCheck : IShuftiProBackgroundCheck
    {
        [Required]
        public ShuftiProName Name { get; set; }


        public string DayOfBirth { get; set; }

        public bool? OnGoing { get; set; }
    }
}
