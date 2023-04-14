using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DevExtremeAspNetCoreApp3.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using DevExtremeAspNetCoreApp3.Reports;

namespace DevExtremeAspNetCoreApp3.Controllers {

    [Route("api/[controller]")]
    public class SampleDataController : Controller {

        //[HttpGet]
        //public object Get(DataSourceLoadOptions loadOptions) {
        //    return DataSourceLoader.Load(SampleData.Orders, loadOptions);
        //}

        [HttpGet]
        public ActionResult Viewer2(string strParam)
        {
            //string Name = strParam;
            //viewbar y le mando un avariable por parametro a la vista , puedo mandar un viewbag o una entidad entera
            //viewbag
            //var report = new XtraReport2();

            //report.Parameters["Nombre"].Value = ModelRep.Name;
            //report.Parameters["Nombre"].Visible = false;
             ViewBag.Name = strParam;


            //modelo
            var ModelRep = new ShowReportModel();
           

          


            return View(ModelRep);
        }
  

    }
}