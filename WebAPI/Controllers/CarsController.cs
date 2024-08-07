﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll() 
        { 
            var result= _carService.GetAll();
            if (result.Success)
            { 
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id) 
        { 
            var result = _carService.GetById(id);
            if (result.Success) 
            {
                return Ok(result);    
            }
            return BadRequest(result);
        }
        [HttpGet("getcardetail")]
        public IActionResult GetCarDetail() 
        { 
            var result = _carService.GetCarDetail();
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcarsbybrand")]
        public IActionResult GetCarsByBrandId(int brandId) 
        {
            var result = _carService.GetCarsByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcarsbycolor")]
        public IActionResult GetCarsByColorId(int colorId) 
        {
            var result = _carService.GetCarsByColorId(colorId);
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Car car) 
        { 
            var result = _carService.Add(car);
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deletebyid")]
        public IActionResult DeleteById(int id) 
        {
            var result = _carService.DeleteById(id);
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Car car) 
        { 
            var result = _carService.Update(car);
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
