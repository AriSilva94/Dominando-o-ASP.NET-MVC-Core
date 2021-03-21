using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MinhaAppMvcCompleta.Data;
using System.Threading.Tasks;

namespace DevIO.App.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;

        public FornecedoresController(IFornecedorRepository fornecedorRepository, IMapper mapper)
        {
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<FornecedorViewModel>(await _fornecedorRepository.ObterTodos()));
        }
    }
}
