using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SMK.Application.ViewModels;
using SMK.Domain.Interfaces.BusinessLogic;
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
        public async Task<IActionResult> RegistrarSaidaCargueiro([FromBody] RegistrarCargueiroViewModel saidaCargueiro)
        {
            await _cargueiroDomainService.RegistrarSaida(_mapper.Map<SaidaCargueiro>(saidaCargueiro));
            return Ok();
        }

        [HttpPost("RegistrarRetornoCargueiro")]
        public async Task<IActionResult> RegistrarRetornoCargueiro([FromBody] RegistrarCargueiroViewModel retornoCargueiro)
        {
            await _cargueiroDomainService.RegistrarRetorno(_mapper.Map<RetornoCargueiro>(retornoCargueiro));
            return Ok();
        }

    }
}
