using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Build.Framework;

public static class MyFunction
{
	[FunctionName("HelloAzure")]
	public static async Task<IActionResult> Run(
		[HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest httpRequest)
	{
		return (ActionResult) new OkObjectResult($"Hello, Azure");
	}
}
