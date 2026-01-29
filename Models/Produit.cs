using System.ComponentModel.DataAnnotations;

namespace tp_5.Models
{
    public class Produit
    {
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public decimal Price { get; set; }
        
        public string Description { get; set; }
    }
}