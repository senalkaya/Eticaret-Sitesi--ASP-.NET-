using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ShippingDetails
    {
        public string UserName { get; set; }
        [Required(ErrorMessage ="Lütfen adres bilgilerinizi giriniz.")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Lütfen sehir giriniz.")]
        public string Semt{ get; set; }
        [Required(ErrorMessage = "Lütfen ilçenizi giriniz.")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lütfen mahalle giriniz.")]
        public string Mahalle { get; set; }
        [Required(ErrorMessage = "Lütfen Posta kodunuzu giriniz.")]
        public string PostaKodu { get; set; }

    }
}