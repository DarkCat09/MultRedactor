using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        Person[] persons = new Person[200];

        int yPersa = 300;
        int nomerPersa = 0;
        int pNomer = 0;
        int maxTime = 0;
        PictureBox[] pic1 = new PictureBox[1000];
        String adressBackground = "";

        public MainForm()
        {
            InitializeComponent();
            ComboBoxMove.SelectedIndex = 0;
            openFileDialog1.Filter = "Bitmap Pictures|*.bmp";
            saveFileDialog1.Filter = "C++ Code Files|*.cpp";
        }

        private void buttonAddCharClick(object sender, EventArgs e)
        {
            personPanel.Visible = true;
            pNomer = -120;
        }

        private void DeletePics(string filename, int nomer)
        {
            File.AppendAllText(filename, Environment.NewLine);

            for (int n1 = 0; n1 < nomer; n1++)
            {
                File.AppendAllText(filename, "    txDeleteDC(" + Person.PersonName(n1) + ".texture);" + Environment.NewLine);
            }
        }

        private void SaveCharButtonClick(object sender, EventArgs e)
        {
            if (personPanel.Visible == false)
            {
                MessageBox.Show("Где параметры? Покажи мне, ткни меня в них!");
                return;
            }

            personPanel.Visible = true;
            if (pNomer == -120)
            {
                persons[nomerPersa] = AddRowToPersList(persons[nomerPersa]);

                persons[nomerPersa].coord = TextBoxWall1.Text;
                persons[nomerPersa].coord2 = TextBoxWall2.Text;
                persons[nomerPersa].time1 = TextBoxTime1.Text;
                persons[nomerPersa].time2 = TextBoxTime2.Text;
                persons[nomerPersa].sprite = SpriteNumberTextBox.Text;
                persons[nomerPersa].moveside = ComboBoxMove.Text;
                persons[nomerPersa].nomer = nomerPersa;
                persons[nomerPersa].charname = charNameBox.Text;
                persons[nomerPersa].circles = circlesTextBox.Text;
                persons[nomerPersa].l2.Text = charNameBox.Text;

                String[] coordinatyNachala = TextBoxWall1.Text.Split(new String[] { "," }, StringSplitOptions.None);
                if (coordinatyNachala.Length > 1)
                {
                    persons[nomerPersa].x1 = coordinatyNachala[0];
                    persons[nomerPersa].y1 = coordinatyNachala[1];
                }

                String[] coordinatyKonza = TextBoxWall2.Text.Split(new String[] { "," }, StringSplitOptions.None);
                if (coordinatyKonza.Length > 1)
                {
                    persons[nomerPersa].x2 = coordinatyKonza[0];
                    persons[nomerPersa].y2 = coordinatyKonza[1];
                }

                nomerPersa++;
                yPersa += 30;
                openSpace.Image = null;
            }
            else
            {
                persons[pNomer].coord = TextBoxWall1.Text;
                persons[pNomer].coord2 = TextBoxWall2.Text;
                persons[pNomer].time1 = TextBoxTime1.Text;
                persons[pNomer].time2 = TextBoxTime2.Text;
                persons[pNomer].sprite = SpriteNumberTextBox.Text;
                persons[pNomer].moveside = ComboBoxMove.Text;
                persons[pNomer].nomer = pNomer;

                String[] coordinatyNachala = TextBoxWall1.Text.Split(new String[] { "," }, StringSplitOptions.None);
                if (coordinatyNachala.Length > 1)
                {
                    persons[pNomer].x1 = coordinatyNachala[0];
                    persons[pNomer].y1 = coordinatyNachala[1];
                }
                String[] coordinatyKonza = TextBoxWall2.Text.Split(new String[] { "," }, StringSplitOptions.None);
                if (coordinatyKonza.Length > 1)
                {
                    persons[pNomer].x2 = coordinatyKonza[0];
                    persons[pNomer].y2 = coordinatyKonza[1];
                }

                persons[pNomer].charname = charNameBox.Text;
                persons[pNomer].circles = circlesTextBox.Text;
                persons[pNomer].l2.Text = charNameBox.Text;
            }

            for (int nomer = 0; nomer < nomerPersa; nomer++)
            {
                if (Convert.ToInt32(persons[nomer].time2) > maxTime)
                {
                    maxTime = Convert.ToInt32(persons[nomer].time2);
                }
            }

            LabelLengh.Text = "Длительность: " + maxTime.ToString() + " секунд";
        }

        private Person AddRowToPersList(Person p)
        {
            p.l1 = new Label();
            p.l1.Top = yPersa;
            p.l1.Left = 30;
            p.l1.Width = 20;
            p.l1.Visible = true;
            p.l1.Text = (nomerPersa + 1).ToString();
            leftPanel.Controls.Add(p.l1);

            p.l2 = new Label();
            p.l2.Top = yPersa;
            p.l2.Left = 60;
            p.l2.Width = 60;
            p.l2.Visible = true;
            p.l2.Text = "Перс" + (nomerPersa + 1).ToString();
            leftPanel.Controls.Add(p.l2);

            p.l3 = new Label();
            p.l3.Top = yPersa;
            p.l3.Left = 120;
            p.l3.Width = 40;
            p.l3.Visible = true;
            p.l3.Text = "saved";
            leftPanel.Controls.Add(p.l3);

            p.b1 = new Button();
            p.b1.Top = yPersa;
            p.b1.Left = 170;
            p.b1.Width = 50;
            p.b1.Visible = true;
            p.b1.Text = "Edit";
            p.b1.MouseClick +=
                new MouseEventHandler(this.Char_Creator_Button_Click);
            leftPanel.Controls.Add(p.b1);

            ToolTip tView = new ToolTip();
            tView.IsBalloon = true;
            tView.InitialDelay = 0;
            tView.ShowAlways = true;
            tView.AutoPopDelay = 2000;
            tView.SetToolTip(p.b1, "View/edit person");

            p.b2 = new Button();
            p.b2.Top = yPersa;
            p.b2.Left = 230;
            p.b2.Width = 50;
            p.b2.Visible = true;
            p.b2.Text = "Del";
            p.b2.Click +=
                new System.EventHandler(this.Char_Info_Click);
            leftPanel.Controls.Add(p.b2);

            ToolTip tDelete = new ToolTip();
            tDelete.IsBalloon = true;
            tDelete.InitialDelay = 0;
            tDelete.ShowAlways = true;
            tDelete.AutoPopDelay = 2000;
            tDelete.SetToolTip(p.b2, "Delete this person");

            return p;
        }

        private void OpenAddCharClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            openSpace.Image = Image.FromFile(openFileDialog1.FileName);
            if (pNomer == -120)
            {
                persons[nomerPersa].adress = openFileDialog1.FileName;
                persons[nomerPersa].width = openSpace.Image.Width.ToString();
                persons[nomerPersa].height = openSpace.Image.Height.ToString();
            }
            else
            {
                persons[pNomer].adress = openFileDialog1.FileName;
                persons[pNomer].width = openSpace.Image.Width.ToString();
                persons[pNomer].height = openSpace.Image.Height.ToString();
            }
        }

        private void AddBackArtClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            PictureBoxBackground.Image = Image.FromFile(openFileDialog1.FileName);
            adressBackground = openFileDialog1.FileName;
        }

        private void SaveMultButton_Click(object sender, EventArgs e)
        {
            if (PictureBoxBackground.Image == null)
            {
                MessageBox.Show("Что ты собрался выводить-то, поехавший (фон)?");
                return;
            }

            for (int nomer = 0; nomer < nomerPersa; nomer++)
            {
                if (String.IsNullOrEmpty(persons[nomer].adress))
                {
                    MessageBox.Show("Картинка №" + (nomer + 1).ToString() + " пустая");
                    return;
                }
                if (String.IsNullOrEmpty(persons[nomer].x1))
                {
                    MessageBox.Show("Первая координата персонажа №" + (nomer + 1).ToString() + " пустая");
                    return;
                }
                if (String.IsNullOrEmpty(persons[nomer].y1))
                {
                    MessageBox.Show("Первая координата персонажа №" + (nomer + 1).ToString() + " пустая");
                    return;
                }
                if (String.IsNullOrEmpty(persons[nomer].y2))
                {
                    MessageBox.Show("Вторая координата персонажа №" + (nomer + 1).ToString() + " пустая");
                    return;
                }
                if (String.IsNullOrEmpty(persons[nomer].x2))
                {
                    MessageBox.Show("Вторая координата персонажа №" + (nomer + 1).ToString() + " пустая");
                    return;
                }
                if (String.IsNullOrEmpty(persons[nomer].time1))
                {
                    MessageBox.Show("Первая координата времени №" + (nomer + 1).ToString() + " пустая");
                    return;
                }
                if (String.IsNullOrEmpty(persons[nomer].time2))
                {
                    MessageBox.Show("Вторая координата времени №" + (nomer + 1).ToString() + " пустая");
                    return;
                }
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;

                //Adding TXLibrary and pictures
                File.Copy("TXLib.h", Path.GetDirectoryName(filename) + "\\TXLib.h", true);
                string dir_path = Path.GetDirectoryName(filename) + "\\Pictures";
                if (!Directory.Exists(dir_path))
                {
                    Directory.CreateDirectory(dir_path);
                }

                if (adressBackground != dir_path + "\\" + Path.GetFileName(adressBackground))
                {
                    File.Copy(adressBackground, dir_path + "\\" + Path.GetFileName(adressBackground), true);
                }
 
                Files.CreateStruct(filename);
                Files.OpenMain(filename, PictureBoxBackground, adressBackground);
 
                for (int nomer = 0; nomer < nomerPersa; nomer++)
                {
                    File.Copy(persons[nomer].adress, dir_path + "\\" + Path.GetFileName(persons[nomer].adress), true);

                    if (dir_path == dir_path + "\\" + Path.GetFileName(persons[nomer].adress))
                    {
                        File.Copy(persons[nomer].adress, dir_path + "\\" + Path.GetFileName(persons[nomer].adress), true);
                    }

                    if (persons[nomer].moveside == "Прямо")
                    {
                        Line.CreatePerson(filename, Person.PersonName(nomer), persons[nomer]);
                    }
                    else if (persons[nomer].moveside == "Волнами")
                    {
                        Sinus.CreatePerson(filename, Person.PersonName(nomer), persons[nomer]);
                    }
                    else if (persons[nomer].moveside == "Кругами")
                    {
                        Circle.CreatePerson(filename, Person.PersonName(nomer), persons[nomer]);
                    }
                    else if (persons[nomer].moveside == "Диагонально")
                    {
                        Line.CreatePerson(filename, Person.PersonName(nomer), persons[nomer]);
                    }
                }

                Files.OpenWhile(filename, maxTime);

                for (int nomer = 0; nomer < nomerPersa; nomer++)
                {
                    if (persons[nomer].moveside == "Прямо")
                    {
                        Line.MovePerson(filename, Person.PersonName(nomer), persons[nomer]);
                    }
                    else if (persons[nomer].moveside == "Волнами")
                    {
                        Sinus.MovePerson(filename, Person.PersonName(nomer), persons[nomer]);
                    }
                    else if (persons[nomer].moveside == "Кругами")
                    {
                        Circle.MovePerson(filename, Person.PersonName(nomer), persons[nomer]);
                    }
                    else if (persons[nomer].moveside == "Диагонально")
                    {
                        Line.MovePerson(filename, Person.PersonName(nomer), persons[nomer]);
                    }
                }

                Files.CloseWhile(filename);
                DeletePics(filename, nomerPersa);
                Files.Ending(filename);

                MessageBox.Show("Successfully");
            }
        }

        private void Char_Creator_Button_Click(object sender, MouseEventArgs e)
        {
            for (int nomer = 0; nomer < nomerPersa; nomer++)
            {
                if (sender.Equals(persons[nomer].b1))
                {
                    TextBoxWall1.Text = persons[nomer].coord;
                    TextBoxWall2.Text = persons[nomer].coord2;
                    TextBoxTime1.Text = persons[nomer].time1;
                    TextBoxTime2.Text = persons[nomer].time2;
                    SpriteNumberTextBox.Text = persons[nomer].sprite;
                    ComboBoxMove.Text = persons[nomer].moveside;
                    pNomer = persons[nomer].nomer;
                    charNameBox.Text = persons[nomer].charname;
                    circlesTextBox.Text = persons[nomer].circles;

                    if (!String.IsNullOrEmpty(persons[nomer].adress))
                    {
                        openSpace.Image = Image.FromFile(persons[nomer].adress);
                    }
                    else
                    {
                        openSpace.Image = null;
                    }
                }
            }
        }

        private void Char_Info_Click(object sender, EventArgs e)
        {
            this.leftPanel.Controls.Remove(persons[nomerPersa - 1].l1);
            this.leftPanel.Controls.Remove(persons[nomerPersa - 1].l2);
            this.leftPanel.Controls.Remove(persons[nomerPersa - 1].l3);
            this.leftPanel.Controls.Remove(persons[nomerPersa - 1].b1);
            this.leftPanel.Controls.Remove(persons[nomerPersa - 1].b2);
            nomerPersa--;
            yPersa -= 30;
        }

        private void TextBoxWall1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!(char.IsDigit(c) || c == '\b' || c == ','))
            {
                e.Handled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToolTip tView = new ToolTip();
            tView.IsBalloon = true;
            tView.InitialDelay = 0;
            tView.ShowAlways = true;
            tView.AutoPopDelay = 2000;
            tView.SetToolTip(TextBoxWall1, "x.y");

            ToolTip tView2 = new ToolTip();
            tView2.IsBalloon = true;
            tView2.InitialDelay = 0;
            tView2.ShowAlways = true;
            tView2.AutoPopDelay = 2000;
            tView2.SetToolTip(TextBoxWall2, "x.y");

            ComboBoxMove_SelectedIndexChanged(sender, e);
        }

        private void ComboBoxMove_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxMove.Text == "Кругами")
            {
                circlesTextBox.Visible = true;
                circlesLabel.Visible = true;
            }
            else
            {
                circlesTextBox.Visible = false;
                circlesLabel.Visible = false;
            }
        }
    }
}