using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static HomeTask9DopZadanie.Register;

namespace HomeTask9DopZadanie
{
    public class Register : IRegister
    {

        private int positionOfTheLastDocument = 0;
        private IDocument[] documents = new IDocument[10];
        public Register(int sizeOfRegister)
        {
            documents = new IDocument[sizeOfRegister];
        }
        public void SaveDocInRegister(IDocument doc)
        {
            if (positionOfTheLastDocument == documents.Length - 1)
            {
                Console.WriteLine($"Максимальный размер регистра достигнут ({documents.Length})");
                return;
            }

            documents[positionOfTheLastDocument] = doc;
            positionOfTheLastDocument++;
        }
        public void ShowInfoOfDocument(IDocument doc)
        {
            doc.ShowInfoOfDocument();
        }

    }

}
