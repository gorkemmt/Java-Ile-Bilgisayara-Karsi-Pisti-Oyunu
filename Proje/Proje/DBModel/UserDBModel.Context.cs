﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.DBModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Blockchain : DbContext
    {
        public Blockchain()
            : base("name=Blockchain")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AlımSatımGecmisi> AlımSatımGecmisi { get; set; }
        public virtual DbSet<BakiyeBilgi> BakiyeBilgi { get; set; }
        public virtual DbSet<KullanıcıKayıt> KullanıcıKayıt { get; set; }
        public virtual DbSet<Odeme> Odeme { get; set; }
        public virtual DbSet<ParaTürleri> ParaTürleri { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<YöneticiKayıt> YöneticiKayıt { get; set; }
    }
}