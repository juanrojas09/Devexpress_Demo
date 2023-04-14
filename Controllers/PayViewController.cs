using DevExtremeAspNetCoreApp3.Models;
using DevExtremeAspNetCoreApp3.Reports;
using Microsoft.AspNetCore.Mvc;

namespace DevExtremeAspNetCoreApp3.Controllers
{
    [Route("api/[controller]")]
    public class PayViewController : Controller
    {

     
        public IActionResult PayView2(DateTime startDate1, DateTime endDate1)
        {
            //instancio el reporte para setearle los valores y datos
            var xXtraReport3 = new XtraReport3();
            xXtraReport3.Parameters["startDate1"].Value = startDate1;
            xXtraReport3.Parameters["dateEnd1"].Value = endDate1;
            xXtraReport3.Parameters["startDate1"].Visible = false;
            xXtraReport3.Parameters["dateEnd1"].Visible = false;
            //ViewBag.Report = xtraReport3;
            //instancio el modelo a pasar a la vista y le asigno los valores correspondientes
            var payReport = new PayReportModel()
            {
                startDate = startDate1,
                endDate = endDate1
                
            };


            ViewBag.startDate = startDate1;
            ViewBag.endDate = endDate1;
            ViewBag.XXtraReport3 = xXtraReport3;


            return View(payReport);
        }

    
    }
}
