﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Parking_Intelligence_Api.Schemas;
using Parking_Intelligence_Api.Services.Vehicle;

namespace Parking_Intelligence_Api.Controllers.Vehicle;

[ApiController]
[Route("v1")]
public class DeleteVehiclesController : ControllerBase
{
    [HttpDelete]
    [Route("user/vehicle/delete")]
    [Authorize]
    public Task<IActionResult> DeleteOneMoreVehicles([FromBody] DeleteVehicleSchema user)
    {
        var services = new DeleteVehiclesServices();

        var status = services.DeleteVehiclesService(user).Result;

        if (status is false)
            return Task.FromResult<IActionResult>(NotFound("something wrong, maybe this vehicle doesn't exist"));

        return Task.FromResult<IActionResult>(Ok("vehicle successfully deleted"));
    }
}