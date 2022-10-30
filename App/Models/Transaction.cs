using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Range(1,int.MaxValue,ErrorMessage ="Please select a category")]
        public int CategoryID   { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string? Note { get; set; }
       [ Range(1, double.MaxValue, ErrorMessage = "Please enter amount")]
        public double Amount  { get; set; }
        public DateTime Date { get; set; }= DateTime.Now;
    }
}
