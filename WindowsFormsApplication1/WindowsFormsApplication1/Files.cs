using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Files
    {
        public static void CreateStruct(string filename)
        {
            File.WriteAllText(filename, "");
            StreamWriter sw = new StreamWriter(filename);
            sw.Write("#include \"TXLib.h\"" +          Environment.NewLine);
            sw.Write(                                  Environment.NewLine);
            sw.Write("struct Person" +                 Environment.NewLine);
            sw.Write("{" +                             Environment.NewLine);
            sw.Write("    double x;" +                 Environment.NewLine);
            sw.Write("    double x2;" +                Environment.NewLine);
            sw.Write("    double y;" +                 Environment.NewLine);
            sw.Write("    double y2;" +                Environment.NewLine);
            sw.Write("    double angle;" +             Environment.NewLine);
            sw.Write("    double nomer_kadra;" +       Environment.NewLine);
            sw.Write("    HDC texture;" +              Environment.NewLine);
            sw.Write("    int MID_x;" +                Environment.NewLine);
            sw.Write("    int MID_y;" +                Environment.NewLine);
            sw.Write("    int rad;" +                  Environment.NewLine);
            sw.Write("    int skorost;" +              Environment.NewLine);
            sw.Write("    int gr_dvigx;" +             Environment.NewLine);
            sw.Write("    int gr_dvigy;" +             Environment.NewLine);
            sw.Write("    int nach_dv;" +              Environment.NewLine);
            sw.Write("    int ampl_y;" +               Environment.NewLine);
            sw.Write("    int ampl_x;" +               Environment.NewLine);
            sw.Write("    double BeginTime;" +         Environment.NewLine);
            sw.Write("    double EndTime;" +           Environment.NewLine);
            sw.Write("    double Time;" +              Environment.NewLine);
            sw.Write("};" +                            Environment.NewLine);
            sw.Write(                                  Environment.NewLine);
            sw.Close();
        }

        public static void OpenMain(string filename, PictureBox PictureBoxBackground, String addressBackground)
        {
            StreamWriter sw = new StreamWriter(filename, true);
            sw.Write("int main()" + Environment.NewLine);
            sw.Write("{" + Environment.NewLine);
            sw.Write("    txCreateWindow(" +
                PictureBoxBackground.Image.Width.ToString() + ", " +
                PictureBoxBackground.Image.Height.ToString() + ");" + Environment.NewLine);
            sw.Write("    double myTime = 0;" + Environment.NewLine);
            sw.Write("    HDC texture = txLoadImage(\"Pictures\\\\" + Path.GetFileName(addressBackground) + "\");" +
                Environment.NewLine);
            sw.Close();
        }

        public static void CloseWhile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename, true);
            sw.Write(Environment.NewLine);
            sw.Write("        myTime += 0.05;" + Environment.NewLine);
            sw.Write("        txSleep(50);" + Environment.NewLine);
            sw.Write("    }" + Environment.NewLine);
            sw.Close();
        }

        public static void OpenWhile(string filename, int maxTime)
        {
            StreamWriter sw = new StreamWriter(filename, true);
            sw.Write(Environment.NewLine);
            sw.Write("    while (myTime <= " + maxTime + ")" + Environment.NewLine);
            sw.Write("    {" + Environment.NewLine);
            sw.Write("        txSetColor(TX_RED);" + Environment.NewLine);
            sw.Write("        txSetFillColor(TX_RED);" + Environment.NewLine);
            sw.Write("        txBitBlt(txDC(), 0, 0, txGetExtentX(), txGetExtentY(), texture, 0, 0);" +
                Environment.NewLine);
            sw.Close();
        }       
    
        public static void Ending(string filename, bool autoexit = false)
        {
            StreamWriter sw = new StreamWriter(filename, true);
            sw.Write("    txDeleteDC(texture);" + Environment.NewLine);
            if (autoexit)
                sw.Write("    txDisableAutoPause();");
            sw.Write("    return 0;" + Environment.NewLine);
            sw.Write("}" + Environment.NewLine);
            sw.Close();
        }
    }
}
