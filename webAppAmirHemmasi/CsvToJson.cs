using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace System
{
	//static class for convert data from CSV to Json file
	public static class CsvToJson
	{
		/// <summary>
		/// make and send gas data as json 
		/// </summary>
		/// <returns></returns>
		async public static Task<List<dynamic>> MakeGasCsvToJson()
		{
			var csv = new List<string[]>();
			//read gas_bill_data.csv
			var lines = await File.ReadAllLinesAsync("gas_bill_data.csv");

			//find lines in gas_bill_data
			foreach (string line in lines)
				csv.Add(line.Split(','));

			//define return value type
			var data = new List<dynamic>();

			//read all line in file and fill data
			for (int i = 1; i < lines.Length; i++)
			{
				//make dynamic class for make json object 
				dynamic gasModel = new
				{
					id = csv[i][0],
					createdBy = csv[i][1],
					createdDate = csv[i][2],
					lastModifiedBy = csv[i][3],
					lastModifiedDate = csv[i][4],
					month = csv[i][5],
					year = csv[i][6],
					total_charge = csv[i][7],
					consumption = csv[i][8],
					blended_rate = csv[i][9],
					gas_charge = csv[i][10],
					demand_charge = csv[i][11],
					delivery_charge = csv[i][12],
					rate_riders = csv[i][13],
					municipal_franchisee_fee = csv[i][14],
					carbon_tax = csv[i][15],
					admin_fee = csv[i][16],
					building_id = csv[i][17]

				};
				//add dynamic class to data
				data.Add(gasModel);
			}
			//send data 
			return data;
		}
		/// <summary>
		/// make and send electricity data as json
		/// </summary>
		/// <returns></returns>
		async public static Task<List<dynamic>> MakeElectricityCsvToJson()
		{
			var csv = new List<string[]>();
			//read electricity_bill_data.csv
			var lines = await File.ReadAllLinesAsync("electricity_bill_data.csv");

			//find lines in gas_bill_data
			foreach (string line in lines)
				csv.Add(line.Split(','));

			//define return value type
			var data = new List<dynamic>();

			//read all line in file and fill data
			for (int i = 1; i < lines.Length; i++)
			{
				//make dynamic class for make json object 
				dynamic electricityModel = new
				{
					id = csv[i][0],
					createdBy = csv[i][1],
					createdDate = csv[i][2],
					lastModifiedBy = csv[i][3],
					lastModifiedDate = csv[i][4],
					month = csv[i][5],
					year = csv[i][6],
					total_charge = csv[i][7],
					consumption = csv[i][8],
					blended_rate = csv[i][9],
					electricity_rate = csv[i][10],
					energy_charge = csv[i][11],
					transaction_charge = csv[i][12],
					distribution_charge = csv[i][13],
					local_account_charge = csv[i][14],
					tax = csv[i][15],
					rate_riders = csv[i][16],
					building_id = csv[i][17]

				};
				//add dynamic class to data
				data.Add(electricityModel);
			}
			//send data 
			return data;
		}
		/// <summary>
		/// make and send water data as json
		/// </summary>
		/// <returns></returns>
		async public static Task<List<dynamic>> MakeWaterCsvToJson()
		{
			var csv = new List<string[]>();
			//read water_bill_data.csv
			var lines = await File.ReadAllLinesAsync("water_bill_data.csv");

			//find lines in gas_bill_data
			foreach (string line in lines)
				csv.Add(line.Split(','));

			//define return value type
			var data = new List<dynamic>();

			//read all line in file and fill data
			for (int i = 1; i < lines.Length; i++)
			{
				//make dynamic class for make json object 
				dynamic waterModel = new
				{
					id = csv[i][0],
					createdBy = csv[i][1],
					createdDate = csv[i][2],
					lastModifiedBy = csv[i][3],
					lastModifiedDate = csv[i][4],
					month = csv[i][5],
					year = csv[i][6],
					total_charge = csv[i][7],
					consumption = csv[i][8],
					blended_rate = csv[i][9],
					water_rate = csv[i][10],
					water_charge = csv[i][11],
					water_basic_service_charge = csv[i][12],
					total_water_charge = csv[i][13],
					sewer_rate = csv[i][14],
					sewer_charge = csv[i][15],
					sewer_basic_service_charge = csv[i][16],
					drianage_service_charge = csv[i][17],
					total_sewer_charge = csv[i][18],
					tax = csv[i][18],
					building_id = csv[i][19],
				};
				//add dynamic class to data
				data.Add(waterModel);
			}
			//send data 
			return data;
		}

		/// <summary>
		/// All data for use in plots tab
		/// </summary>
		/// <returns></returns>
		async public static Task<List<dynamic>> AllDataForPlot()
		{
			//get all water data(json)
			var waterData = await MakeWaterCsvToJson();
			//get all electricity Data(json)
			var electricityData = await MakeElectricityCsvToJson();
			//get all gas data(json)
			var gasData = await MakeGasCsvToJson();

			var data = new List<dynamic>();
			//add json to data
			data.Add("waterData-electricityData-gasData");
			data.Add(waterData);
			data.Add(electricityData);
			data.Add(gasData);
			//send data
			return data;
		}

	}

}
