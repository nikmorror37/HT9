namespace HomeTask9DopZadanie
{
    internal class Program
    {        
        public static void Main(string[] args)
        {
            Console.WriteLine("-----DOP ZADANIE-----\n");

            ContractForSupplyOfGoods supplies1 = new ContractForSupplyOfGoods();
            ContractEmployer employer1 = new ContractEmployer();
            FinancialInvoice finvoice1 = new FinancialInvoice();
            supplies1.ShowInfoOfDocument();
            employer1.ShowInfoOfDocument();            
            finvoice1.ShowInfoOfDocument();


        }
    }
}