using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Circle
    {
        public static void CreatePerson(string filename, string name, Person p)
        {
            File.AppendAllText(filename, "    Person " + name + ";" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".texture = txLoadImage(\"Pictures\\\\Personaj.bmp\");" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".x = 50;" + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".y = 50;" + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".angle = 0;" + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".nomer_kadra = 0;" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
        }

        public static void MovePerson(string filename, string name, Person p)
        {
            File.AppendAllText(filename, "        " + name + ".angle++" + Environment.NewLine);
            File.AppendAllText(filename, "        " + name + ".x = 500 + 200 * cos (" + name + ".angle / 10);" + Environment.NewLine);
            File.AppendAllText(filename, "        " + name + ".y = 300 + 200 * sin (" + name + ".angle / 10);" + Environment.NewLine);
            File.AppendAllText(filename, "        txTransparentBlt(txDC(), " + name + ".x, " + name + ".y, " + p.width + "," + p.height + "," + name + ".texture, " + p.width + "/" + p.sprite + " * " + name + ".nomer_kadra, 0, RGB(0, 255, 255));" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "        " + name + ".nomer_kadra++;" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "        if (" + name + ".nomer_kadra > 2)" + Environment.NewLine);
            File.AppendAllText(filename, "        {" + Environment.NewLine);
            File.AppendAllText(filename, "           " + name + ".nomer_kadra = 0;" + Environment.NewLine);
            File.AppendAllText(filename, "        }" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
        }
    }
}
