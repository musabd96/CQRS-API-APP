using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Queries.Birds.GetAll;
using Application.Queries.Birds.GetById;
using Application.Commands.Birds.AddBird;
using Application.Commands.Birds.UpdateBird;
using Application.Commands.Birds.DeleteBird;
using Microsoft.AspNetCore.Authorization;
using Application.Dtos.AnimalDto;
using Application.Validators.Bird;
using Application.Validators;
using Domain.Models;
using Application.Queries.Birds.GetByColor;

namespace API.Controllers.BirdsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdsController : Controller
    {
        internal readonly IMediator _mediator;
        internal readonly BirdValidator _birdValidator;
        internal readonly GuidValidator _guidValidator;
        public BirdsController(IMediator mediator, BirdValidator birdValidator, GuidValidator guidValidator)
        {
            _mediator = mediator;
            _birdValidator = birdValidator;
            _guidValidator = guidValidator;
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
            var validat = _guidValidator.Validate(birdId);

            if (!validat.IsValid)
            {
                return BadRequest(validat.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                Bird wantedBird = await _mediator.Send(new GetBirdByIdQuery(birdId));
                if (wantedBird == null)
                {
                    ModelState.AddModelError("DogNotFound", $"This bird Id {birdId} is not found");
                    return BadRequest(ModelState);
                }
                return Ok(wantedBird);
            }
        }

        // Get all birds by color
        [HttpGet]
        [Route("getCatBycolor/{color}"), AllowAnonymous]
        public async Task<IActionResult> GetCatByBreed(string color)
        {
            var wantedCatColor = await _mediator.Send(new GetAllCatsByColorQuery(color));

            if (wantedCatColor.Count == 0)
            {
                ModelState.AddModelError("CatNotFound", $"Cats with this color = ({color}) not found");
                return BadRequest(ModelState);
            }

            return Ok(wantedCatColor);
        }

        // Create a new bird 
        [HttpPost]
        [Route("addNewBird"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddBird([FromBody] BirdDto newBird)
        {
            var validat = _birdValidator.Validate(newBird);
            if (!validat.IsValid)
            {
                return BadRequest(validat.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                Bird NewBird = await _mediator.Send(new AddBirdCommand(newBird));
                return Ok(NewBird);
            }
        }

        // Update a specific bird
        [HttpPut]
        [Route("updateBird/{updatedBirdId}"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateCat([FromBody] BirdDto updatedBird, Guid updatedBirdId)
        {
            var validat = _birdValidator.Validate(updatedBird);
            if (!validat.IsValid)
            {
                return BadRequest(validat.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                Bird UpdatedBird = await _mediator.Send(new UpdateBirdByIdCommand(updatedBirdId, updatedBird));
                return Ok(UpdatedBird);
            }
        }

        // Delete a bird by Id
        [HttpDelete]
        [Route("deleteBirdById/{birdId}"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteBirdById(Guid birdId)
        {
            var validat = _guidValidator.Validate(birdId);
            if (!validat.IsValid)
            {
                return BadRequest(validat.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                Bird deleteBird = await _mediator.Send(new DeleteBirdByIdCommand(birdId));
                return Ok(deleteBird);
            }
        }
    }
}
