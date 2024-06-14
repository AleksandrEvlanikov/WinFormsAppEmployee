namespace WinFormsAppEmployee.Forms
{
    partial class FormStatisticsEmployee
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
            comboBoxStatus = new ComboBox();
            labelStatusStatistics = new Label();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            labelDateFrom = new Label();
            labelDateTo = new Label();
            buttonPullStatistics = new Button();
            dataGridViewStatistics = new DataGridView();
            radioButtonEmployed = new RadioButton();
            radioButtonUnemployed = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatistics).BeginInit();
            SuspendLayout();
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(12, 59);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 0;
            // 
            // labelStatusStatistics
            // 
            labelStatusStatistics.AutoSize = true;
            labelStatusStatistics.Location = new Point(12, 34);
            labelStatusStatistics.Name = "labelStatusStatistics";
            labelStatusStatistics.Size = new Size(122, 20);
            labelStatusStatistics.TabIndex = 1;
            labelStatusStatistics.Text = "Выберете статус";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(190, 59);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(250, 27);
            dateTimePickerFrom.TabIndex = 2;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(475, 60);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(250, 27);
            dateTimePickerTo.TabIndex = 3;
            // 
            // labelDateFrom
            // 
            labelDateFrom.AutoSize = true;
            labelDateFrom.Location = new Point(190, 31);
            labelDateFrom.Name = "labelDateFrom";
            labelDateFrom.Size = new Size(63, 20);
            labelDateFrom.TabIndex = 4;
            labelDateFrom.Text = "Дата от:";
            // 
            // labelDateTo
            // 
            labelDateTo.AutoSize = true;
            labelDateTo.Location = new Point(475, 31);
            labelDateTo.Name = "labelDateTo";
            labelDateTo.Size = new Size(66, 20);
            labelDateTo.TabIndex = 5;
            labelDateTo.Text = "Дата по:";
            // 
            // buttonPullStatistics
            // 
            buttonPullStatistics.Location = new Point(556, 125);
            buttonPullStatistics.Name = "buttonPullStatistics";
            buttonPullStatistics.Size = new Size(169, 53);
            buttonPullStatistics.TabIndex = 6;
            buttonPullStatistics.Text = "Получить статистику";
            buttonPullStatistics.UseVisualStyleBackColor = true;
            buttonPullStatistics.Click += buttonPullStatistics_Click;
            // 
            // dataGridViewStatistics
            // 
            dataGridViewStatistics.AllowUserToOrderColumns = true;
            dataGridViewStatistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatistics.Location = new Point(12, 202);
            dataGridViewStatistics.Name = "dataGridViewStatistics";
            dataGridViewStatistics.RowHeadersWidth = 51;
            dataGridViewStatistics.Size = new Size(776, 213);
            dataGridViewStatistics.TabIndex = 7;
            dataGridViewStatistics.Visible = false;
            // 
            // radioButtonEmployed
            // 
            radioButtonEmployed.AutoSize = true;
            radioButtonEmployed.Location = new Point(17, 125);
            radioButtonEmployed.Name = "radioButtonEmployed";
            radioButtonEmployed.Size = new Size(166, 24);
            radioButtonEmployed.TabIndex = 8;
            radioButtonEmployed.TabStop = true;
            radioButtonEmployed.Text = "Приняты на работу";
            radioButtonEmployed.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnemployed
            // 
            radioButtonUnemployed.AutoSize = true;
            radioButtonUnemployed.Location = new Point(240, 125);
            radioButtonUnemployed.Name = "radioButtonUnemployed";
            radioButtonUnemployed.Size = new Size(159, 24);
            radioButtonUnemployed.TabIndex = 9;
            radioButtonUnemployed.TabStop = true;
            radioButtonUnemployed.Text = "Уволены с работы";
            radioButtonUnemployed.UseVisualStyleBackColor = true;
            // 
            // FormStatisticsEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButtonUnemployed);
            Controls.Add(radioButtonEmployed);
            Controls.Add(dataGridViewStatistics);
            Controls.Add(buttonPullStatistics);
            Controls.Add(labelDateTo);
            Controls.Add(labelDateFrom);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(labelStatusStatistics);
            Controls.Add(comboBoxStatus);
            Name = "FormStatisticsEmployee";
            Text = "FormStatisticsEmployee";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatistics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxStatus;
        private Label labelStatusStatistics;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Label labelDateFrom;
        private Label labelDateTo;
        private Button buttonPullStatistics;
        private DataGridView dataGridViewStatistics;
        private RadioButton radioButtonEmployed;
        private RadioButton radioButtonUnemployed;
    }
}