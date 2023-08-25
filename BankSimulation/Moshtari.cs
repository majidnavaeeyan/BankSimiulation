using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation
{
    public class Moshtari
    {

        //شماره ای که سیستم برای انتظار در صف به مشتری اختصاص می دهد

        private  int _moshtariID ;

        public int MoshtariID { get { return _moshtariID; } set { _moshtariID = value; } }

        public Moshtari(int MoshtariID)
        {
            this.MoshtariID = MoshtariID;
        }

    }

}
