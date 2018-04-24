using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public struct Person
    {
        public Label l1;
        public Label l2;
        public Label l3;
        public Button b1;
        public Button b2;

        public int nomer;
        public String coord;
        public String coord2;
        //Dobavit polya
        public String x1;
        public String y1;
        public String x2;
        public String y2;
        public String adress;
        public String time1;
        public String time2;
        public String sprite;
        public String moveside;
        public String charname;
        public String height;
        public String width;
        public String circles;

        public static string PersonName(int nomer)
        {
            return "per" + nomer.ToString();
        }
    }
}
