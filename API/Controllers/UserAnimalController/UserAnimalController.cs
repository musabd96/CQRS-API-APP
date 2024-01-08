using Application.Commands.Birds.DeleteBird;
using Application.Commands.Users.AddAnimal;
using Application.Commands.Users.DeketeAnimal;
using Application.Commands.Users.UpdateAnimal;
using Application.Dtos.Animals;
using Application.Queries.Users.GetAll;
using Application.Queries.Users.GetById;
using Application.Validators;
using Application.Validators.User;
using Domain.Models.Animal;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.AuthController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAnimalController : ControllerBase
    {
        internal readonly IMediator _mediator;
        internal readonly AnimalValidator _animalValidation;
        internal readonly GuidValidator _guidValidator;

        public UserAnimalController(IMediator mediator,
                               GuidValidator validationRules,
                               AnimalValidator animalValidation)
        {
            _mediator = mediator;
            _guidValidator = validationRules;
            _animalValidation = animalValidation;
        }

        // Get all animals from database by user authorize
        [HttpGet]
        [Route("getAllAnimals")]
        [Authorize]
        public async Task<IActionResult> GetAllAnimals()
        {
            // Get the username of the authenticated user
            string username = HttpContext.User.Identity!.Name!;

            return Ok(await _mediator.Send(new GetAllAnimalsQuery(username)));

        }

        // Get animals from database by animalId and user authorize
        [HttpGet]
        [Route("getAnimalById/{animalId}"), Authorize]
        public async Task<IActionResult> GetAnimalById(Guid animalId)
        {
            var validat = _guidValidator.Validate(animalId);
            if (!validat.IsValid)
            {
                return BadRequest(validat.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                // Get the username of the authenticated user
                string username = HttpContext.User.Identity!.Name!;

                AnimalModel deleteBird = await _mediator.Send(new GetAnimalByIdQuery(animalId, username));
                return Ok(deleteBird);
            }
        }

        // Create a new animal 
        [HttpPost]
        [Route("addNewAnimal")]
        [Authorize]
        public async Task<IActionResult> AddAnimal([FromBody] AnimalDto newAnimal)
        {
            var validat = _animalValidation.Validate(newAnimal);
            if (!validat.IsValid)
            {
                return BadRequest(validat.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                // Get the username of the authenticated user
                string username = HttpContext.User.Identity!.Name!;

                List<AnimalModel> newAnimals = await _mediator.Send(new AddAnimalsCommand(username, newAnimal));
                return Ok(newAnimals);
            }
        }

        // Update a specific user's pet
        [HttpPut]
        [Route("updateAnimal/{updateAnimalId}"), Authorize]
        public async Task<IActionResult> UpdateAnimal([FromBody] AnimalDto updatedAimal, Guid updateAnimalId)
        {
            var validat = _animalValidation.Validate(updatedAimal);

            if (!validat.IsValid)
            {
                return BadRequest(validat.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                // Get the username of the authenticated user
                string username = HttpContext.User.Identity!.Name!;

                return Ok(await _mediator.Send(new UpdateAnimalsCommand(updateAnimalId, updatedAimal, username)));
            }
        }

        // Delete a specific user's pet. Pet will be without owner
        [HttpDelete]
        [Route("deleteAnimalById/{animalId}"), Authorize]
        public async Task<IActionResult> DeleteAnimal(Guid animalId)
        {
            var validat = _guidValidator.Validate(animalId);

            if (!validat.IsValid)
            {
                return BadRequest(validat.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                // Get the username of the authenticated user
                string username = HttpContext.User.Identity!.Name!;

                return Ok(await _mediator.Send(new DeleteAnimalsCommand(animalId, username)));
            }
        }
    }
}
