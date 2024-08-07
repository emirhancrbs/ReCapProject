﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll() 
        {
            var result = _userService.GetAll();
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int userId) 
        {
            var result = _userService.GetById(userId);
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(User user) 
        {
            var result = _userService.Add(user);
            if (result.Success) 
            {
                return Ok(result); 
            }
            return BadRequest(result);
        }
        [HttpPost("deletebyid")]
        public IActionResult DeleteById(int userId)
        {
            var result = _userService.DeleteById(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(User user,int userId)
        {
            var result = _userService.Update(userId,user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
