using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Files
    {
        public static void CreateStruct(string filename)
        {
            File.WriteAllText(filename, "");
            File.AppendAllText(filename, "#include \"TXLib.h\"" +          Environment.NewLine);
            File.AppendAllText(filename,                                   Environment.NewLine);
            File.AppendAllText(filename, "struct Person" +                 Environment.NewLine);
            File.AppendAllText(filename, "{" +                             Environment.NewLine);
            File.AppendAllText(filename, "    double x;" +                 Environment.NewLine);
            File.AppendAllText(filename, "    double x2;" +                Environment.NewLine);
            File.AppendAllText(filename, "    double y;" +                 Environment.NewLine);
            File.AppendAllText(filename, "    double y2;" +                Environment.NewLine);
            File.AppendAllText(filename, "    double angle;" +             Environment.NewLine);
            File.AppendAllText(filename, "    double nomer_kadra;" +       Environment.NewLine);
            File.AppendAllText(filename, "    HDC texture;" +              Environment.NewLine);
            File.AppendAllText(filename, "    int MID_x;" +                Environment.NewLine);
            File.AppendAllText(filename, "    int MID_y;" +                Environment.NewLine);
            File.AppendAllText(filename, "    int rad;" +                  Environment.NewLine);
            File.AppendAllText(filename, "    int skorost;" +              Environment.NewLine);
            File.AppendAllText(filename, "    int gr_dvigx;" +             Environment.NewLine);
            File.AppendAllText(filename, "    int gr_dvigy;" +             Environment.NewLine);
            File.AppendAllText(filename, "    int nach_dv;" +              Environment.NewLine);
            File.AppendAllText(filename, "    int ampl_y;" +               Environment.NewLine);
            File.AppendAllText(filename, "    int ampl_x;" +               Environment.NewLine);
            File.AppendAllText(filename, "    double BeginTime;" +         Environment.NewLine);
            File.AppendAllText(filename, "    double EndTime;" +           Environment.NewLine);
            File.AppendAllText(filename, "    double Time;" +              Environment.NewLine);
            File.AppendAllText(filename, "};" +                            Environment.NewLine);
            File.AppendAllText(filename,                                   Environment.NewLine);
        }

        public static void OpenMain(string filename, PictureBox PictureBoxBackground)
        {
            File.AppendAllText(filename, "int main()" + Environment.NewLine);
            File.AppendAllText(filename, "{" + Environment.NewLine);
            File.AppendAllText(filename, "    txCreateWindow(" +
                PictureBoxBackground.Image.Width.ToString() + ", " +
                PictureBoxBackground.Image.Height.ToString() + ");" + Environment.NewLine);
            File.AppendAllText(filename, "    double myTime = 0;" + Environment.NewLine);
        }

        public static void CloseWhile(string filename)
        {
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "        myTime += 0.01;" + Environment.NewLine);
            File.AppendAllText(filename, "        txSleep(10);" + Environment.NewLine);
            File.AppendAllText(filename, "    }" + Environment.NewLine);
        }

        public static void OpenWhile(string filename)
        {
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "    while (!GetAsyncKeyState(VK_ESCAPE))" + Environment.NewLine);
            File.AppendAllText(filename, "    {" + Environment.NewLine);
            File.AppendAllText(filename, "        txSetColor(TX_RED);" + Environment.NewLine);
            File.AppendAllText(filename, "        txSetFillColor(TX_RED);" + Environment.NewLine);
            File.AppendAllText(filename, "        txRectangle(0, 0, txGetExtentX(), txGetExtentY());" + Environment.NewLine);
        }       
    
        public static void Ending(string filename)
        {
            File.AppendAllText(filename, "   return 0;" + Environment.NewLine);
            File.AppendAllText(filename, "}" + Environment.NewLine);
        }
    }
}
