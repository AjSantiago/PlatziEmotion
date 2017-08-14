using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmotionPlatzi.Web.Models
{
    public class EmoPicture
    {   //Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        //[Required]
        //[MaxLength(10, ErrorMessage = "La ruta supera el tamaño establecido")]
        public string Path { get; set; }

        //Propiedad de navegación
        public virtual ObservableCollection<EmoFace> Faces { get; set; }

    }
}