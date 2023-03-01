using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9DopZadanie
{
    public class ContractEmployer : ADocumentInfo
    {
        //public override int NumberOfDoc { get; set; }
        //public override DateTime DateOfDoc { get; set; }

        public DateTime DateExpireOfContract { get; set; }
        public string NameOfEmployer { get; set; }

        public ContractEmployer()
        {
            DateExpireOfContract = new DateTime(2023, 09, 01);
            NameOfEmployer = "Ivan";
        }

        public ContractEmployer(string initNameOfEmployer, int initNumberOfDoc, DateTime initDateOfDoc, DateTime initDateExpireOfContract) : base(initNumberOfDoc, initDateOfDoc)
        {
            DateExpireOfContract = initDateExpireOfContract;
            NameOfEmployer = initNameOfEmployer;
        }
        public override void ShowAdditionalInfo()
        {
            Console.WriteLine(
                $"Name of Employer is {NameOfEmployer}, " +
                $"Date of Expiration of Employer's Contract {DateExpireOfContract.ToShortDateString()}\n");
        }
    }
}
