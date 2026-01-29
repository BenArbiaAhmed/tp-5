namespace tp_5.Models
{
    public class PanierParUser
    {
        public Guid Id { get; set; }
        public string UserID { get; set; }
        public Guid ProduitId { get; set; }
        
        public virtual ApplicationUser User { get; set; }
        public virtual Produit Produit { get; set; }
    }
}