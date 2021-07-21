
namespace AppPatronesDiseño.Patrones_estructurales._5.Facade
{
    public class FacadeReport
    {
        private ProcessReport _ProcessReport;

        /// <summary>
        /// Constructor
        /// </summary>
        public FacadeReport(ProcessReport processReport)
        {
            _ProcessReport = processReport;
        }

        public void GenerateReport()
        {
            _ProcessReport.GetDataFromBD();
            _ProcessReport.ProcessData();
            _ProcessReport.FormatData();
            _ProcessReport.ReturnData();
        }
    }
}