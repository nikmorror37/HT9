using System.Text;

namespace HomeTask9DopZadanie
{
    internal class Program
    {        
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("-----DOP ZADANIE-----\n");

            ContractForSupplyOfGoods supplies1 = new ContractForSupplyOfGoods();
            ContractForSupplyOfGoods supplies2 = new ContractForSupplyOfGoods("Cars", 25, 4, new DateTime(2023, 02, 14));
            
            ContractEmployer employer1 = new ContractEmployer();
            ContractEmployer employer2 = new ContractEmployer("Aleksander", 5, new DateTime(2023, 02, 08), new DateTime(2023, 11, 15));
            
            FinancialInvoice finvoice1 = new FinancialInvoice();
            FinancialInvoice finvoice2 = new FinancialInvoice(6, new DateTime(2023, 03, 01), 560000, 26402);

            supplies1.ShowInfoOfDocument();
            supplies2.ShowInfoOfDocument();
            employer1.ShowInfoOfDocument();
            employer2.ShowInfoOfDocument();
            finvoice1.ShowInfoOfDocument();
            finvoice2.ShowInfoOfDocument();

            Console.WriteLine("------------------------------\n");

            IRegister register = new Register(10);
            register.SaveDocInRegister(supplies1); //1
            register.SaveDocInRegister(employer1); //2
            register.SaveDocInRegister(finvoice1); //3
            register.SaveDocInRegister(supplies2); //4
            register.SaveDocInRegister(supplies2); //5
            register.SaveDocInRegister(supplies1); //6
            register.SaveDocInRegister(supplies2); //7
            register.SaveDocInRegister(employer2); //8
            register.SaveDocInRegister(supplies1); //9
            register.SaveDocInRegister(finvoice2); //10
            register.SaveDocInRegister(employer1); //11
            register.SaveDocInRegister(supplies2); //12

            Console.WriteLine("\n------------------------------\n");

            register.ShowInfoOfDocument(employer2);

            Console.ReadKey();
        }
    }
}