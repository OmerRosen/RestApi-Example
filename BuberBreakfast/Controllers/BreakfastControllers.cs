using BuberBreakfast.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

[ApiController]
public class BreakfastControllers : ControllerBase{
    [HttpPost("/breakfests")]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request){
        return Ok(request);
    }

    [HttpGet("breakfests/{id:guid}")]
    public IActionResult GetBreakfast(Guid id){
        return Ok(id);
    }

    [HttpPut("breakfests/{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request){
        return Ok(request);
    }

    [HttpDelete("breakfests/{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id){
        return Ok(id);
    }
}