using System;
using Application.Exceptions;
using Microsoft.AspNetCore.Mvc;
namespace Application.Middleware
{
	public class ErrorHandlingMiddleware
	{
		private readonly RequestDelegate _next;//gives control to provide httpcontext to the next component in the middleware
		public ErrorHandlingMiddleware(RequestDelegate requestDelegate)
		{
			_next=requestDelegate;

		}
		public async Task InvokeAsync (HttpContext httpContext)
		{
			try
			{
				await _next(httpContext);

			}
			catch(Exception ex)
			{
                var statusCode = ex switch
                {
                    BadRequestException=> StatusCodes.Status400BadRequest,
                    NotFoundException => StatusCodes.Status404NotFound,
                    _ => StatusCodes.Status500InternalServerError
                };
                var problemDetails = new ProblemDetails 
				{
					Status = statusCode,
					Title = "Server Error",
					Detail=ex.Message
				};
				httpContext.Response.StatusCode = (int)problemDetails.Status;
				await httpContext.Response.WriteAsJsonAsync(problemDetails);
            }
		}
		
	}
}

