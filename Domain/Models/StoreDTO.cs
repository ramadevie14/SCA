using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace Domain.Models
{
	public class StoreDTO
	{
		public StoreDTO()
		{
		}
        
     
        public int StoreNumber { get; set; }
        public string StoreName { get; set; }
        public string CountryCode { get; set; }
        
    }
}

