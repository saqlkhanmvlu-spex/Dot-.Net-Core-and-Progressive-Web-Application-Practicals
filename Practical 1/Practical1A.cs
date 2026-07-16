HomeController.CS :- 
using System.Web;
using Microsoft.AspNetCore.Mvc;
using MVCAdd.Models;
namespace MVCAdd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new AddModel());
        }
        [HttpPost]
        public ActionResult Index(AddModel m)
        {
            m.Result = m.A + m.B;
            return View(m);
        }
    }
}

Modelmvc.cs :- 
namespace MVCAdd.Models
{
    public class AddModel
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Result { get; set; }
    }
}

Index.cshtml :- 
@model MVCAdd.Models.AddModel
<h2>Add Two Numbers</h2>
@using (Html.BeginForm())
{
    @Html.TextBoxFor(m => m.A)
    <br />
    <br />
    @Html.TextBoxFor(m => m.B)
    <br />
    <br />
    <input type="submit" value="Add" />
    <br />
    <br />
  <b>Result = @Model.Result</b>
}
