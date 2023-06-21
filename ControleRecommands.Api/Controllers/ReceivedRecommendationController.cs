using ControleRecommads.Domain.Commands;
using ControleRecommads.Domain.Handler.Interface;
using ControleRecommads.Domain.IRepositories.IUniteOfWork;
using Microsoft.AspNetCore.Mvc;

namespace ControleRecommands.Api.Controllers
{
    [ApiController]
    [Route("api/received")]
    public class ReceivedRecommendationController : ControllerBase
    {
        private readonly IUniteOfWork _uniteOfWork;
        private readonly IHandler<ReceiveCommand> _handle;

        public ReceivedRecommendationController(IUniteOfWork uniteOfWork, IHandler<ReceiveCommand> handle)
        {
            _uniteOfWork = uniteOfWork;
            _handle = handle;
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] ReceiveCommand command)
        {
            var result = _handle.Handler(command);
            return Ok(result);
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            var rec = _uniteOfWork.ReceivedRecommendationRepository.GetAllRecommendation();

            if (rec is null)
                return NotFound();
            return Ok(rec);
        }
    }
}