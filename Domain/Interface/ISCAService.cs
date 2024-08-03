using System;
using Domain.Models;

namespace Domain.Interface
{
	public interface ISCAService
	{
		public string CreateStore(StoreDTO store);
		public string CreateCountry(CountryDTO country);
	}
}

