using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CodingChallenge.ViewModels
{
    public class TitleViewModel
    {
        [HiddenInput(DisplayValue = false)]
        [Required]
        public int TitleId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Symbol { get; set; }

        [Required]
        public decimal Last { get; set; }

        [Required]
        public decimal VarPer { get; set; }

        [Required]
        public string CapMarket { get; set; }

        [Required]
        public decimal Volume { get; set; }
    }
}