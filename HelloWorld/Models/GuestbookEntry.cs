using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class GuestbookEntry
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Põe um nome ae parcero")]
        public string Name { get; set; }
        [Required(ErrorMessage="Tem que ter mensagem né?!")]
        public string Message { get; set; }
        public DateTime DateAdded { get; set; }
    }
}