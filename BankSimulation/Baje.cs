using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.Windows.Forms;

namespace BankSimulation
{
    public class Baje
    {

        public int BajeNumber { get; set; }

        public String EmployeeName { get; set; }


        //Status = True => Darhalekar
        //Status = False => Bikar
        public bool Status { get; set; }

        public PictureBox Palce { get; set; }

        public Baje()
        {
            this.Status = false;
            this.EmployeeName = string.Empty;
            this.BajeNumber = 0;

        }

        public Baje(bool status , int bajeNumber , string employeeName  /*, PictureBox place */)
        {
            this.Status = status;
            this.EmployeeName = employeeName;
            this.BajeNumber = bajeNumber;
            //this.Palce = place;

        }



    }
}
