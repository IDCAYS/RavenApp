namespace tuto1.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ikeadiscount.commande")]
    public partial class commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public commande()
        {
            ligne_commande = new HashSet<ligne_commande>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numero { get; set; }

        public int? code_v { get; set; }

        public int? code_c { get; set; }

        [StringLength(8)]
        public string date_livraison { get; set; }

        [StringLength(8)]
        public string date_commande { get; set; }

        [StringLength(7)]
        public string total_ht { get; set; }

        [StringLength(8)]
        public string total_tva { get; set; }

        public int? etat { get; set; }

        public virtual client client { get; set; }

        public virtual vendeur vendeur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ligne_commande> ligne_commande { get; set; }
    }
}
