using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid id { get; set; }
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]

        public string Documento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]

        public int TipoFornecedor { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 0)]

        public EnderecoViewModel Endereco { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        /* EF Relations */

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
