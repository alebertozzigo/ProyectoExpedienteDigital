//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpDigital.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Capitulo
    {
        public int ID { get; set; }
        public string titulo { get; set; }
        public int numeroAutores { get; set; }
        public int id_libro { get; set; }
    
        public virtual Libro Libro { get; set; }
    }
}
