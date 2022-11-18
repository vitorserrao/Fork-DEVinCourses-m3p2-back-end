﻿using Microsoft.AspNetCore.Mvc;
using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.Models;


namespace NDDTraining.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class RegistrationsController : Controller
    {
        private readonly IRegistrationService _registrationService;
        public RegistrationsController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_registrationService.GetAll());
            }
            catch
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]

        public IActionResult Insert(RegistrationDTO registration)
        {
            
                _registrationService.Insert(registration);
                return StatusCode(StatusCodes.Status201Created);

        }
    }
}
