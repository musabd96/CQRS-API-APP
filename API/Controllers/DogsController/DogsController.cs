using Application.Commands.Dogs;
using Application.Commands.Dogs.UpdateDog;
using Application.Commands.Dogs.DeleteDog;
using Application.Queries.Dogs.GetAll;
using Application.Queries.Dogs.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Application.Dtos.AnimalDto;
using Application.Validators.Dog;
using Application.Validators;
using Domain.Models;
using Application.Queries.Dogs.GetbyBreed;

namespace API.Controllers.DogsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        internal readonly IMediator _mediator;
        internal readonly DogValidator _dogValidator;
        internal readonly GuidValidator _guidValidator;
        public DogsController(IMediator mediator, DogValidator dogValidator, GuidValidator guidValidator)
        {
            _mediator = mediator;
            _dogValidator = dogValidator;
            _guidValidator = guidValidator;
        }

        // Get all dogs from database
        [HttpGet]
        [Route("getAllDogs"), AllowAnonymous]
        public async Task<IActionResult> GetAllDogs()
        {
            return Ok(await _mediator.Send(new GetAllDogsQuery()));
        }

        // Get a dog by Id
        [HttpGet]
        [Route("getDogById/{dogId}"), AllowAnonymous]
        public async Task<IActionResult> GetDogById(Guid dogId)
        {
            var validatGuid = _guidValidator.Validate(dogId);

            if (!validatGuid.IsValid)
            {
                return BadRequest(validatGuid.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                Dog wantedDog = await _mediator.Send(new GetDogByIdQuery(dogId));
                if (wantedDog == null)
                {
                    ModelState.AddModelError("DogNotFound", $"This Dog Id ({dogId}) is not found");
                    return BadRequest(ModelState);
                }
                return Ok(wantedDog);
            }
        }

        // Get all dogs by breed
        [HttpGet]
        [Route("getDogByBreed/{breed}"), AllowAnonymous]
        public async Task<IActionResult> GetDogByBreed(string breed)
        {
            var wantedDog = await _mediator.Send(new GetAllDogsByBreedQuery(breed));

            if (wantedDog.Count == 0)
            {
                ModelState.AddModelError("DogNotFound", $"Dogs with this breed = ({breed}) not found");
                return BadRequest(ModelState);
            }

            return Ok(wantedDog);
        }

        // Create a new dog 
        [HttpPost]
        [Route("addNewDog")/*, Authorize(Roles = "Admin")*/]
        public async Task<IActionResult> AddDog([FromBody] DogDto newDog)
        {
            var validatGuid = _dogValidator.Validate(newDog);
            if (!validatGuid.IsValid)
            {
                return BadRequest(validatGuid.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                Dog NewDog = await _mediator.Send(new AddDogCommand(newDog));
                return Ok(NewDog);
            }
        }

        // Update a specific dog
        [HttpPut]
        [Route("updateDog/{updatedDogId}")/*, Authorize(Roles = "Admin")*/]
        public async Task<IActionResult> UpdateDog([FromBody] DogDto updatedDog, Guid updatedDogId)
        {
            var validatGuid = _dogValidator.Validate(updatedDog);
            if (!validatGuid.IsValid)
            {
                return BadRequest(validatGuid.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                Dog UpdatedDog = await _mediator.Send(new UpdateDogByIdCommand(updatedDogId, updatedDog));
                return Ok(UpdatedDog);
            }
        }

        // Delete a dog by Id
        [HttpDelete]
        [Route("deleteDogById/{dogId}")/*, Authorize(Roles = "Admin")*/]
        public async Task<IActionResult> DeleteDogById(Guid dogId)
        {
            var validatGuid = _guidValidator.Validate(dogId);
            if (!validatGuid.IsValid)
            {
                return BadRequest(validatGuid.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                Dog deleteDog = await _mediator.Send(new DeleteDogByIdCommand(dogId));
                return Ok(deleteDog);
            }
        }

    }
}
