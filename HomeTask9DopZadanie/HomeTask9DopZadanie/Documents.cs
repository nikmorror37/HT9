using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9DopZadanie
{
    public abstract class ADocumentInfo
    {
        public abstract int NumberOfDoc { get; set; }
        public abstract DateTime DateOfDoc { get; set; }
    }
    public class ContractForSupplyOfGoods : ADocumentInfo, IDocument
    {
        public override int NumberOfDoc { get; set; }
        public override DateTime DateOfDoc { get; set; }
        public string TypeOfGoods { get; set; }
        public int AmountOfGoods { get; set; }
        
        public ContractForSupplyOfGoods() 
        {
            NumberOfDoc = 1;
            DateOfDoc = new DateTime(2023, 01, 26);
            TypeOfGoods = "Books";
            AmountOfGoods = 1200;
        }
        public ContractForSupplyOfGoods(int initNumberOfDoc, DateTime initDateOfDoc, string initTypeOfGoods, int initAmountOfGoods)
        {
            NumberOfDoc = initNumberOfDoc;
            DateOfDoc = initDateOfDoc;   
            TypeOfGoods = initTypeOfGoods;
            AmountOfGoods = initAmountOfGoods;
        }
        public void ShowInfoOfDocument()
        {
            Console.WriteLine($"Number of Document: {NumberOfDoc}, " +
                $"Date of Creation of Document: {DateOfDoc.ToShortDateString()}, " +
                $"Type of Goods: {TypeOfGoods}, " +
                $"Amount of Goods: {AmountOfGoods}");
        }
    }
    public class ContractEmployer : ADocumentInfo, IDocument
    {
        public override int NumberOfDoc { get; set; }
        public override DateTime DateOfDoc { get; set; }

        public DateTime DateExpireOfContract { get; set; }
        public string NameOfEmployer { get; set; }

        public ContractEmployer()
        {
            NumberOfDoc = 2;
            DateOfDoc = new DateTime(2022, 12, 01);
            DateExpireOfContract = new DateTime(2023, 09, 01);
            NameOfEmployer = "Ivan";
        }

        public ContractEmployer(int initNumberOfDoc, DateTime initDateOfDoc, DateTime initDateExpireOfContract, string initNameOfEmployer) 
        {
            NumberOfDoc= initNumberOfDoc;
            DateOfDoc = initDateOfDoc;
            DateExpireOfContract= initDateExpireOfContract;
            NameOfEmployer= initNameOfEmployer;
        }
        public void ShowInfoOfDocument() 
        {
            Console.WriteLine($"Number of Document: {NumberOfDoc}, " +
                $"Date of Creation of Document: {DateOfDoc.ToShortDateString()}, " +
                $"Date of Expiration of Employer's Contract {DateExpireOfContract.ToShortDateString()}, " +
                $"Name of Employer is {NameOfEmployer}");
        }
    }
    public class FinancialInvoice : ADocumentInfo, IDocument
    {
        public override int NumberOfDoc { get; set; }
        public override DateTime DateOfDoc { get; set; }
        public int TotalAmountForMonth { get; set; }
        public int CodeOfDepartment { get; set; }

        public FinancialInvoice()
        {
            NumberOfDoc = 3;
            DateOfDoc = new DateTime(2023, 02, 26);
            TotalAmountForMonth = 120500;
            CodeOfDepartment = 19;
        }
        
        public FinancialInvoice(int initNumberOfDoc, DateTime initDateOfDoc, int initTotalAmountForMonth, int initCodeOfDepartment)
        {
            NumberOfDoc = initNumberOfDoc;
            DateOfDoc = initDateOfDoc;
            TotalAmountForMonth = initTotalAmountForMonth;
            CodeOfDepartment = initCodeOfDepartment;
        }

        public void ShowInfoOfDocument()
        {
            Console.WriteLine($"Number of Document: {NumberOfDoc}, " +
                $"Date of Creation of Document: {DateOfDoc.ToShortDateString()}, " +
                $"Total Amount for Month: {TotalAmountForMonth}, " +
                $"Code of department is {CodeOfDepartment}");
        }

    }


}
