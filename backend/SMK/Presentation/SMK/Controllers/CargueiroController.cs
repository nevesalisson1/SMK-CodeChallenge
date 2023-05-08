using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SMK.Application.ViewModels;
using SMK.Domain.Interfaces;
using SMK.Domain.Models;

namespace SMK.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CargueiroController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICargueiroDomainService _cargueiroDomainService;

        public CargueiroController(ICargueiroDomainService cargueiroDomainService, IMapper mapper)
        {
            _cargueiroDomainService = cargueiroDomainService;
            _mapper = mapper;
        }

        [HttpPost("RegistrarSaidaCargueiro")]
        public async Task<IActionResult> RegistrarSaidaCargueiro([FromBody] SaidaCargueiroViewModel saidaCargueiro)
        {
            _cargueiroDomainService.RegistrarSaida();
            return Ok();
        }

        [HttpPost("RegistrarRetornoCargueiro")]
        public async Task<IActionResult> RegistrarRetornoCargueiro([FromBody] RetornoCargueiroViewModel retornoCargueiro)
        {
            _cargueiroDomainService.RegistrarRetorno();
            return Ok();
        }

    }
}
