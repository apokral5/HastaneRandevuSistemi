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
    
    public partial class TBL_DOKTOR
    {
        public string TC { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public int POLIKINLIKID { get; set; }
        public Nullable<int> UNVAN_ID { get; set; }
        public Nullable<int> DOKTORHESAP_ID { get; set; }
    
        public virtual TBL_DOKTOR_UNVAN TBL_DOKTOR_UNVAN { get; set; }
        public virtual TBL_POLİKİNLİK TBL_POLİKİNLİK { get; set; }
    }
}
