using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace tuto1.model
{
    public partial class Donnee : DbContext
    {
        public Donnee()
            : base("name=Donnee")
        {
        }

        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<commande> commandes { get; set; }
        public virtual DbSet<ligne_commande> ligne_commande { get; set; }
        public virtual DbSet<produit> produits { get; set; }
        public virtual DbSet<vendeur> vendeurs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<client>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.ville)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.commandes)
                .WithOptional(e => e.client)
                .WillCascadeOnDelete();

            modelBuilder.Entity<commande>()
                .Property(e => e.date_livraison)
                .IsUnicode(false);

            modelBuilder.Entity<commande>()
                .Property(e => e.date_commande)
                .IsUnicode(false);

            modelBuilder.Entity<commande>()
                .Property(e => e.total_ht)
                .IsUnicode(false);

            modelBuilder.Entity<commande>()
                .Property(e => e.total_tva)
                .IsUnicode(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.designation)
                .IsUnicode(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.descriptif)
                .IsUnicode(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.prix_unitaire_ht)
                .IsUnicode(false);

            modelBuilder.Entity<vendeur>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<vendeur>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<vendeur>()
                .Property(e => e.ville)
                .IsUnicode(false);

            modelBuilder.Entity<vendeur>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<vendeur>()
                .HasMany(e => e.commandes)
                .WithOptional(e => e.vendeur)
                .WillCascadeOnDelete();
        }
    }
}
