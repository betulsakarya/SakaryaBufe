﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SakaryaBufe
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SakaryaBufeEntities3 : DbContext
    {
        public SakaryaBufeEntities3()
            : base("name=SakaryaBufeEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bisküviler> Bisküviler { get; set; }
        public virtual DbSet<Cikolatalar> Cikolatalars { get; set; }
        public virtual DbSet<Cipsler> Cipslers { get; set; }
        public virtual DbSet<Icecekler> Iceceklers { get; set; }
        public virtual DbSet<Kategoriler> Kategorilers { get; set; }
        public virtual DbSet<Kekler> Keklers { get; set; }
        public virtual DbSet<Krakerler> Krakerlers { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<KullaniciGiri> KullaniciGiris { get; set; }
        public virtual DbSet<Manset> Mansets { get; set; }
        public virtual DbSet<MesajBox> MesajBoxes { get; set; }
        public virtual DbSet<Oyuncaklar> Oyuncaklars { get; set; }
        public virtual DbSet<Resimler> Resimlers { get; set; }
        public virtual DbSet<Sakizlar> Sakizlars { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
