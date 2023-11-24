using Application.Queries.Cats.GettAll;
using Application.Queries.Dogs.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.CatsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : Controller
    {
        internal readonly IMediator _mediator;
        public CatsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Get all cats from database
        [HttpGet]
        [Route("getAllCats")]
        public async Task<IActionResult> GetAllDogs()
        {
            return Ok(await _mediator.Send(new GetAllCatsQuery()));
        }
    }
}
