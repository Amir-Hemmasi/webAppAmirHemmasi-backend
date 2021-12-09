using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webAppAmirHemmasi.Controllers
{
	[Route("api/[controller]")]
	[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]

	[ApiController]
	public class AllData : ControllerBase
	{
		// GET: api/AllData
		//Get all data from gas , electricity and water for plots tab
		[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
		[HttpGet]
		async public Task<IActionResult> Get()
		{
			try
			{
				return Ok(await System.CsvToJson.AllDataForPlot());

			}
			catch (Exception)
			{

				return BadRequest();
			}
		}
	}
}
