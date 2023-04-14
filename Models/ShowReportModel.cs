using DevExpress.XtraReports.UI;
using DevExtremeAspNetCoreApp3.Reports;

namespace DevExtremeAspNetCoreApp3.Models
{
    public class ShowReportModel
    {
        public string Name { get; set; }
        public XtraReport2 Reporte { get; set; }
    }
}
