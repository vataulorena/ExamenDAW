using AutoMapper;
using ExamenDAW.Models.Comanda;
using ExamenDAW.Models.Comanda.Dto;
using ExamenDAW.Models.ComandaProdus;
using ExamenDAW.Services.ComandaProdusServ;
using ExamenDAW.Services.ComandaServ;
using Microsoft.AspNetCore.Mvc;

namespace ExamenDAW.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ComandaController : ControllerBase
    {
        private readonly IComandaService _comandaService;
        private readonly IComandaProdusService _comandaprodusService;
        private readonly IMapper _mapper;

        public ComandaController(IComandaService comandaService, IComandaProdusService comandaprodusService, IMapper mapper)
        {
            _comandaService = comandaService;
            _comandaprodusService = comandaprodusService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComandaResponseDto>>> GetComanda()
        {
            var authors = await _comandaService.GetAllComenzi();
            var authorsResponseDto = _mapper.Map<IEnumerable<ComandaResponseDto>>(authors);
            return Ok(authorsResponseDto);
        }

        [HttpPost]
        public async Task<ActionResult<ComandaResponseDto>> CreateComanda([FromBody] ComandaRequestDto comandaRequestDto)
        {
            var author = _mapper.Map<Comanda>(comandaRequestDto);
            var books = _mapper.Map<IList<ComandaProdus>>(comandaRequestDto);
            author.ComandaProdus = comandaprodus;
            await _comandaService.CreateComandaProdus(comandaprodus);
            await _comandaprodusService.CreateAllComandaProdus(comandaprodus);
            var authorResponseDto = _mapper.Map<ComandaResponseDto>(author);
            return Ok(authorResponseDto);
        }

    }
}
