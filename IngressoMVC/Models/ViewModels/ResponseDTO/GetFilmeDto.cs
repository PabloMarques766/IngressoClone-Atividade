using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models.ViewModels.ResponseDTO
{
    public class GetFilmeDto
    {
        [Display(Name = "Título")]
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        [Display(Name = "Preço")]
        public decimal Preco { get; private set; }
        [Display(Name = "Foto")]
        public string ImageURL { get; private set; }

        public List<string> NomeAtores { get; set; }
        public List<string> fotoPerfilURLAtores { get; set; }



    }
}
