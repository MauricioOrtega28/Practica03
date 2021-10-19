using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica03.Models
{
    [Table("t_solicitud")]
    public class Solicitud
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set; }

        [Required(ErrorMessage ="Debe ingresar el nombre del producto")]
        public string Nombre {get; set; }
         [Required(ErrorMessage ="Debe ingresar el link de la foto del producto")]
        public string Foto {get; set; }
        [Required(ErrorMessage ="Debe ingresar la descripcion del producto")]
        public string Descripcion {get; set;}
        [Required(ErrorMessage ="Debe ingresar el precio del producto")]
        public double Precio {get; set; }
        [Required(ErrorMessage ="Debe ingresar el numero de celular")]
        public string Celular {get; set; }
        [Required(ErrorMessage ="Debe ingresar el lugar")]
        public string Lugar {get; set; }
         [Required(ErrorMessage ="Debe ingresar el nombre del comprador")]
        public string Comprador {get; set; }

        public DateTime Fecha {get; set; }

        public Categoria categoria {get; set; }

        public Solicitud(){
            this.Fecha= DateTime.Now;
        }
    }
}