//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HastaneRandevuSistemi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_KONTROL
    {
        public int TETKIK_ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string DOKTOR { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<int> ISLEM_ID { get; set; }
        public string HASTALIKLAR { get; set; }
    
        public virtual TBL_ISLEM TBL_ISLEM { get; set; }
    }
}
