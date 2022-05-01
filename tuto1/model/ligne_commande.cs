namespace tuto1.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ikeadiscount.ligne_commande")]
    public partial class ligne_commande
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numero { get; set; }

        public int numero_ligne { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int reference { get; set; }

        public int? quantite_demandee { get; set; }

        public virtual commande commande { get; set; }

        public virtual produit produit { get; set; }
    }
}
