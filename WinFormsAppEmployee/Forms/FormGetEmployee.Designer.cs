namespace WinFormsAppEmployee.Forms
{
    partial class FormGetEmployee
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
            dataGridViewDataEmployee = new DataGridView();
            comboBoxFiltrEmployee = new ComboBox();
            label1 = new Label();
            buttonApplyFiltr = new Button();
            labelFiltr = new Label();
            textBoxFiltr = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataEmployee).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDataEmployee
            // 
            dataGridViewDataEmployee.AllowUserToOrderColumns = true;
            dataGridViewDataEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataEmployee.Location = new Point(12, 12);
            dataGridViewDataEmployee.Name = "dataGridViewDataEmployee";
            dataGridViewDataEmployee.RowHeadersWidth = 51;
            dataGridViewDataEmployee.Size = new Size(776, 316);
            dataGridViewDataEmployee.TabIndex = 0;
            // 
            // comboBoxFiltrEmployee
            // 
            comboBoxFiltrEmployee.FormattingEnabled = true;
            comboBoxFiltrEmployee.Items.AddRange(new object[] { "Статусу", "Отделу", "Должности", "Фамилии" });
            comboBoxFiltrEmployee.Location = new Point(12, 371);
            comboBoxFiltrEmployee.Name = "comboBoxFiltrEmployee";
            comboBoxFiltrEmployee.Size = new Size(113, 28);
            comboBoxFiltrEmployee.TabIndex = 1;
            comboBoxFiltrEmployee.SelectedIndexChanged += comboBoxFiltrEmployee_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 347);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 2;
            label1.Text = "Фильтровать по";
            // 
            // buttonApplyFiltr
            // 
            buttonApplyFiltr.Location = new Point(635, 347);
            buttonApplyFiltr.Name = "buttonApplyFiltr";
            buttonApplyFiltr.Size = new Size(153, 52);
            buttonApplyFiltr.TabIndex = 3;
            buttonApplyFiltr.Text = "Применить фильтр";
            buttonApplyFiltr.UseVisualStyleBackColor = true;
            buttonApplyFiltr.Click += buttonApplyFiltr_Click;
            // 
            // labelFiltr
            // 
            labelFiltr.AutoSize = true;
            labelFiltr.Location = new Point(213, 347);
            labelFiltr.Name = "labelFiltr";
            labelFiltr.Size = new Size(50, 20);
            labelFiltr.TabIndex = 4;
            labelFiltr.Text = "label2";
            labelFiltr.Visible = false;
            // 
            // textBoxFiltr
            // 
            textBoxFiltr.Location = new Point(213, 372);
            textBoxFiltr.Name = "textBoxFiltr";
            textBoxFiltr.Size = new Size(320, 27);
            textBoxFiltr.TabIndex = 6;
            textBoxFiltr.Visible = false;
            // 
            // FormGetEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxFiltr);
            Controls.Add(labelFiltr);
            Controls.Add(buttonApplyFiltr);
            Controls.Add(label1);
            Controls.Add(comboBoxFiltrEmployee);
            Controls.Add(dataGridViewDataEmployee);
            Name = "FormGetEmployee";
            Text = "FormGetEmployee";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDataEmployee;
        private ComboBox comboBoxFiltrEmployee;
        private Label label1;
        private Button buttonApplyFiltr;
        private Label labelFiltr;
        private TextBox textBoxFiltr;
    }
}