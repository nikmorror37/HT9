using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9DopZadanie
{
    public abstract class ADocumentInfo : IDocument
    {
        public virtual int NumberOfDoc { get; set; }
        public virtual DateTime DateOfDoc { get; set; }

        public ADocumentInfo() 
        {
            NumberOfDoc = 3;
            DateOfDoc = new DateTime(2023, 01, 26);
        }

        public ADocumentInfo(int initNumberOfDoc, DateTime initDateOfDoc)
        {
            NumberOfDoc = initNumberOfDoc;
            DateOfDoc = initDateOfDoc;
        }
        public abstract void ShowAdditionalInfo();
        public void ShowInfoOfDocument()
        {
            Console.WriteLine($"Number of Document: {NumberOfDoc}, " +
                $"Date of Creation of Document: {DateOfDoc.ToShortDateString()}, ");
            ShowAdditionalInfo();
        }
    }
    
}
