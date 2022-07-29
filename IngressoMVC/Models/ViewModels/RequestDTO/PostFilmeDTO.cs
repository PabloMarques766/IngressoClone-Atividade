using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models.ViewModels.RequestDTO
{
    public class PostFilmeDTO
    {
        [Required(ErrorMessage = "Nome do Ator é Obrigatório!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ator deve ter no máximo 50 caracters, e no mínimo 3")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Descrição é obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preço é obrigatório")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "Imagem obrigatória")]
        public string ImageURL { get; set; }

        
        #region relacionamentos
        public string NomeCinema { get; set; }

        public int ProdutorId { get; set; }

        public List<int> AtoresId { get; set; }
        public List<int> Categorias { get; set; }
        //Por Id
        #endregion
    }
}
