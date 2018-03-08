using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace test.Controllers
{
	public class UsersController : Controller
	{
		[HttpGet]
		[Route("index"), Route("")]
		public string Index()
		{	//return a string to the page
			return "hello world.  This is where we are. asdf";
		}

		[HttpGet]
		[Route("userdata")]
		public string UserData()
		{	//return a string to the page
			return "Chuck Kang.  I am cool";
		}

		[HttpGet]
		[Route("getjson")]
		public JsonResult UserName()
		{	// use a dictionary to return json
			Dictionary<string, string> person = new Dictionary<string, string>();
			person.Add("name", "Chuck");
			person.Add("last", "Kang");

			return Json(person);
		}

		[HttpGet]
		[Route("getanon")]
		public JsonResult GetAnon()
		{	//use of anonyous types
			var anon = new { first = "Chuck", last = "kang", email ="whatever"};

			return Json(anon);
		}

		[HttpGet]
		[Route("{first}/{last}/{age}/{color}")]
		public JsonResult ReturnParams(string first, string last, int age, string color)
		{   // create a route that returns a json object which pulls data from http://localhost/Tim/Toolmam/42/Brown
			Dictionary<string, object> user = new Dictionary<string, object>();
			user.Add("first", first);
			user.Add("last", last);
			user.Add("age", age);
			user.Add("color", color);
			return Json(user);
		}
	}
}