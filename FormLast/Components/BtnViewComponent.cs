using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;

namespace FormLast.Components
{
    public class BtnViewComponent:ViewComponent

    {
        // Obje çağırılmıyor
        
        public BtnViewComponent()
        {
                
        }

        public async Task<IViewComponentResult> InvokeAsync(BtnModel btnModel)
        {

            return View("Default",btnModel);
        }


        public  async Task<IViewComponentResult> GetButton()
        {
            return await Task.FromResult((IViewComponentResult)View("Btn", new BtnModel()));
        }



    }

    public class BtnModel
    {
        public string Class { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }

        public BtnModel(string @class= "form-group", string value="Create", string type="submit")
        {
            Class = @class;
            Value = value;
            Type = type;
        }

        

    }
    public class HomeController : Controller
    {
        public IActionResult GetHelloWorld()
        {
            return ViewComponent("HelloWorld");
        }
    }

    public class HelloWorldViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new string[]
            {
            "Hello", "from", "the", "view", "component."
            };

            return View("Default", model);
        }
    }
}
