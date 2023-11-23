﻿// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;
// using Parking_Intelligence_Api.Schemas.buy;
// using Parking_Intelligence_Api.Services.Buy;
//
// namespace Parking_Intelligence_Api.Controllers.Buy;
//
// [ApiController]
// [Route("v1")]
// public class BuyUserController : ControllerBase
// {
//     [HttpGet]
//     [Route("user/buys")]
//     [Authorize]
//     public Task<IActionResult> ListingAllBuys([FromQuery] GetBuySchema prop)
//     {
//         var service = new BuysUserServices();
//
//         var status = service.ListingPurchases(prop);
//
//         if (status is null) return Task.FromResult<IActionResult>(NotFound("error, unable to execute the get command"));
//
//         return Task.FromResult<IActionResult>(Ok(status));
//     }
// }