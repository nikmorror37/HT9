using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9DopZadanie
{
    public interface IDocument
    {
        public void ShowInfoOfDocument() { }

        public int NumberOfDoc { get; set; }
        public DateTime DateOfDoc { get; set; }

    }
}
