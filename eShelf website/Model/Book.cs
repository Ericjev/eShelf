//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eShelf_website.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Carts = new HashSet<Cart>();
            this.RestockDetails = new HashSet<RestockDetail>();
        }
    
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Sypnosis { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public System.DateTime PublishDate { get; set; }
        public string Cover { get; set; }
        public string SupplierID { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual Catalog Catalog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestockDetail> RestockDetails { get; set; }
    }
}