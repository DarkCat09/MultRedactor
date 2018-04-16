namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelData = new System.Windows.Forms.Label();
            this.LabelLengh = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.nazvanieTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.LabelBackground = new System.Windows.Forms.Label();
            this.dobavitFonButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveCharButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.charNameBox = new System.Windows.Forms.TextBox();
            this.charNameLabel = new System.Windows.Forms.Label();
            this.openSpace = new System.Windows.Forms.PictureBox();
            this.SpriteNumberLabel = new System.Windows.Forms.Label();
            this.SpriteNumberTextBox = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.LabelPic = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelDef2 = new System.Windows.Forms.Label();
            this.LabelDef1 = new System.Windows.Forms.Label();
            this.LabelWalls = new System.Windows.Forms.Label();
            this.TextBoxTime1 = new System.Windows.Forms.TextBox();
            this.TextBoxTime2 = new System.Windows.Forms.TextBox();
            this.TextBoxWall2 = new System.Windows.Forms.TextBox();
            this.TextBoxWall1 = new System.Windows.Forms.TextBox();
            this.ComboBoxMove = new System.Windows.Forms.ComboBox();
            this.LabelMoveType = new System.Windows.Forms.Label();
            this.SaveMultButton = new System.Windows.Forms.Button();
            this.ButtonAddChar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBackground)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelData.Location = new System.Drawing.Point(0, 11);
            this.LabelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(278, 28);
            this.LabelData.TabIndex = 0;
            this.LabelData.Text = "Данные о мултфильме:";
            // 
            // LabelLengh
            // 
            this.LabelLengh.AutoSize = true;
            this.LabelLengh.Location = new System.Drawing.Point(19, 74);
            this.LabelLengh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLengh.Name = "LabelLengh";
            this.LabelLengh.Size = new System.Drawing.Size(175, 17);
            this.LabelLengh.TabIndex = 1;
            this.LabelLengh.Text = "Длительность: 35 секунд";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(19, 106);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(76, 17);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Название:";
            // 
            // nazvanieTextBox
            // 
            this.nazvanieTextBox.Location = new System.Drawing.Point(107, 106);
            this.nazvanieTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nazvanieTextBox.Name = "nazvanieTextBox";
            this.nazvanieTextBox.Size = new System.Drawing.Size(183, 22);
            this.nazvanieTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.PictureBoxBackground);
            this.panel1.Controls.Add(this.LabelBackground);
            this.panel1.Controls.Add(this.dobavitFonButton);
            this.panel1.Controls.Add(this.LabelData);
            this.panel1.Controls.Add(this.nazvanieTextBox);
            this.panel1.Controls.Add(this.LabelLengh);
            this.panel1.Controls.Add(this.LabelName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 468);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "number    name         state             view             delete";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 286);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "ИНФОРМАЦИЯ О ПЕРСОНАЖАХ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // PictureBoxBackground
            // 
            this.PictureBoxBackground.Location = new System.Drawing.Point(22, 194);
            this.PictureBoxBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBoxBackground.Name = "PictureBoxBackground";
            this.PictureBoxBackground.Size = new System.Drawing.Size(156, 88);
            this.PictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxBackground.TabIndex = 12;
            this.PictureBoxBackground.TabStop = false;
            // 
            // LabelBackground
            // 
            this.LabelBackground.AutoSize = true;
            this.LabelBackground.Location = new System.Drawing.Point(19, 140);
            this.LabelBackground.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBackground.Name = "LabelBackground";
            this.LabelBackground.Size = new System.Drawing.Size(100, 17);
            this.LabelBackground.TabIndex = 11;
            this.LabelBackground.Text = "Выбрать фон:";
            // 
            // dobavitFonButton
            // 
            this.dobavitFonButton.Location = new System.Drawing.Point(23, 160);
            this.dobavitFonButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dobavitFonButton.Name = "dobavitFonButton";
            this.dobavitFonButton.Size = new System.Drawing.Size(155, 30);
            this.dobavitFonButton.TabIndex = 10;
            this.dobavitFonButton.Text = "Добавить";
            this.dobavitFonButton.UseVisualStyleBackColor = true;
            this.dobavitFonButton.Click += new System.EventHandler(this.AddBackArtClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(396, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 468);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SaveCharButton);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.SaveMultButton);
            this.panel2.Controls.Add(this.ButtonAddChar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(400, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 468);
            this.panel2.TabIndex = 6;
            // 
            // SaveCharButton
            // 
            this.SaveCharButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveCharButton.Location = new System.Drawing.Point(0, 394);
            this.SaveCharButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveCharButton.Name = "SaveCharButton";
            this.SaveCharButton.Size = new System.Drawing.Size(503, 37);
            this.SaveCharButton.TabIndex = 3;
            this.SaveCharButton.Text = "Сохранить персонажа";
            this.SaveCharButton.UseVisualStyleBackColor = true;
            this.SaveCharButton.Click += new System.EventHandler(this.SaveCharButtonClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.charNameBox);
            this.panel3.Controls.Add(this.charNameLabel);
            this.panel3.Controls.Add(this.openSpace);
            this.panel3.Controls.Add(this.SpriteNumberLabel);
            this.panel3.Controls.Add(this.SpriteNumberTextBox);
            this.panel3.Controls.Add(this.OpenButton);
            this.panel3.Controls.Add(this.LabelPic);
            this.panel3.Controls.Add(this.LabelTime);
            this.panel3.Controls.Add(this.LabelDef2);
            this.panel3.Controls.Add(this.LabelDef1);
            this.panel3.Controls.Add(this.LabelWalls);
            this.panel3.Controls.Add(this.TextBoxTime1);
            this.panel3.Controls.Add(this.TextBoxTime2);
            this.panel3.Controls.Add(this.TextBoxWall2);
            this.panel3.Controls.Add(this.TextBoxWall1);
            this.panel3.Controls.Add(this.ComboBoxMove);
            this.panel3.Controls.Add(this.LabelMoveType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 399);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // charNameBox
            // 
            this.charNameBox.Location = new System.Drawing.Point(113, 142);
            this.charNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.charNameBox.Name = "charNameBox";
            this.charNameBox.Size = new System.Drawing.Size(183, 22);
            this.charNameBox.TabIndex = 19;
            // 
            // charNameLabel
            // 
            this.charNameLabel.AutoSize = true;
            this.charNameLabel.Location = new System.Drawing.Point(25, 142);
            this.charNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.charNameLabel.Name = "charNameLabel";
            this.charNameLabel.Size = new System.Drawing.Size(76, 17);
            this.charNameLabel.TabIndex = 18;
            this.charNameLabel.Text = "Название:";
            // 
            // openSpace
            // 
            this.openSpace.Location = new System.Drawing.Point(251, 233);
            this.openSpace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openSpace.Name = "openSpace";
            this.openSpace.Size = new System.Drawing.Size(248, 89);
            this.openSpace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openSpace.TabIndex = 17;
            this.openSpace.TabStop = false;
            // 
            // SpriteNumberLabel
            // 
            this.SpriteNumberLabel.AutoSize = true;
            this.SpriteNumberLabel.Location = new System.Drawing.Point(9, 188);
            this.SpriteNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpriteNumberLabel.Name = "SpriteNumberLabel";
            this.SpriteNumberLabel.Size = new System.Drawing.Size(155, 17);
            this.SpriteNumberLabel.TabIndex = 16;
            this.SpriteNumberLabel.Text = "Количество спрайтов:";
            // 
            // SpriteNumberTextBox
            // 
            this.SpriteNumberTextBox.Location = new System.Drawing.Point(13, 208);
            this.SpriteNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpriteNumberTextBox.Name = "SpriteNumberTextBox";
            this.SpriteNumberTextBox.Size = new System.Drawing.Size(109, 22);
            this.SpriteNumberTextBox.TabIndex = 15;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(251, 188);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(256, 37);
            this.OpenButton.TabIndex = 14;
            this.OpenButton.Text = "Открыть персонажа";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenAddCharClick);
            // 
            // LabelPic
            // 
            this.LabelPic.AutoSize = true;
            this.LabelPic.Location = new System.Drawing.Point(172, 188);
            this.LabelPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPic.Name = "LabelPic";
            this.LabelPic.Size = new System.Drawing.Size(75, 17);
            this.LabelPic.TabIndex = 12;
            this.LabelPic.Text = "Картинка:";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(25, 112);
            this.LabelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(67, 17);
            this.LabelTime.TabIndex = 11;
            this.LabelTime.Text = "Тайминг:";
            // 
            // LabelDef2
            // 
            this.LabelDef2.AutoSize = true;
            this.LabelDef2.Location = new System.Drawing.Point(320, 112);
            this.LabelDef2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDef2.Name = "LabelDef2";
            this.LabelDef2.Size = new System.Drawing.Size(18, 17);
            this.LabelDef2.TabIndex = 10;
            this.LabelDef2.Text = "--";
            // 
            // LabelDef1
            // 
            this.LabelDef1.AutoSize = true;
            this.LabelDef1.Location = new System.Drawing.Point(320, 76);
            this.LabelDef1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDef1.Name = "LabelDef1";
            this.LabelDef1.Size = new System.Drawing.Size(18, 17);
            this.LabelDef1.TabIndex = 9;
            this.LabelDef1.Text = "--";
            // 
            // LabelWalls
            // 
            this.LabelWalls.AutoSize = true;
            this.LabelWalls.Location = new System.Drawing.Point(25, 76);
            this.LabelWalls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWalls.Name = "LabelWalls";
            this.LabelWalls.Size = new System.Drawing.Size(138, 17);
            this.LabelWalls.TabIndex = 8;
            this.LabelWalls.Text = "Границы движения:";
            // 
            // TextBoxTime1
            // 
            this.TextBoxTime1.Location = new System.Drawing.Point(176, 108);
            this.TextBoxTime1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxTime1.Name = "TextBoxTime1";
            this.TextBoxTime1.Size = new System.Drawing.Size(132, 22);
            this.TextBoxTime1.TabIndex = 5;
            // 
            // TextBoxTime2
            // 
            this.TextBoxTime2.Location = new System.Drawing.Point(345, 108);
            this.TextBoxTime2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxTime2.Name = "TextBoxTime2";
            this.TextBoxTime2.Size = new System.Drawing.Size(132, 22);
            this.TextBoxTime2.TabIndex = 4;
            // 
            // TextBoxWall2
            // 
            this.TextBoxWall2.Location = new System.Drawing.Point(345, 73);
            this.TextBoxWall2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxWall2.Name = "TextBoxWall2";
            this.TextBoxWall2.Size = new System.Drawing.Size(132, 22);
            this.TextBoxWall2.TabIndex = 3;
            this.TextBoxWall2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWall1_KeyPress);
            // 
            // TextBoxWall1
            // 
            this.TextBoxWall1.Location = new System.Drawing.Point(176, 73);
            this.TextBoxWall1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxWall1.Name = "TextBoxWall1";
            this.TextBoxWall1.Size = new System.Drawing.Size(132, 22);
            this.TextBoxWall1.TabIndex = 2;
            this.TextBoxWall1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWall1_KeyPress);
            // 
            // ComboBoxMove
            // 
            this.ComboBoxMove.FormattingEnabled = true;
            this.ComboBoxMove.Items.AddRange(new object[] {
            "Прямо",
            "По диагонали",
            "Волнами",
            "Кругами"});
            this.ComboBoxMove.Location = new System.Drawing.Point(143, 15);
            this.ComboBoxMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxMove.Name = "ComboBoxMove";
            this.ComboBoxMove.Size = new System.Drawing.Size(160, 24);
            this.ComboBoxMove.TabIndex = 1;
            this.ComboBoxMove.Text = "Прямо";
            // 
            // LabelMoveType
            // 
            this.LabelMoveType.AutoSize = true;
            this.LabelMoveType.Location = new System.Drawing.Point(25, 15);
            this.LabelMoveType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMoveType.Name = "LabelMoveType";
            this.LabelMoveType.Size = new System.Drawing.Size(105, 17);
            this.LabelMoveType.TabIndex = 0;
            this.LabelMoveType.Text = "Вид движения:";
            // 
            // SaveMultButton
            // 
            this.SaveMultButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveMultButton.Location = new System.Drawing.Point(0, 431);
            this.SaveMultButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveMultButton.Name = "SaveMultButton";
            this.SaveMultButton.Size = new System.Drawing.Size(503, 37);
            this.SaveMultButton.TabIndex = 1;
            this.SaveMultButton.Text = "Сохранить мульт";
            this.SaveMultButton.UseVisualStyleBackColor = true;
            this.SaveMultButton.Click += new System.EventHandler(this.SaveMultButton_Click);
            // 
            // ButtonAddChar
            // 
            this.ButtonAddChar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonAddChar.Location = new System.Drawing.Point(0, 0);
            this.ButtonAddChar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAddChar.Name = "ButtonAddChar";
            this.ButtonAddChar.Size = new System.Drawing.Size(503, 32);
            this.ButtonAddChar.TabIndex = 0;
            this.ButtonAddChar.Text = "Добавить персонажа";
            this.ButtonAddChar.UseVisualStyleBackColor = true;
            this.ButtonAddChar.Click += new System.EventHandler(this.buttonAddCharClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = "Свойства персонажа";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBackground)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openSpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelData;
        private System.Windows.Forms.Label LabelLengh;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox nazvanieTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SaveMultButton;
        private System.Windows.Forms.Button ButtonAddChar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelMoveType;
        private System.Windows.Forms.TextBox TextBoxTime1;
        private System.Windows.Forms.TextBox TextBoxTime2;
        private System.Windows.Forms.TextBox TextBoxWall2;
        private System.Windows.Forms.TextBox TextBoxWall1;
        private System.Windows.Forms.ComboBox ComboBoxMove;
        private System.Windows.Forms.Label LabelDef1;
        private System.Windows.Forms.Label LabelWalls;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelDef2;
        private System.Windows.Forms.Button SaveCharButton;
        private System.Windows.Forms.Label LabelPic;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label SpriteNumberLabel;
        private System.Windows.Forms.TextBox SpriteNumberTextBox;
        private System.Windows.Forms.Label LabelBackground;
        private System.Windows.Forms.Button dobavitFonButton;
        private System.Windows.Forms.PictureBox PictureBoxBackground;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox openSpace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox charNameBox;
        private System.Windows.Forms.Label charNameLabel;
    }
}