using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;

namespace FormLast.Components
{
    public class InputTextAreaViewComponent : ViewComponent
    {
     

        public async Task<IViewComponentResult> InvokeAsync(InputTextAreaModel btnModel)
        {

            return View("Index", btnModel);
        }

       
    }
    public class InputTextAreaModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }


        public InputTextAreaModel(string id = "Text", string name = "Text", string type = "Text")
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}
