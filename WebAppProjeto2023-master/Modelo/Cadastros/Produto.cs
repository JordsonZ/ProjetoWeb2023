using Modelo.Tabelas;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{
    public class Produto
    {
        [DisplayName("Código")]
        public long? ProdutoId { get; set; }
        [StringLength(100, ErrorMessage = "O nome do produto precisa ter no mínimo 10 caracteres", MinimumLength = 10)]
        [Required(ErrorMessage = "Informe o nome do produto")]
        public string Nome { get; set; }
        [DisplayName("Data de Cadastro")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Informe a data de cadastro do produto")]
        public DateTime? DataCadastro { get; set; }
        [DisplayName("Categoria")]
        public long? CategoriaId { get; set; }
        [DisplayName("Fabricante")]
        public long? FabricanteId { get; set; }
        public string LogotipoMimeType { get; set; }
        public byte[] Logotipo { get; set; }
        public string NomeArquivo { get; set; }
        public long TamanhoArquivo { get; set; }
        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}