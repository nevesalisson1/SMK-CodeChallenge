using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SMK.Application.ViewModels;
using SMK.Domain.Interfaces;
using SMK.Domain.Models;

namespace SMK.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MinerioController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IFuctDomainService _fuctDomainService;

        public MinerioController(IFuctDomainService fuctDomainService, IMapper mapper)
        {
            _fuctDomainService = fuctDomainService;
            _mapper = mapper;
        }

        [HttpGet("ObterQuantidadeDeMinerio")]
        public async Task<IActionResult> ObterQuantidadeDeMinerio([FromQuery] DataViewModel data)
        {
            var x = await _fuctDomainService.ObterMinerais(_mapper.Map<Data>(data));
            return Ok(x);
        }
    }
}