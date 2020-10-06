using System;
using System.IO;

namespace WindowsFormsApplication1
{
    public class Circle
    {
        public static void CreatePerson(string filename, string name, Person p)
        {
            StreamWriter sw = new StreamWriter(filename, true);
            sw.Write(Environment.NewLine);
            sw.Write("    Person " + name + ";" + Environment.NewLine);
            sw.Write("    " + name + ".texture = txLoadImage(\"Pictures\\\\" + Path.GetFileName(p.address) + "\");" + Environment.NewLine);
            sw.Write(Environment.NewLine);
            sw.Write("    " + name + ".x = " + p.x1 + "; " + Environment.NewLine);
            sw.Write("    " + name + ".y = " + p.y1 + "; " + Environment.NewLine);
            sw.Write("    " + name + ".x2 = " + p.x2 + "; " + Environment.NewLine);
            sw.Write("    " + name + ".y2 = " + p.y2 + "; " + Environment.NewLine);
            sw.Write("    " + name + ".angle = 0;" + Environment.NewLine);
            sw.Write("    " + name + ".nomer_kadra = 0;" + Environment.NewLine);
            sw.Write(Environment.NewLine);
            sw.Close();
        }

        public static void MovePerson(string filename, string name, Person p)
        {
            StreamWriter sw = new StreamWriter(filename, true);
            sw.Write("        if ((myTime >= " + p.time1 + ") && (myTime <= " + p.time2 + ")) {" + Environment.NewLine);
            sw.Write("            " + name + ".angle = " + name + ".angle + 360 / 20 * " + p.circles + " / (" + p.time2 + "-" + p.time1 + ");" + Environment.NewLine);
            sw.Write("            " + name + ".x = (" + p.x1 + " + " + p.x2 + ")/2 + (" + p.x1 + " - " + p.x2 + ")/2 * cos (" + name + ".angle * 3.1416 / 180);" + Environment.NewLine);
            sw.Write("            " + name + ".y = (" + p.y1 + " + " + p.y2 + ")/2 + (" + p.y1 + " - " + p.y2 + ")/2 * sin (" + name + ".angle * 3.1416 / 180);" + Environment.NewLine);
            sw.Write("            txTransparentBlt(txDC(), " + name + ".x, " + name + ".y, " +
                p.width + "/" + p.sprite + ", " +
                p.height + "," +
                name + ".texture, " +
                p.width + "/" + p.sprite + " * " + name + ".nomer_kadra, 0, RGB(255, 255, 255));" + Environment.NewLine);
            sw.Write(Environment.NewLine);
            sw.Write("            " + name + ".nomer_kadra++;" + Environment.NewLine);
            sw.Write(Environment.NewLine);
            sw.Write("            if (" + name + ".nomer_kadra >= " + p.sprite + ")" + Environment.NewLine);
            sw.Write("            {" + Environment.NewLine);
            sw.Write("               " + name + ".nomer_kadra = 0;" + Environment.NewLine);
            sw.Write("            }" + Environment.NewLine);
            sw.Write("        }" + Environment.NewLine);
            sw.Write(Environment.NewLine);
            sw.Close();
        }
    }
}
