namespace GetValuteUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AutoClear = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Info;
            this.btn1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(58, 82);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(91, 67);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "USD";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.buttonGetInfo);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Info;
            this.btn2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(58, 182);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(91, 67);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "EUR";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.buttonGetInfo);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Info;
            this.btn3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(58, 302);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(91, 67);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "GBP";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.buttonGetInfo);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Info;
            this.btn4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(58, 409);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(91, 67);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "JPY";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.buttonGetInfo);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(759, 520);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 56);
            this.button5.TabIndex = 4;
            this.button5.Text = "Очистить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonClearInfo);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.Location = new System.Drawing.Point(286, 82);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(570, 394);
            this.richTextBox.TabIndex = 5;
            this.richTextBox.Text = "";
            // 
            // AutoClear
            // 
            this.AutoClear.AutoSize = true;
            this.AutoClear.Location = new System.Drawing.Point(612, 484);
            this.AutoClear.Name = "AutoClear";
            this.AutoClear.Size = new System.Drawing.Size(254, 37);
            this.AutoClear.TabIndex = 6;
            this.AutoClear.Text = "автоматическая очистка";
            this.AutoClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(907, 616);
            this.Controls.Add(this.AutoClear);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Курсы валют";
            this.Click += new System.EventHandler(this.buttonGetInfo);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button button5;
        private RichTextBox richTextBox;
        private ToolTip toolTip;
        private CheckBox AutoClear;
    }
}