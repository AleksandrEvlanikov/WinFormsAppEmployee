namespace WinFormsAppEmployee
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
            buttonAddData = new Button();
            textBox1 = new TextBox();
            buttonGetEmployee = new Button();
            buttonStatisticsEmployee = new Button();
            SuspendLayout();
            // 
            // buttonAddData
            // 
            buttonAddData.Location = new Point(643, 86);
            buttonAddData.Name = "buttonAddData";
            buttonAddData.Size = new Size(124, 57);
            buttonAddData.TabIndex = 0;
            buttonAddData.Text = "Добавить";
            buttonAddData.UseVisualStyleBackColor = true;
            buttonAddData.Click += buttonAddData_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(737, 35);
            textBox1.TabIndex = 1;
            textBox1.Text = "Что хотите сделать?\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonGetEmployee
            // 
            buttonGetEmployee.Location = new Point(334, 86);
            buttonGetEmployee.Name = "buttonGetEmployee";
            buttonGetEmployee.Size = new Size(121, 53);
            buttonGetEmployee.TabIndex = 2;
            buttonGetEmployee.Text = "Получить";
            buttonGetEmployee.UseVisualStyleBackColor = true;
            buttonGetEmployee.Click += buttonGetEmployee_Click;
            // 
            // buttonStatisticsEmployee
            // 
            buttonStatisticsEmployee.Location = new Point(30, 86);
            buttonStatisticsEmployee.Name = "buttonStatisticsEmployee";
            buttonStatisticsEmployee.Size = new Size(121, 53);
            buttonStatisticsEmployee.TabIndex = 3;
            buttonStatisticsEmployee.Text = "Статистика";
            buttonStatisticsEmployee.UseVisualStyleBackColor = true;
            buttonStatisticsEmployee.Click += buttonStatisticsEmployee_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStatisticsEmployee);
            Controls.Add(buttonGetEmployee);
            Controls.Add(textBox1);
            Controls.Add(buttonAddData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddData;
        private TextBox textBox1;
        private Button buttonGetEmployee;
        private Button buttonStatisticsEmployee;
    }
}
