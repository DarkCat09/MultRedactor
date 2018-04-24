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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.Char_Stats = new System.Windows.Forms.Label();
            this.Char_Info = new System.Windows.Forms.Label();
            this.PictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.LabelBackground = new System.Windows.Forms.Label();
            this.dobavitFonButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.SaveCharButton = new System.Windows.Forms.Button();
            this.personPanel = new System.Windows.Forms.Panel();
            this.charNameBox = new System.Windows.Forms.TextBox();
            this.circlesTextBox = new System.Windows.Forms.TextBox();
            this.circlesLabel = new System.Windows.Forms.Label();
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
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBackground)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.personPanel.SuspendLayout();
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
            this.LabelData.Size = new System.Drawing.Size(290, 28);
            this.LabelData.TabIndex = 0;
            this.LabelData.Text = "Данные о мультфильме:";
            // 
            // LabelLengh
            // 
            this.LabelLengh.AutoSize = true;
            this.LabelLengh.Location = new System.Drawing.Point(19, 74);
            this.LabelLengh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLengh.Name = "LabelLengh";
            this.LabelLengh.Size = new System.Drawing.Size(167, 17);
            this.LabelLengh.TabIndex = 1;
            this.LabelLengh.Text = "Длительность: 0 секунд";
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
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.Char_Stats);
            this.leftPanel.Controls.Add(this.Char_Info);
            this.leftPanel.Controls.Add(this.PictureBoxBackground);
            this.leftPanel.Controls.Add(this.LabelBackground);
            this.leftPanel.Controls.Add(this.dobavitFonButton);
            this.leftPanel.Controls.Add(this.LabelData);
            this.leftPanel.Controls.Add(this.nazvanieTextBox);
            this.leftPanel.Controls.Add(this.LabelLengh);
            this.leftPanel.Controls.Add(this.LabelName);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(396, 468);
            this.leftPanel.TabIndex = 4;
            // 
            // Char_Stats
            // 
            this.Char_Stats.AutoSize = true;
            this.Char_Stats.Location = new System.Drawing.Point(19, 337);
            this.Char_Stats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Char_Stats.Name = "Char_Stats";
            this.Char_Stats.Size = new System.Drawing.Size(344, 17);
            this.Char_Stats.TabIndex = 24;
            this.Char_Stats.Text = "number    name         state             view             delete";
            // 
            // Char_Info
            // 
            this.Char_Info.AutoSize = true;
            this.Char_Info.Location = new System.Drawing.Point(59, 286);
            this.Char_Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Char_Info.Name = "Char_Info";
            this.Char_Info.Size = new System.Drawing.Size(229, 17);
            this.Char_Info.TabIndex = 23;
            this.Char_Info.Text = "ИНФОРМАЦИЯ О ПЕРСОНАЖАХ";
            this.Char_Info.Click += new System.EventHandler(this.Char_Info_Click);
            // 
            // PictureBoxBackground
            // 
            this.PictureBoxBackground.Location = new System.Drawing.Point(21, 194);
            this.PictureBoxBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBoxBackground.Name = "PictureBoxBackground";
            this.PictureBoxBackground.Size = new System.Drawing.Size(156, 89);
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
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.SaveCharButton);
            this.rightPanel.Controls.Add(this.personPanel);
            this.rightPanel.Controls.Add(this.SaveMultButton);
            this.rightPanel.Controls.Add(this.ButtonAddChar);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(400, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(503, 468);
            this.rightPanel.TabIndex = 6;
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
            // personPanel
            // 
            this.personPanel.Controls.Add(this.charNameBox);
            this.personPanel.Controls.Add(this.circlesTextBox);
            this.personPanel.Controls.Add(this.circlesLabel);
            this.personPanel.Controls.Add(this.charNameLabel);
            this.personPanel.Controls.Add(this.openSpace);
            this.personPanel.Controls.Add(this.SpriteNumberLabel);
            this.personPanel.Controls.Add(this.SpriteNumberTextBox);
            this.personPanel.Controls.Add(this.OpenButton);
            this.personPanel.Controls.Add(this.LabelPic);
            this.personPanel.Controls.Add(this.LabelTime);
            this.personPanel.Controls.Add(this.LabelDef2);
            this.personPanel.Controls.Add(this.LabelDef1);
            this.personPanel.Controls.Add(this.LabelWalls);
            this.personPanel.Controls.Add(this.TextBoxTime1);
            this.personPanel.Controls.Add(this.TextBoxTime2);
            this.personPanel.Controls.Add(this.TextBoxWall2);
            this.personPanel.Controls.Add(this.TextBoxWall1);
            this.personPanel.Controls.Add(this.ComboBoxMove);
            this.personPanel.Controls.Add(this.LabelMoveType);
            this.personPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personPanel.Location = new System.Drawing.Point(0, 32);
            this.personPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.personPanel.Name = "personPanel";
            this.personPanel.Size = new System.Drawing.Size(503, 399);
            this.personPanel.TabIndex = 2;
            this.personPanel.Visible = false;
            // 
            // charNameBox
            // 
            this.charNameBox.Location = new System.Drawing.Point(113, 108);
            this.charNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.charNameBox.Name = "charNameBox";
            this.charNameBox.Size = new System.Drawing.Size(183, 22);
            this.charNameBox.TabIndex = 19;
            // 
            // circlesTextBox
            // 
            this.circlesTextBox.Location = new System.Drawing.Point(113, 140);
            this.circlesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circlesTextBox.Name = "circlesTextBox";
            this.circlesTextBox.Size = new System.Drawing.Size(183, 22);
            this.circlesTextBox.TabIndex = 21;
            // 
            // circlesLabel
            // 
            this.circlesLabel.AutoSize = true;
            this.circlesLabel.Location = new System.Drawing.Point(5, 140);
            this.circlesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.circlesLabel.Name = "circlesLabel";
            this.circlesLabel.Size = new System.Drawing.Size(103, 17);
            this.circlesLabel.TabIndex = 20;
            this.circlesLabel.Text = "Кол-во кругов:";
            // 
            // charNameLabel
            // 
            this.charNameLabel.AutoSize = true;
            this.charNameLabel.Location = new System.Drawing.Point(25, 108);
            this.charNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.charNameLabel.Name = "charNameLabel";
            this.charNameLabel.Size = new System.Drawing.Size(76, 17);
            this.charNameLabel.TabIndex = 18;
            this.charNameLabel.Text = "Название:";
            // 
            // openSpace
            // 
            this.openSpace.Location = new System.Drawing.Point(247, 238);
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
            this.SpriteNumberLabel.Location = new System.Drawing.Point(5, 193);
            this.SpriteNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpriteNumberLabel.Name = "SpriteNumberLabel";
            this.SpriteNumberLabel.Size = new System.Drawing.Size(155, 17);
            this.SpriteNumberLabel.TabIndex = 16;
            this.SpriteNumberLabel.Text = "Количество спрайтов:";
            // 
            // SpriteNumberTextBox
            // 
            this.SpriteNumberTextBox.Location = new System.Drawing.Point(9, 213);
            this.SpriteNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpriteNumberTextBox.Name = "SpriteNumberTextBox";
            this.SpriteNumberTextBox.Size = new System.Drawing.Size(109, 22);
            this.SpriteNumberTextBox.TabIndex = 15;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(247, 193);
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
            this.LabelPic.Location = new System.Drawing.Point(168, 193);
            this.LabelPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPic.Name = "LabelPic";
            this.LabelPic.Size = new System.Drawing.Size(75, 17);
            this.LabelPic.TabIndex = 12;
            this.LabelPic.Text = "Картинка:";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(25, 79);
            this.LabelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(67, 17);
            this.LabelTime.TabIndex = 11;
            this.LabelTime.Text = "Тайминг:";
            // 
            // LabelDef2
            // 
            this.LabelDef2.AutoSize = true;
            this.LabelDef2.Location = new System.Drawing.Point(320, 79);
            this.LabelDef2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDef2.Name = "LabelDef2";
            this.LabelDef2.Size = new System.Drawing.Size(18, 17);
            this.LabelDef2.TabIndex = 10;
            this.LabelDef2.Text = "--";
            // 
            // LabelDef1
            // 
            this.LabelDef1.AutoSize = true;
            this.LabelDef1.Location = new System.Drawing.Point(320, 43);
            this.LabelDef1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDef1.Name = "LabelDef1";
            this.LabelDef1.Size = new System.Drawing.Size(18, 17);
            this.LabelDef1.TabIndex = 9;
            this.LabelDef1.Text = "--";
            // 
            // LabelWalls
            // 
            this.LabelWalls.AutoSize = true;
            this.LabelWalls.Location = new System.Drawing.Point(25, 43);
            this.LabelWalls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWalls.Name = "LabelWalls";
            this.LabelWalls.Size = new System.Drawing.Size(138, 17);
            this.LabelWalls.TabIndex = 8;
            this.LabelWalls.Text = "Границы движения:";
            // 
            // TextBoxTime1
            // 
            this.TextBoxTime1.Location = new System.Drawing.Point(176, 75);
            this.TextBoxTime1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxTime1.Name = "TextBoxTime1";
            this.TextBoxTime1.Size = new System.Drawing.Size(132, 22);
            this.TextBoxTime1.TabIndex = 5;
            // 
            // TextBoxTime2
            // 
            this.TextBoxTime2.Location = new System.Drawing.Point(345, 75);
            this.TextBoxTime2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxTime2.Name = "TextBoxTime2";
            this.TextBoxTime2.Size = new System.Drawing.Size(132, 22);
            this.TextBoxTime2.TabIndex = 4;
            // 
            // TextBoxWall2
            // 
            this.TextBoxWall2.Location = new System.Drawing.Point(345, 39);
            this.TextBoxWall2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxWall2.Name = "TextBoxWall2";
            this.TextBoxWall2.Size = new System.Drawing.Size(132, 22);
            this.TextBoxWall2.TabIndex = 3;
            this.TextBoxWall2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWall1_KeyPress);
            // 
            // TextBoxWall1
            // 
            this.TextBoxWall1.Location = new System.Drawing.Point(176, 39);
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
            "Диагонально",
            "Волнами",
            "Кругами"});
            this.ComboBoxMove.Location = new System.Drawing.Point(148, 4);
            this.ComboBoxMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxMove.Name = "ComboBoxMove";
            this.ComboBoxMove.Size = new System.Drawing.Size(160, 24);
            this.ComboBoxMove.TabIndex = 1;
            this.ComboBoxMove.Text = "Прямо";
            this.ComboBoxMove.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMove_SelectedIndexChanged);
            // 
            // LabelMoveType
            // 
            this.LabelMoveType.AutoSize = true;
            this.LabelMoveType.Location = new System.Drawing.Point(31, 4);
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
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.leftPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = "Свойства персонажа";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBackground)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.personPanel.ResumeLayout(false);
            this.personPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openSpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelData;
        private System.Windows.Forms.Label LabelLengh;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox nazvanieTextBox;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Button SaveMultButton;
        private System.Windows.Forms.Button ButtonAddChar;
        private System.Windows.Forms.Panel personPanel;
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
        private System.Windows.Forms.Label Char_Info;
        private System.Windows.Forms.PictureBox openSpace;
        private System.Windows.Forms.Label Char_Stats;
        private System.Windows.Forms.TextBox charNameBox;
        private System.Windows.Forms.Label charNameLabel;
        private System.Windows.Forms.TextBox circlesTextBox;
        private System.Windows.Forms.Label circlesLabel;
    }
}