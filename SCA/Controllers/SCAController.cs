using System;
using Application.Exceptions;
using Domain.Interface;
using Domain.Models;
using FluentValidation;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SCAController:ControllerBase
	{
		private readonly ISCAService _iscaservice;
		private readonly IValidator<EmployeeDTO> _validator;
		public SCAController(ISCAService iscaservice,IValidator<EmployeeDTO> validator)
		{
			_iscaservice = iscaservice;
			_validator = validator;
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
			var validator = _validator.Validate(employeedto);
			if (validator == null)
			{
				var result = _iscaservice.CreateEmployee(employeedto);
				return result;
			}
			else
			{
				var errorMessage="";
				foreach(var x in validator.Errors)
				{
					errorMessage += x.ErrorMessage;
				}
				throw new BadRequestException(errorMessage);
			}


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

