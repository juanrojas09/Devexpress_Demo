using DevExtremeAspNetCoreApp3.Reports;

namespace DevExtremeAspNetCoreApp3.Models
{
	public class PayReportModel
	{
		public DateTime startDate { get; set; }
		public DateTime endDate { get; set; }
		
		public XtraReport3 xtraReport3 { get; set; }
	}
}
