using CodingChallenge.Data.Classes;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CodingChallenge.ViewModels
{
    public class TitleViewModel
    {
        [HiddenInput(DisplayValue = false)]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public string Detalle { get; set; }

        [Required]
        public  string Moneda { get; set; }

        [Required]
        public string Simbolo { get; set; }

        [Required]
        public string Tipo { get; set; }
    }
}