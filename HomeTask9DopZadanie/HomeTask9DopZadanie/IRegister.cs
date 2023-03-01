using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9DopZadanie
{
    public interface IRegister
    {
        void SaveDocInRegister(IDocument doc);
        void ShowInfoOfDocument(IDocument doc);
    }
}
