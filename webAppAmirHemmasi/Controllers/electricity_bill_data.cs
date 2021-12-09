using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace webAppAmirHemmasi.Controllers
{
	[Route("api/[controller]")]
	[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
	[ApiController]
	public class electricity_bill_data : ControllerBase
	{

		// GET: api/electricity_bill_data
		//Get data only for electricity tab
		[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
		[HttpGet]
		async public Task<IActionResult> Get()
		{
			try
			{
				return Ok(await System.CsvToJson.MakeElectricityCsvToJson());

			}
			catch (Exception ex)
			{

				return BadRequest(ex.Message);
			}
		}

	}
}
