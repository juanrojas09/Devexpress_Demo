//using DevExpress.XtraReports.UI;
//using System.Web;

//namespace DevExtremeAspNetCoreApp3.Helpers
//{
//    public class ClaCustomReportStorageWebExtension
//    {
//        public override byte[] GetData(string url)
//        {
//            try
//            {
//                // Parse the string with the report name and parameter values.
//                string[] parts = url.Split('?');
//                string reportName = parts[0];
//                string parametersQueryString = parts.Length > 1 ? parts[1] : String.Empty;

//                // Create a report instance.
//                XtraReport report = null;

//                if (Directory.EnumerateFiles().
//                    Select(Path.GetFileNameWithoutExtension).Contains(reportName))
//                {
//                    byte[] reportBytes = File.ReadAllBytes(Path.Combine(reportDirectory, reportName + FileExtension));
//                    using (MemoryStream ms = new MemoryStream(reportBytes))
//                        report = XtraReport.FromStream(ms);
//                }

//                if (report != null)
//                {
//                    // Apply the parameter values to the report.
//                    var parameters = HttpUtility.ParseQueryString(parametersQueryString);

//                    foreach (string parameterName in parameters.AllKeys)
//                    {
//                        report.Parameters[parameterName].Value = Convert.ChangeType(
//                            parameters.Get(parameterName), report.Parameters[parameterName].Type);
//                    }

//                    // Disable the Visible property for all report parameters
//                    // to hide the Parameters Panel in the viewer.
//                    foreach (var parameter in report.Parameters)
//                    {
//                        parameter.Visible = false;
//                    }

//                    // If you do not hide the panel, disable the report's RequestParameters property.
//                    // report.RequestParameters = false;

//                    using (MemoryStream ms = new MemoryStream())
//                    {
//                        report.SaveLayoutToXml(ms);
//                        return ms.ToArray();
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                throw Exception(ex);
//            }
//        }
//}
