using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SMK.Application.ViewModels;
using SMK.Domain.Interfaces.BusinessLogic;
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
            var minerios = await _fuctDomainService.ObterMinerais(_mapper.Map<Data>(data));

            return Ok(_mapper.Map<MineriosViewModel>(minerios));
        }
    }
}