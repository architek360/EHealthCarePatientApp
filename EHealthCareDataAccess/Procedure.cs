//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EHealthCareDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Procedure
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string ProcedureName { get; set; }
        public System.DateTime Date { get; set; }
        public int PrimaryProviderId { get; set; }
        public int SecondaryProviderId { get; set; }
        public string Notes { get; set; }
        public System.Guid UniqueIdentifier { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}