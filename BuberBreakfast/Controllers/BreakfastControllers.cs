using BuberBreakfast.Contracts;
using BuberBreakfast.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("breakfests")]
public class BreakfastControllers : ControllerBase{
    [HttpPost("")]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request){
        Breakfast breakfast = new Breakfast(Guid.NewGuid() ,
                        request.Name ,
                        request.Description ,
                        request.StartDateTime ,
                        request.EndDateTime ,
                        DateTime.UtcNow,
                        request.Savory ,
                        request.Sweet);
        
        // ToDo: Savo to database

        GetBreakfastReesponse response = new GetBreakfastReesponse(breakfast.Id ,
                        breakfast.Name ,
                        breakfast.Description ,
                        breakfast.StartDateTime ,
                        breakfast.EndDateTime ,
                        breakfast.LastModifiedDateTime,
                        breakfast.Savory ,
                        breakfast.Sweet);

        
        return CreatedAtAction(nameof(CreateBreakfast),
        value: response);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id){
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request){
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id){
        return Ok(id);
    }
}