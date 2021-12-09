using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace webAppAmirHemmasi.Controllers
{
	[Route("api/[controller]")]
	[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]

	[ApiController]
	public class water_bill_data : ControllerBase
	{
		// GET: api/water_bill_data
		//Get data only for water tab
		[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
		[HttpGet]
		async public Task<IActionResult> Get()
		{
			try
			{
				return Ok(await System.CsvToJson.MakeWaterCsvToJson());

			}
			catch (Exception)
			{

				return BadRequest();
			}
		}
	}
}
