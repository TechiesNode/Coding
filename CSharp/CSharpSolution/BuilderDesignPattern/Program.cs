using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    //Using the following report product class, we can configure different types of product.
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportFooter { get; set; }
        public string ReportContent { get; set; }

        public void DisplayReport()
        {
            Console.WriteLine($"ReportType : {ReportType}");
            Console.WriteLine($"Header : {ReportHeader}");
            Console.WriteLine($"Content : {ReportContent}");
            Console.WriteLine($"Footer : {ReportFooter}");
        }
    }
    //Creating the Abstract Builder Class.
    //The builder abstract class specifies methods for creating the different parts of
    //product objects

    public abstract class ReportBuilder
    {
        protected Report reportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportFooter();
        public abstract void SetReportContent();
        public void CreateNewReport()
        { 
            reportObject = new Report();
        }
        public Report GetReport()
        { 
            return reportObject;
        }
    }

    //Create Concrete Builder Classes.

    public class ExcelReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel Content Section";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }
    }

    //The Following Concrete Builder Implemented the ReportBuilder Abstract Class and 
    //Provide specific implementations of the steps for Creating PDFReport.
    public class PDFReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Content Section";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "PDF";
        }
    }

    //Creating Director
    //The Director is only reposnible for executing the building steps in a particular order.
    //It is helpful when producing products according to a specific order or configuration
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        { 
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();
            return reportBuilder.GetReport();
        }
    }

    //Client Code
    internal class Program
    {
        static void Main(string[] args)
        {
            PDFReport pdfReport = new PDFReport();
            ReportDirector reportDirector = new ReportDirector();
            Report report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();
            Console.WriteLine("--------------------------");
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();
            Console.ReadKey();
        }
    }
}
