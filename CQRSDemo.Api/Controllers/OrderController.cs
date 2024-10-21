using CQRSDemo.Api.Application.Orders.Command.OrderCreate;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody]OrderCreateCommand creteCommand)
        {
            var id=await _mediator.Send(creteCommand);
            return Ok(id);
        }
    }
}
