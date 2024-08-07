using System;
using Domain.Models;
using FluentValidation;
using Infrastructure.Interface;

namespace Application.Validators
{
	public class EmployeeValidator:AbstractValidator<EmployeeDTO>
	{
		private readonly ISCARepository _iscarepository;
        public EmployeeValidator(ISCARepository iscarepository)
		{
			_iscarepository = iscarepository;
			RuleFor(x => x.StoreNumber).Must(a => _iscarepository.GetStoreId(a) != null).WithMessage("Store does not exist");
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("Fill the Employee Name");
		}
	}
}

