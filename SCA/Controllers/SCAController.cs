using System;
using Domain.Interface;
using Domain.Models;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SCAController:ControllerBase
	{
		private readonly ISCAService _iscaservice;

		public SCAController(ISCAService iscaservice)
		{
			_iscaservice = iscaservice;
		}
		[HttpPut]
		public string CreateCountry(CountryDTO countrydto)
		{
			var result=_iscaservice.CreateCountry(countrydto);
			return result;
			
		}
		[HttpHead]
		public string CreateStore(StoreDTO storedto)
		{
			var result = _iscaservice.CreateStore(storedto);
			return result;
		}
		[HttpPost]
		public string CreateEmployee(EmployeeDTO employeedto)
		{
			var result = _iscaservice.CreateEmployee(employeedto);
			return result;

		}
		[HttpGet]
		public List<EmployeeDTO> GetEmployeeData(int storenumber)
		{
			try
			{
				return _iscaservice.GetEmployeeData(storenumber);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

	}
}

