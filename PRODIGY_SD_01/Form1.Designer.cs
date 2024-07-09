namespace PRODIGY_SD_01
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            titleLabel = new Label();
            temp1Label = new Label();
            unit1Label = new Label();
            unit1ComboBox = new ComboBox();
            temp1TextBox = new TextBox();
            temp2TextBox = new TextBox();
            unit2ComboBox = new ComboBox();
            unit2Label = new Label();
            temp2Label = new Label();
            buttonsPanel = new Panel();
            clearButton = new Button();
            deleteButton = new Button();
            button_7 = new Button();
            button_8 = new Button();
            button_9 = new Button();
            button_6 = new Button();
            button_5 = new Button();
            button_4 = new Button();
            button_3 = new Button();
            button_2 = new Button();
            button_1 = new Button();
            dotButton = new Button();
            button_0 = new Button();
            plusMinusButton = new Button();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.FlatStyle = FlatStyle.System;
            titleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(220, 30);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Temperature Converter";
            // 
            // temp1Label
            // 
            temp1Label.AutoSize = true;
            temp1Label.Location = new Point(12, 76);
            temp1Label.Name = "temp1Label";
            temp1Label.Size = new Size(73, 15);
            temp1Label.TabIndex = 1;
            temp1Label.Text = "Temperature";
            // 
            // unit1Label
            // 
            unit1Label.AutoSize = true;
            unit1Label.Location = new Point(12, 109);
            unit1Label.Name = "unit1Label";
            unit1Label.Size = new Size(29, 15);
            unit1Label.TabIndex = 2;
            unit1Label.Text = "Unit";
            // 
            // unit1ComboBox
            // 
            unit1ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unit1ComboBox.FormattingEnabled = true;
            unit1ComboBox.Location = new Point(91, 106);
            unit1ComboBox.Name = "unit1ComboBox";
            unit1ComboBox.Size = new Size(100, 23);
            unit1ComboBox.TabIndex = 3;
            // 
            // temp1TextBox
            // 
            temp1TextBox.BackColor = SystemColors.Window;
            temp1TextBox.Cursor = Cursors.IBeam;
            temp1TextBox.Location = new Point(91, 68);
            temp1TextBox.Name = "temp1TextBox";
            temp1TextBox.Size = new Size(100, 23);
            temp1TextBox.TabIndex = 4;
            // 
            // temp2TextBox
            // 
            temp2TextBox.Cursor = Cursors.IBeam;
            temp2TextBox.Location = new Point(91, 171);
            temp2TextBox.Name = "temp2TextBox";
            temp2TextBox.ReadOnly = true;
            temp2TextBox.Size = new Size(100, 23);
            temp2TextBox.TabIndex = 8;
            // 
            // unit2ComboBox
            // 
            unit2ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unit2ComboBox.FormattingEnabled = true;
            unit2ComboBox.Location = new Point(91, 219);
            unit2ComboBox.Name = "unit2ComboBox";
            unit2ComboBox.Size = new Size(100, 23);
            unit2ComboBox.TabIndex = 7;
            // 
            // unit2Label
            // 
            unit2Label.AutoSize = true;
            unit2Label.Location = new Point(12, 222);
            unit2Label.Name = "unit2Label";
            unit2Label.Size = new Size(29, 15);
            unit2Label.TabIndex = 6;
            unit2Label.Text = "Unit";
            // 
            // temp2Label
            // 
            temp2Label.AutoSize = true;
            temp2Label.Location = new Point(12, 174);
            temp2Label.Name = "temp2Label";
            temp2Label.Size = new Size(73, 15);
            temp2Label.TabIndex = 5;
            temp2Label.Text = "Temperature";
            // 
            // buttonsPanel
            // 
            buttonsPanel.AutoSize = true;
            buttonsPanel.Controls.Add(clearButton);
            buttonsPanel.Controls.Add(deleteButton);
            buttonsPanel.Controls.Add(button_7);
            buttonsPanel.Controls.Add(button_8);
            buttonsPanel.Controls.Add(button_9);
            buttonsPanel.Controls.Add(button_6);
            buttonsPanel.Controls.Add(button_5);
            buttonsPanel.Controls.Add(button_4);
            buttonsPanel.Controls.Add(button_3);
            buttonsPanel.Controls.Add(button_2);
            buttonsPanel.Controls.Add(button_1);
            buttonsPanel.Controls.Add(dotButton);
            buttonsPanel.Controls.Add(button_0);
            buttonsPanel.Controls.Add(plusMinusButton);
            buttonsPanel.Dock = DockStyle.Bottom;
            buttonsPanel.Location = new Point(0, 266);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(364, 215);
            buttonsPanel.TabIndex = 9;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            clearButton.Location = new Point(126, 11);
            clearButton.Name = "clearButton";
            clearButton.RightToLeft = RightToLeft.Yes;
            clearButton.Size = new Size(110, 34);
            clearButton.TabIndex = 13;
            clearButton.Text = "CE";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            deleteButton.Location = new Point(242, 11);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(110, 34);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Del";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // button_7
            // 
            button_7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button_7.Location = new Point(10, 51);
            button_7.Name = "button_7";
            button_7.Size = new Size(110, 34);
            button_7.TabIndex = 11;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = true;
            button_7.Click += button_7_Click;
            // 
            // button_8
            // 
            button_8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button_8.Location = new Point(126, 51);
            button_8.Name = "button_8";
            button_8.Size = new Size(110, 34);
            button_8.TabIndex = 10;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = true;
            button_8.Click += button_8_Click;
            // 
            // button_9
            // 
            button_9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button_9.Location = new Point(242, 51);
            button_9.Name = "button_9";
            button_9.Size = new Size(110, 34);
            button_9.TabIndex = 9;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = true;
            button_9.Click += button_9_Click;
            // 
            // button_6
            // 
            button_6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button_6.Location = new Point(242, 91);
            button_6.Name = "button_6";
            button_6.Size = new Size(110, 37);
            button_6.TabIndex = 8;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = true;
            button_6.Click += button_6_Click;
            // 
            // button_5
            // 
            button_5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button_5.Location = new Point(126, 91);
            button_5.Name = "button_5";
            button_5.Size = new Size(110, 37);
            button_5.TabIndex = 7;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = true;
            button_5.Click += button_5_Click;
            // 
            // button_4
            // 
            button_4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button_4.Location = new Point(10, 91);
            button_4.Name = "button_4";
            button_4.Size = new Size(110, 37);
            button_4.TabIndex = 6;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = true;
            button_4.Click += button_4_Click;
            // 
            // button_3
            // 
            button_3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button_3.Location = new Point(242, 134);
            button_3.Name = "button_3";
            button_3.Size = new Size(110, 38);
            button_3.TabIndex = 5;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = true;
            button_3.Click += button_3_Click;
            // 
            // button_2
            // 
            button_2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button_2.Location = new Point(126, 134);
            button_2.Name = "button_2";
            button_2.Size = new Size(110, 38);
            button_2.TabIndex = 4;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = true;
            button_2.Click += button_2_Click;
            // 
            // button_1
            // 
            button_1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button_1.Location = new Point(10, 134);
            button_1.Name = "button_1";
            button_1.Size = new Size(110, 38);
            button_1.TabIndex = 3;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += button_1_Click;
            // 
            // dotButton
            // 
            dotButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dotButton.Location = new Point(242, 178);
            dotButton.Name = "dotButton";
            dotButton.Size = new Size(110, 34);
            dotButton.TabIndex = 2;
            dotButton.Text = ".";
            dotButton.UseVisualStyleBackColor = true;
            dotButton.Click += dotButton_Click;
            // 
            // button_0
            // 
            button_0.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button_0.Location = new Point(126, 178);
            button_0.Name = "button_0";
            button_0.Size = new Size(110, 34);
            button_0.TabIndex = 1;
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = true;
            button_0.Click += button_0_Click;
            // 
            // plusMinusButton
            // 
            plusMinusButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            plusMinusButton.Location = new Point(10, 178);
            plusMinusButton.Name = "plusMinusButton";
            plusMinusButton.Size = new Size(110, 34);
            plusMinusButton.TabIndex = 0;
            plusMinusButton.Text = "+/-";
            plusMinusButton.UseVisualStyleBackColor = true;
            plusMinusButton.Click += plusMinusButton_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(364, 481);
            Controls.Add(buttonsPanel);
            Controls.Add(temp2TextBox);
            Controls.Add(unit2ComboBox);
            Controls.Add(unit2Label);
            Controls.Add(temp2Label);
            Controls.Add(temp1TextBox);
            Controls.Add(unit1ComboBox);
            Controls.Add(unit1Label);
            Controls.Add(temp1Label);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Temperature Converter";
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label temp1Label;
        private Label unit1Label;
        private ComboBox unit1ComboBox;
        private TextBox temp1TextBox;
        private TextBox temp2TextBox;
        private ComboBox unit2ComboBox;
        private Label unit2Label;
        private Label temp2Label;
        private Panel buttonsPanel;
        private Button clearButton;
        private Button deleteButton;
        private Button button_7;
        private Button button_8;
        private Button button_9;
        private Button button_6;
        private Button button_5;
        private Button button_4;
        private Button button_3;
        private Button button_2;
        private Button button_1;
        private Button dotButton;
        private Button button_0;
        private Button plusMinusButton;
    }
}
