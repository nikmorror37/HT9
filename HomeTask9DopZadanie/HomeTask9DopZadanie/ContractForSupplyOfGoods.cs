using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9DopZadanie
{
    public class ContractForSupplyOfGoods : ADocumentInfo
    {
        //public override int NumberOfDoc { get; set; }
        //public override DateTime DateOfDoc { get; set; }
        public string TypeOfGoods { get; set; }
        public int AmountOfGoods { get; set; }

        public ContractForSupplyOfGoods()
        {
            TypeOfGoods = "Books";
            AmountOfGoods = 1200;
        }
        public ContractForSupplyOfGoods(string initTypeOfGoods, int initAmountOfGoods, int initNumberOfDoc, DateTime initDateOfDoc) : base(initNumberOfDoc, initDateOfDoc)
        {
            TypeOfGoods = initTypeOfGoods;
            AmountOfGoods = initAmountOfGoods;
        }
        public override void ShowAdditionalInfo()
        {
            Console.WriteLine(
                $"Type of Goods: {TypeOfGoods}, " +
                $"Amount of Goods: {AmountOfGoods}\n");
        }
    }
}
