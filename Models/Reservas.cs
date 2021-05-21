using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NARANJA.Models

{
    [Table ("reservas")]
    public class Reservas
    {
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]

        public int id { get; set; }
        [Column("fecha")]
        public DateTime fecha { get; set; }
        [Column("n_personas")]
        public string n_personas { get; set; }
        [Column("ocasion")]
        public string ocasion { get; set; }

    }
}