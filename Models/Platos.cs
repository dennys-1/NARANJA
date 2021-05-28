using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NARANJA.Models
{
    [Table ("platos")]
    public class Platos
    {
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id {get; set;}
        
        [Column("nombre")]
        public String Nombre {get; set;}
        [Column("precio")]  
        public Decimal Precio { get; set; }

        [Column("descripcion")] 
        public String descripcion { get; set; }
        
        [Column("imagen")] 
        public String imagen { get; set; }

        
        
    }
}