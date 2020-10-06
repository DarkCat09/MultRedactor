using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CompileForm : Form
    {
        private string codeFilename = "";
        private string mingwDir = "";
        public CompileForm(string _codeFilename)
        {
            InitializeComponent();
            codeFilename = _codeFilename;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Для создания *.exe-файла мультфильма нужна специальная программа - компилятор.\n" +
                "Мы используем компилятор MinGW. Чтобы его скачать, нажмите OK в этом диалоге,\n" +
                "но учтите, что все нужные файлы весят ≈800МиБ!\n\n" +
                "После загрузки Вам нужно распаковать архив в удобное Вам место,\n" +
                "а затем, в этом окне, выбрать каталог mingw, который теперь лежит в \"удобном Вам месте\".",
                "Скачать MinGW", MessageBoxButtons.OKCancel, MessageBoxIcon.Information).ToString() == "OK")
            {
                Process.Start("https://is.gd/Krp8r4");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog().ToString() == "OK")
            {
                mingwDir = folderBrowserDialog1.SelectedPath;
            }
            textBox1.Text = mingwDir;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mingwDir != "")
            {
                try
                {
                    textBox2.Text += ("Компиляция " + codeFilename + " в " +
                        Path.GetFileNameWithoutExtension(codeFilename) + ".exe с помощью " +
                        mingwDir + "\\bin\\mingw32-g++.exe:" + Environment.NewLine + Environment.NewLine);

                    Process mingwp = new Process();
                    mingwp.StartInfo = new ProcessStartInfo()
                    {
                        FileName = mingwDir + "\\bin\\mingw32-g++.exe",
                        Arguments = codeFilename + " -o " + Path.GetDirectoryName(codeFilename) + "\\" +
                        Path.GetFileNameWithoutExtension(codeFilename) + ".exe",
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        StandardOutputEncoding = Encoding.GetEncoding(866),
                        StandardErrorEncoding = Encoding.GetEncoding(866),
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    };
                    mingwp.OutputDataReceived += new DataReceivedEventHandler(CompilerOutputHandler);
                    mingwp.ErrorDataReceived += new DataReceivedEventHandler(CompilerOutputHandler);
                    mingwp.Start();
                    mingwp.BeginOutputReadLine();
                    mingwp.BeginErrorReadLine();
                    mingwp.WaitForExit(10000);

                    _ = MessageBox.Show("Готово!");
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show("Произошла ошибка!\n" + ex.Message);
                }
            }
            else
            {
                _ = MessageBox.Show("Сначала укажите каталог с MinGW!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompilerOutputHandler(object sendingProcess, DataReceivedEventArgs outputLine)
        {
            textBox2.Invoke(new Action(() => { textBox2.Text += (outputLine.Data + Environment.NewLine); }));
        }
    }
}
