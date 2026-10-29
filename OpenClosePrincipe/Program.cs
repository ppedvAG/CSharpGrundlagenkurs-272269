using System.Net.Http.Headers;

namespace OpenClosePrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    public class Employee
    {
        //Aufgabe 1: Die Struktur des Employee (Beschreibung) 
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    #region BadSample
    public class  BadEmployeeReportGenerator
    {
        public void GenerateEmployeeReport(Employee employee, ReportType reportType)
        {
            if (reportType == ReportType.PDFReport)
            {

                //Greifen wird auf eine PDF-Library. Und nur hier, können wir PDF Reports erstellen, Wasserzeichen setzen, Digitale Signatur, Templates laden, Ausgabeverzeichnis definieren
                Console.WriteLine("Erstelle PDFReport");
            }
            else if (reportType == ReportType.CrystalReport)
            {
                //... Geschätz 400-600 Zeilen Code
            }
            else if (reportType == ReportType.FastReport)
            {
                //...
            }
            else if (reportType == ReportType.ABCReport)
            {
                //...
            }
            else
                Console.WriteLine("ReportTyp wurde nicht gefunden");
        }
    }

    public enum ReportType { PDFReport, CrystalReport, FastReport, ABCReport}
    #endregion


    #region Good Sample - Variante 1

    //Open-Part

    public abstract class EmployeeGeneratorBase
    {
        public abstract void GenerateReport(Employee employee);

        public void EineFesteLogik()
        {
            //Diese Logik muss ja für jede Vererbte Klasse relevant sein. 
        }


    }


    //Close-Part 
    public class PDFReportGenerator : EmployeeGeneratorBase
    {
        //... Alle weiteren PDF-Lastigen Variablen oder Methoden haben eine Klasse gefunden. 

        public override void GenerateReport(Employee employee)
        {
            //Erstelle ein PDF Report
        }
    }


    public class CrystalReportGenerator : EmployeeGeneratorBase
    {
        //... Alle weiteren CrystalReport-Lastigen Variablen oder Methoden haben eine Klasse gefunden. 

        public override void GenerateReport(Employee employee)
        {
            //Erstelle ein CrystalReport Report
        }
    }

    ///.....



    public class ReportGeneratorView
    {
        public void GenerateReport(Employee employee, ReportType type)
        {
            EmployeeGeneratorBase employeeGenerator = null;

            if (type == ReportType.PDFReport)
            {
                employeeGenerator = new PDFReportGenerator();
            }
            else if (type == ReportType.CrystalReport)
            {
                employeeGenerator = new CrystalReportGenerator();
            }


            if (employeeGenerator != null) 
            {
                employeeGenerator.GenerateReport(employee);
            }

            //Gleiche wie employeeGenerator != null und danach GenerateReport ausführen. 
            employeeGenerator?.GenerateReport(employee);
        }
    }
    #endregion

    #region Good Sample - Variante 2

    public interface IReportGenerator
    {
        void GenerateReport(Employee employee);
    }

    public class FastReportGenerator : IReportGenerator
    {
        public void GenerateReport(Employee employee)
        {
           //ERstelle ein FastReport
        }

        public void DieseMethodeWirInIReportGeneratorNichtAngeboten()
        {

        }
    }

    public class AbcReportGenerator : IReportGenerator
    {
        public void GenerateReport(Employee employee)
        {
            // Erstelle ein ABC Report
        }
    }


    public class ReportService
    {
        public void GenerateReport(Employee em, ReportType type)
        {
            IReportGenerator reportGenerator = null;

            if (type == ReportType.FastReport)
            {
                reportGenerator = new FastReportGenerator();
            }
            else if (type == ReportType.ABCReport)
            {
                reportGenerator = new AbcReportGenerator();
            }

            reportGenerator?.GenerateReport(em);
        }
    }

    #endregion


}
