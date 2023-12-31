﻿using Application.Commands.Cats;
using Application.Commands.Cats.DeleteCat;
using Application.Commands.Cats.UpdateCat;
using Application.Dtos.AnimalDto;
using Application.Queries.Cats.GetById;
using Application.Queries.Cats.GettAll;
using Application.Validators;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Application.Validators.Cat;
using Application.Queries.Cats.GetbyBreed;

namespace API.Controllers.CatsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : Controller
    {
        internal readonly IMediator _mediator;
        internal readonly CatValidator _catValidator;
        internal readonly GuidValidator _guidValidator;
        public CatsController(IMediator mediator, CatValidator catValidator, GuidValidator guidValidator)
        {
            _mediator = mediator;
            _catValidator = catValidator;
            _guidValidator = guidValidator;
        }

        // Get all cats from database
        [HttpGet]
        [Route("getAllCats"), AllowAnonymous]
        public async Task<IActionResult> GetAllDogs()
        {
            return Ok(await _mediator.Send(new GetAllCatsQuery()));
        }

        // Get a cat by Id
        [HttpGet]
        [Route("getCatById/{catId}"), AllowAnonymous]
        public async Task<IActionResult> GetCatById(Guid catId)
        {
            var validatGuid = _guidValidator.Validate(catId);

            if (!validatGuid.IsValid)
            {
                return BadRequest(validatGuid.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                Cat wantedCat = await _mediator.Send(new GetCatByIdQuery(catId));
                if (wantedCat == null)
                {
                    ModelState.AddModelError("DogNotFound", $"This bird Id {catId} is not found");
                    return BadRequest(ModelState);
                }
                return Ok(wantedCat);
            }
        }

        // Get cats by breed and/or weight
        [HttpGet]
        [Route("getCatByCriteria")]
        [AllowAnonymous]
        public async Task<IActionResult> GetCatByCriteria([FromQuery] string? breed, [FromQuery] int? weight)
        {
            var wantedCatCriteria = await _mediator.Send(new GetAllCatsByCriteriaQuery(breed, weight));

            if (wantedCatCriteria.Count == 0)
            {
                ModelState.AddModelError("CatNotFound", "No cats found based on the specified criteria");
                return BadRequest(ModelState);
            }

            return Ok(wantedCatCriteria);
        }


        // Create a new cat 
        [HttpPost]
        [Route("addNewCat"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddCat([FromBody] CatDto newCat)
        {
            var validatGuid = _catValidator.Validate(newCat);
            if (!validatGuid.IsValid)
            {
                return BadRequest(validatGuid.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                Cat NewCat = await _mediator.Send(new AddCatCommand(newCat));
                return Ok(NewCat);
            }
        }

        // Update a specific cat
        [HttpPut]
        [Route("updateCat/{updatedCatId}"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateCat([FromBody] CatDto updatedCat, Guid updatedCatId)
        {
            var validatGuid = _catValidator.Validate(updatedCat);
            if (!validatGuid.IsValid)
            {
                return BadRequest(validatGuid.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                Cat UpdatedCat = await _mediator.Send(new UpdateCatByIdCommand(updatedCatId, updatedCat));
                return Ok(UpdatedCat);
            }
        }

        // Delete a cat by Id
        [HttpDelete]
        [Route("deleteCatById/{catId}"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteCatById(Guid catId)
        {
            var validatGuid = _guidValidator.Validate(catId);
            if (!validatGuid.IsValid)
            {
                return BadRequest(validatGuid.Errors.Select(error => error.ErrorMessage));
            }
            else
            {
                Cat deleteCat = await _mediator.Send(new DeleteCatByIdCommand(catId));
                return Ok(deleteCat);
            }
        }
    }
}
