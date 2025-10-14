namespace WinFormSportSchool
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteTraineee_button = new System.Windows.Forms.Button();
            this.AddTrainee_button = new System.Windows.Forms.Button();
            this.tableListTrainees_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableListTrainees_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteTraineee_button
            // 
            this.DeleteTraineee_button.Location = new System.Drawing.Point(140, 169);
            this.DeleteTraineee_button.Name = "DeleteTraineee_button";
            this.DeleteTraineee_button.Size = new System.Drawing.Size(122, 23);
            this.DeleteTraineee_button.TabIndex = 5;
            this.DeleteTraineee_button.Text = "Удалить ученика";
            this.DeleteTraineee_button.UseVisualStyleBackColor = true;
            this.DeleteTraineee_button.Click += new System.EventHandler(this.DeleteTraineee_button_Click);
            // 
            // AddTrainee_button
            // 
            this.AddTrainee_button.Location = new System.Drawing.Point(12, 169);
            this.AddTrainee_button.Name = "AddTrainee_button";
            this.AddTrainee_button.Size = new System.Drawing.Size(122, 23);
            this.AddTrainee_button.TabIndex = 4;
            this.AddTrainee_button.Text = "Добавить ученика";
            this.AddTrainee_button.UseVisualStyleBackColor = true;
            this.AddTrainee_button.Click += new System.EventHandler(this.AddTrainee_button_Click);
            // 
            // tableListTrainees_dataGridView
            // 
            this.tableListTrainees_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableListTrainees_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableListTrainees_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableListTrainees_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.tableListTrainees_dataGridView.Name = "tableListTrainees_dataGridView";
            this.tableListTrainees_dataGridView.Size = new System.Drawing.Size(775, 150);
            this.tableListTrainees_dataGridView.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteTraineee_button);
            this.Controls.Add(this.AddTrainee_button);
            this.Controls.Add(this.tableListTrainees_dataGridView);
            this.Name = "MainForm";
            this.Text = "Спортивная школа";
            ((System.ComponentModel.ISupportInitialize)(this.tableListTrainees_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteTraineee_button;
        private System.Windows.Forms.Button AddTrainee_button;
        private System.Windows.Forms.DataGridView tableListTrainees_dataGridView;
    }
}

