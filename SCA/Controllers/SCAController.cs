using System;
using Domain.Interface;
using Domain.Models;
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
		[HttpPost]
		public string CreateStore(StoreDTO storedto)
		{
			var result = _iscaservice.CreateStore(storedto);
			return result;
		}
		
	}
}

