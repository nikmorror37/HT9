using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9DopZadanie
{
    public class FinancialInvoice : ADocumentInfo
    {
        //public override int NumberOfDoc { get; set; }
        //public override DateTime DateOfDoc { get; set; }
        public decimal TotalAmountForMonth { get; set; }
        public int CodeOfDepartment { get; set; }

        public FinancialInvoice()
        {
            TotalAmountForMonth = 120500;
            CodeOfDepartment = 19;
        }

        public FinancialInvoice(int initNumberOfDoc, DateTime initDateOfDoc, decimal initTotalAmountForMonth, int initCodeOfDepartment) : base(initNumberOfDoc, initDateOfDoc)
        {
            TotalAmountForMonth = initTotalAmountForMonth;
            CodeOfDepartment = initCodeOfDepartment;
        }

        public override void ShowAdditionalInfo()
        {
            Console.WriteLine(
                $"Total Amount for Month: {TotalAmountForMonth} $, " +
                $"Code of department is {CodeOfDepartment}\n");
        }

    }
}
