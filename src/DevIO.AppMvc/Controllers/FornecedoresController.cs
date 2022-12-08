using DevIO.Business.Models.Fornecedores;
using DevIO.Business.Models.Fornecedores.Services;
using DevIO.Infra.Data.Repository;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DevIO.AppMvc.Controllers
{
    public class FornecedoresController : Controller
    {

        private readonly IFornecedorService _fornecedorService;

        public FornecedoresController()
        {
            _fornecedorService = new FornecedorService(new FornecedorRepository(), new EnderecoRepository(), null);
        }

        public async Task<ActionResult> Index()
        {
            var fornecedor = new Fornecedor()
            {
                Nome = "Arlequina",
                Documento = "36785676543",
                Endereco = new Endereco
                {
                    Logradouro = "Rua Teste",
                    Bairro = "Teste",
                    Numero="123",
                    Cep = "07866543",
                    Cidade = "Teste",
                    Complemento = "2",
                    Estado = "Teste",
                },

                TipoFornecedor = TipoFornecedor.PessoaFisica,
                Ativo = true
            };

            await _fornecedorService.Adicionar(fornecedor);

                return new EmptyResult();
        }
    }
}
