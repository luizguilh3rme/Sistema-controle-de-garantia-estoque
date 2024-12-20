﻿using ControleEstoque.Enums;
using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do usuario")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o login do usuario")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o email do usuario")]
        [EmailAddress(ErrorMessage ="O email informado não é válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe o perfil do usuário")]
        public PerfilEnum? Perfil { get; set; }
        [Required(ErrorMessage = "Digite a senha do usuario")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }

        public bool SenhaValida(string senha) //usou bool para informar se a senha é true ou false
        {
            return Senha == senha; //compara a senha do banco com a senha preenchida pelo usuário
        }
    }
}
