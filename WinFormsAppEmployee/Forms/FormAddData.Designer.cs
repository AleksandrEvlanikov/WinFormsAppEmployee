namespace WinFormsAppEmployee.Forms
{
    partial class FormAddData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            buttonAddPerson = new Button();
            buttonAddPosts = new Button();
            buttonAddDep = new Button();
            buttonAddStatus = new Button();
            textInput = new TextBox();
            label1 = new Label();
            buttonAddInputData = new Button();
            labelInfoPerson = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(754, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = "Что будем добавлять?\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAddPerson
            // 
            buttonAddPerson.Location = new Point(12, 126);
            buttonAddPerson.Name = "buttonAddPerson";
            buttonAddPerson.Size = new Size(101, 29);
            buttonAddPerson.TabIndex = 1;
            buttonAddPerson.Text = "Сотрудника";
            buttonAddPerson.UseVisualStyleBackColor = true;
            buttonAddPerson.Click += buttonAddPerson_Click;
            // 
            // buttonAddPosts
            // 
            buttonAddPosts.Location = new Point(442, 126);
            buttonAddPosts.Name = "buttonAddPosts";
            buttonAddPosts.Size = new Size(98, 29);
            buttonAddPosts.TabIndex = 2;
            buttonAddPosts.Text = "Должность";
            buttonAddPosts.UseVisualStyleBackColor = true;
            buttonAddPosts.Click += buttonAddPosts_Click;
            // 
            // buttonAddDep
            // 
            buttonAddDep.Location = new Point(650, 126);
            buttonAddDep.Name = "buttonAddDep";
            buttonAddDep.Size = new Size(116, 29);
            buttonAddDep.TabIndex = 3;
            buttonAddDep.Text = "Депортамент";
            buttonAddDep.UseVisualStyleBackColor = true;
            buttonAddDep.Click += buttonAddDep_Click;
            // 
            // buttonAddStatus
            // 
            buttonAddStatus.Location = new Point(216, 126);
            buttonAddStatus.Name = "buttonAddStatus";
            buttonAddStatus.Size = new Size(94, 29);
            buttonAddStatus.TabIndex = 4;
            buttonAddStatus.Text = "Статус";
            buttonAddStatus.UseVisualStyleBackColor = true;
            buttonAddStatus.Click += buttonAddStatus_Click;
            // 
            // textInput
            // 
            textInput.Location = new Point(12, 256);
            textInput.Multiline = true;
            textInput.Name = "textInput";
            textInput.Size = new Size(766, 68);
            textInput.TabIndex = 5;
            textInput.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 233);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // buttonAddInputData
            // 
            buttonAddInputData.Location = new Point(665, 360);
            buttonAddInputData.Name = "buttonAddInputData";
            buttonAddInputData.Size = new Size(113, 48);
            buttonAddInputData.TabIndex = 7;
            buttonAddInputData.Text = "Отправить";
            buttonAddInputData.UseVisualStyleBackColor = true;
            buttonAddInputData.Visible = false;
            buttonAddInputData.Click += buttonAddInputData_Click;
            // 
            // labelInfoPerson
            // 
            labelInfoPerson.AutoSize = true;
            labelInfoPerson.Location = new Point(12, 327);
            labelInfoPerson.Name = "labelInfoPerson";
            labelInfoPerson.Size = new Size(50, 20);
            labelInfoPerson.TabIndex = 8;
            labelInfoPerson.Text = "label2";
            labelInfoPerson.Visible = false;
            // 
            // FormAddData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelInfoPerson);
            Controls.Add(buttonAddInputData);
            Controls.Add(label1);
            Controls.Add(textInput);
            Controls.Add(buttonAddStatus);
            Controls.Add(buttonAddDep);
            Controls.Add(buttonAddPosts);
            Controls.Add(buttonAddPerson);
            Controls.Add(textBox1);
            Name = "FormAddData";
            Text = "FormAddData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonAddPerson;
        private Button buttonAddPosts;
        private Button buttonAddDep;
        private Button buttonAddStatus;
        private TextBox textInput;
        private Label label1;
        private Button buttonAddInputData;
        private Label labelInfoPerson;
    }
}