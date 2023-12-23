﻿using Application.Commands.Users.AddAnimal;
using Application.Commands.Users.DeketeAnimal;
using Application.Commands.Users.Register;
using Application.Commands.Users.UpdateAnimal;
using Application.Dtos.Animals;
using Application.Dtos.Users;
using Application.Dtos.Validation;
using Application.Exceptions.Authorize;
using Application.Queries.Users.GetAll;
using Application.Queries.Users.GetById;
using Application.Queries.Users.Login;
using Application.Validators.User;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.AuthController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        internal readonly IMediator _mediator;
        internal readonly UserValidator _userValidator;

        public UsersController(IMediator mediator, UserValidator userValidator)
        {
            _mediator = mediator;
            _userValidator = userValidator;
        }

        [HttpPost("register")]
        [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Errors), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register([FromBody] UserDto userToRegister)
        {
            var inputValidation = _userValidator.Validate(userToRegister);

            if (!inputValidation.IsValid)
            {
                return BadRequest(inputValidation.Errors.ConvertAll(errors => errors.ErrorMessage));
            }

            try
            {
                return Ok(await _mediator.Send(new RegisterUserCommand(userToRegister)));
            }
            catch (ArgumentException e)
            {
                //// Log the error and return an error response
                //_logger.LogError(e, "Error registering user");
                return BadRequest(e.Message);
            }
        }

        [HttpPost("login")]
        [ProducesResponseType(typeof(TokenDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Errors), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Login([FromBody] UserDto userToLogin)
        {
            var inputValidation = _userValidator.Validate(userToLogin);

            if (!inputValidation.IsValid)
            {
                return BadRequest(inputValidation.Errors.ConvertAll(errors => errors.ErrorMessage));
            }

            try
            {
                string token = await _mediator.Send(new LoginUserQuery(userToLogin));

                return Ok(new TokenDto { TokenValue = token });
            }
            catch (UnAuthorizedException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Get all animals from database by user authorize
        [HttpGet]
        [Route("getAllAnimals"), Authorize]
        public async Task<IActionResult> GetAllAnimals()
        {
            // Get the username of the authenticated user
            string username = HttpContext.User.Identity!.Name!;

            return Ok(await _mediator.Send(new GetAllAnimalsQuery(username)));
        }

        // Get animals from database by animalId and user authorize
        [HttpGet]
        [Route("getAnimalById/{animalId}")/*, Authorize*/]
        public async Task<IActionResult> GetAnimalById(Guid animalId)
        {
            // Get the username of the authenticated user
            //string username = HttpContext.User.Identity!.Name!;
            string username = "musse";

            return Ok(await _mediator.Send(new GetAnimalByIdQuery(animalId, username)));
        }


        // Create a new animal 
        [HttpPost]
        [Route("addNewAnimal"), Authorize]
        public async Task<IActionResult> AddAnimal([FromBody] AnimalDto newAnimal)
        {
            // Get the username of the authenticated user
            string username = HttpContext.User.Identity!.Name!;

            return Ok(await _mediator.Send(new AddAnimalsCommand(username, newAnimal)));
        }

        // Update a specific user's pet
        [HttpPut]
        [Route("updateAnimal/{updateAnimalId}"), Authorize]
        public async Task<IActionResult> UpdateAnimal([FromBody] AnimalDto updatedAimal, Guid updateAnimalId)
        {
            // Get the username of the authenticated user
            string username = HttpContext.User.Identity!.Name!;

            return Ok(await _mediator.Send(new UpdateAnimalsCommand(updateAnimalId, updatedAimal, username)));

        }

        // Delete a specific user's pet. Pet will be without owner
        [HttpDelete]
        [Route("deleteAnimalById/{animalId}"), Authorize]
        public async Task<IActionResult> DeleteAnimal(Guid animalId)
        {
            // Get the username of the authenticated user
            string username = HttpContext.User.Identity!.Name!;

            return Ok(await _mediator.Send(new DeleteAnimalsCommand(animalId, username)));

        }
    }
}
