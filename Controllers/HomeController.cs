using Microsoft.AspNet.Mvc;
using System.Threading.Tasks;

namespace MicroServiceB.Controllers
{
	public class HomeController : Controller
	{
		public async Task<string> Index()
		{
			await Task.Delay(100).ConfigureAwait(false);

			return "hello";
		}

		public async Task<IActionResult> Json()
		{
			await Task.Delay(100).ConfigureAwait(false);

			return Json(new { data = "hello" });
		}
	}
}