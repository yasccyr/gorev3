using System.ComponentModel.DataAnnotations;

namespace SpendSmart.Models
{
    public class Expense
    {
        public int ID { get; set; }

        public decimal Value { get; set; }

        [Required]
        public string? Despriction { get; set; }
    }
}
