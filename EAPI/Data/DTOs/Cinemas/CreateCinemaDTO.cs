﻿using System.ComponentModel.DataAnnotations;

namespace EAPI.Data.DTOs.Cinemas
{
    public class CreateEnderecoDTO
    {

        [Required(ErrorMessage = "O campo de {0} é obrigatório!")]
        public string Nome { get; set; }
    }
}
