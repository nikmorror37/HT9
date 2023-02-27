using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9DopZadanie
{
    public class Register : IDocument
    {
        //public int numArrIndex;
        public int NumArrIndex { get; set; }
        public Document[] documents = new Document[10];
        public Register() 
        { 
            NumArrIndex = 0;
        }
        public void SaveDocInRegister(Document doc) 
        {
            documents[NumArrIndex] = doc;
            NumArrIndex++;
        }
        public void ShowInfoOfDocument(Document doc) 
        {
        
        }


    }
}
