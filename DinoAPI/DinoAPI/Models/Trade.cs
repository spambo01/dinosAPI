using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DinoAPI.Models
{
    public class Trade
    {
        public int Id { get; set; }

        [Required]
        public string Product { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Currency { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string CreatedBy { get; set; }
    }
}
