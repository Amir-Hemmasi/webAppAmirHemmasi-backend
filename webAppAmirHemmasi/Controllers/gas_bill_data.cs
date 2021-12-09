using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace webAppAmirHemmasi.Controllers
{
	[Route("api/[controller]")]
	[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]

	[ApiController]
	public class gas_bill_data : ControllerBase
	{
		// GET: api/gas_bill_data
		//Get data only for gas tab
		[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
		[HttpGet]
		async public Task<IActionResult> Get()
		{
			try
			{
				return Ok(await System.CsvToJson.MakeGasCsvToJson());

			}
			catch (Exception)
			{

				return BadRequest();
			}
		}
		
	}
}
