namespace tuto1.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ikeadiscount.produit")]
    public partial class produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produit()
        {
            ligne_commande = new HashSet<ligne_commande>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int reference { get; set; }

        [StringLength(27)]
        public string designation { get; set; }

        public int? quantite { get; set; }

        [StringLength(1)]
        public string descriptif { get; set; }

        [StringLength(6)]
        public string prix_unitaire_ht { get; set; }

        public int? stock { get; set; }

        public int? poids_piece { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ligne_commande> ligne_commande { get; set; }
    }
}
