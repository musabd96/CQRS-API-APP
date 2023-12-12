using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Queries.Birds;
using Application.Queries.Birds.GetAll;
using Application.Queries.Birds.GetById;
using Application.Commands.Birds.AddBird;
using Application.Commands.Birds.UpdateBird;
using Application.Commands.Birds.DeleteBird;
using Microsoft.AspNetCore.Authorization;
using Application.Dtos.AnimalDto;

namespace API.Controllers.BirdsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdsController : Controller
    {
        internal readonly IMediator _mediator;
        public BirdsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Get all birds from database
        [HttpGet]
        [Route("getAllBirds"), AllowAnonymous]
        public async Task<IActionResult> GetAllBirds()
        {
            return Ok(await _mediator.Send(new GetAllBirdsQuery()));
        }

        // Get a bird by Id
        [HttpGet]
        [Route("getBirdById/{birdId}"), AllowAnonymous]
        public async Task<IActionResult> GetBirdById(Guid birdId)
        {
            return Ok(await _mediator.Send(new GetBirdByIdQuery(birdId)));
        }

        // Create a new bird 
        [HttpPost]
        [Route("addNewBird")/*, Authorize(Roles = "Admin")*/]
        public async Task<IActionResult> AddBird([FromBody] BirdDto newBird)
        {
            return Ok(await _mediator.Send(new AddBirdCommand(newBird)));
        }

        // Update a specific bird
        [HttpPut]
        [Route("updateBird/{updatedBirdId}")/*, Authorize(Roles = "Admin")*/]
        public async Task<IActionResult> UpdateCat([FromBody] BirdDto updatedBird, Guid updatedBirdId)
        {
            return Ok(await _mediator.Send(new UpdateBirdByIdCommand(updatedBird, updatedBirdId)));
        }

        // Delete a bird by Id
        [HttpDelete]
        [Route("deleteBirdById/{birdId}")/*, Authorize(Roles = "Admin")*/]
        public async Task<IActionResult> DeleteBirdById(Guid birdId)
        {
            return Ok(await _mediator.Send(new DeleteBirdByIdCommand(birdId)));
        }
    }
}
