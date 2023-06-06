namespace Downloader
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Minimise = new Button();
            Exit = new Button();
            panel2 = new Panel();
            FileDialogButton = new Button();
            Formatlable = new Label();
            FilelocationLable = new Label();
            UrlLable = new Label();
            StartDownload = new Button();
            FormatSelect = new ComboBox();
            FileLocation = new TextBox();
            LinkInput = new TextBox();
            FolderBrowserDialog = new FolderBrowserDialog();
            pictureBox1 = new PictureBox();
            WaitingText = new Label();
            consoleOutputbox = new RichTextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(71, 78, 104);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Minimise);
            panel1.Controls.Add(Exit);
            panel1.Location = new Point(-12, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 47);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Minimise
            // 
            Minimise.FlatAppearance.BorderColor = Color.FromArgb(71, 78, 104);
            Minimise.FlatAppearance.BorderSize = 0;
            Minimise.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 66, 88);
            Minimise.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 87, 122);
            Minimise.FlatStyle = FlatStyle.Flat;
            Minimise.Image = Properties.Resources.menu_burger;
            Minimise.Location = new Point(724, 8);
            Minimise.Name = "Minimise";
            Minimise.Size = new Size(46, 39);
            Minimise.TabIndex = 2;
            Minimise.UseVisualStyleBackColor = true;
            Minimise.Click += Minimise_Click;
            // 
            // Exit
            // 
            Exit.FlatAppearance.BorderColor = Color.FromArgb(71, 78, 104);
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 66, 88);
            Exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 87, 122);
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Image = Properties.Resources.cross;
            Exit.Location = new Point(767, 8);
            Exit.Name = "Exit";
            Exit.Size = new Size(46, 39);
            Exit.TabIndex = 1;
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(71, 78, 104);
            panel2.Controls.Add(FileDialogButton);
            panel2.Controls.Add(Formatlable);
            panel2.Controls.Add(FilelocationLable);
            panel2.Controls.Add(UrlLable);
            panel2.Controls.Add(StartDownload);
            panel2.Controls.Add(FormatSelect);
            panel2.Controls.Add(FileLocation);
            panel2.Controls.Add(LinkInput);
            panel2.Location = new Point(-9, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(412, 428);
            panel2.TabIndex = 1;
            // 
            // FileDialogButton
            // 
            FileDialogButton.BackColor = Color.FromArgb(107, 114, 142);
            FileDialogButton.FlatAppearance.BorderSize = 0;
            FileDialogButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(71, 78, 104);
            FileDialogButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(107, 114, 142);
            FileDialogButton.FlatStyle = FlatStyle.Flat;
            FileDialogButton.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FileDialogButton.ForeColor = Color.White;
            FileDialogButton.Location = new Point(371, 81);
            FileDialogButton.Name = "FileDialogButton";
            FileDialogButton.Size = new Size(28, 20);
            FileDialogButton.TabIndex = 0;
            FileDialogButton.Text = "...";
            FileDialogButton.UseVisualStyleBackColor = false;
            FileDialogButton.Click += FileDialogButton_Click;
            // 
            // Formatlable
            // 
            Formatlable.AutoSize = true;
            Formatlable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Formatlable.ForeColor = Color.White;
            Formatlable.Location = new Point(21, 119);
            Formatlable.Name = "Formatlable";
            Formatlable.Size = new Size(58, 18);
            Formatlable.TabIndex = 6;
            Formatlable.Text = "Format";
            // 
            // FilelocationLable
            // 
            FilelocationLable.AutoSize = true;
            FilelocationLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FilelocationLable.ForeColor = Color.White;
            FilelocationLable.Location = new Point(21, 60);
            FilelocationLable.Name = "FilelocationLable";
            FilelocationLable.Size = new Size(34, 18);
            FilelocationLable.TabIndex = 5;
            FilelocationLable.Text = "File";
            // 
            // UrlLable
            // 
            UrlLable.AutoSize = true;
            UrlLable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UrlLable.ForeColor = Color.White;
            UrlLable.Location = new Point(21, 3);
            UrlLable.Name = "UrlLable";
            UrlLable.Size = new Size(27, 18);
            UrlLable.TabIndex = 4;
            UrlLable.Text = "Url";
            // 
            // StartDownload
            // 
            StartDownload.BackColor = Color.FromArgb(80, 87, 122);
            StartDownload.FlatAppearance.BorderSize = 0;
            StartDownload.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 66, 88);
            StartDownload.FlatAppearance.MouseOverBackColor = Color.FromArgb(107, 114, 142);
            StartDownload.FlatStyle = FlatStyle.Flat;
            StartDownload.Font = new Font("Arial", 25F, FontStyle.Regular, GraphicsUnit.Point);
            StartDownload.ForeColor = Color.White;
            StartDownload.Location = new Point(21, 212);
            StartDownload.Name = "StartDownload";
            StartDownload.Size = new Size(378, 120);
            StartDownload.TabIndex = 3;
            StartDownload.Text = "Start";
            StartDownload.UseVisualStyleBackColor = false;
            StartDownload.Click += StartDownload_Click;
            // 
            // FormatSelect
            // 
            FormatSelect.BackColor = Color.FromArgb(80, 87, 122);
            FormatSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            FormatSelect.FlatStyle = FlatStyle.Flat;
            FormatSelect.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormatSelect.ForeColor = Color.White;
            FormatSelect.FormattingEnabled = true;
            FormatSelect.Items.AddRange(new object[] { "mp3", "mp4", "mkv", "webm" });
            FormatSelect.Location = new Point(21, 140);
            FormatSelect.Name = "FormatSelect";
            FormatSelect.Size = new Size(121, 22);
            FormatSelect.TabIndex = 2;
            // 
            // FileLocation
            // 
            FileLocation.BackColor = Color.FromArgb(80, 87, 122);
            FileLocation.BorderStyle = BorderStyle.FixedSingle;
            FileLocation.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FileLocation.ForeColor = Color.White;
            FileLocation.Location = new Point(21, 81);
            FileLocation.Name = "FileLocation";
            FileLocation.Size = new Size(378, 20);
            FileLocation.TabIndex = 1;
            // 
            // LinkInput
            // 
            LinkInput.BackColor = Color.FromArgb(80, 87, 122);
            LinkInput.BorderStyle = BorderStyle.FixedSingle;
            LinkInput.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LinkInput.ForeColor = Color.White;
            LinkInput.Location = new Point(21, 24);
            LinkInput.Name = "LinkInput";
            LinkInput.Size = new Size(378, 20);
            LinkInput.TabIndex = 0;
            // 
            // FolderBrowserDialog
            // 
            FolderBrowserDialog.HelpRequest += FolderBrowserDialog_HelpRequest;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Robo_Meme_The_bois;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(562, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 92);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // WaitingText
            // 
            WaitingText.AutoSize = true;
            WaitingText.Font = new Font("Arial", 34F, FontStyle.Regular, GraphicsUnit.Point);
            WaitingText.ForeColor = Color.White;
            WaitingText.Location = new Point(464, 166);
            WaitingText.Name = "WaitingText";
            WaitingText.Size = new Size(273, 52);
            WaitingText.TabIndex = 7;
            WaitingText.Text = "Standing By";
            WaitingText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // consoleOutputbox
            // 
            consoleOutputbox.BackColor = Color.FromArgb(71, 78, 104);
            consoleOutputbox.BorderStyle = BorderStyle.None;
            consoleOutputbox.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            consoleOutputbox.ForeColor = Color.White;
            consoleOutputbox.Location = new Point(422, 221);
            consoleOutputbox.Name = "consoleOutputbox";
            consoleOutputbox.Size = new Size(366, 146);
            consoleOutputbox.TabIndex = 8;
            consoleOutputbox.Text = "";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Robo_Meme_The_boissma;
            pictureBox2.Location = new Point(15, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 36);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 13);
            label1.Name = "label1";
            label1.Size = new Size(182, 23);
            label1.TabIndex = 4;
            label1.Text = "Robo's Downloader";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 66, 88);
            ClientSize = new Size(800, 379);
            Controls.Add(consoleOutputbox);
            Controls.Add(WaitingText);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Downloader";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Exit;
        private Button Minimise;
        private Panel panel2;
        private Button StartDownload;
        private ComboBox FormatSelect;
        private TextBox FileLocation;
        private TextBox LinkInput;
        private Label Formatlable;
        private Label FilelocationLable;
        private Label UrlLable;
        private Button FileDialogButton;
        private FolderBrowserDialog FolderBrowserDialog;
        private PictureBox pictureBox1;
        private Label WaitingText;
        private RichTextBox consoleOutputbox;
        private PictureBox pictureBox2;
        private Label label1;
    }
}