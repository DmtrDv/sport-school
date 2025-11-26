namespace WinFormSportSchool.inventories
{
    partial class EditInventoryForm
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
            this.DateDelivery_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Count_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Count_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DateDelivery_dateTimePicker
            // 
            this.DateDelivery_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateDelivery_dateTimePicker.Location = new System.Drawing.Point(140, 79);
            this.DateDelivery_dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateDelivery_dateTimePicker.Name = "DateDelivery_dateTimePicker";
            this.DateDelivery_dateTimePicker.Size = new System.Drawing.Size(299, 24);
            this.DateDelivery_dateTimePicker.TabIndex = 15;
            // 
            // Count_numericUpDown
            // 
            this.Count_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_numericUpDown.Location = new System.Drawing.Point(140, 47);
            this.Count_numericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Count_numericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Count_numericUpDown.Name = "Count_numericUpDown";
            this.Count_numericUpDown.Size = new System.Drawing.Size(300, 24);
            this.Count_numericUpDown.TabIndex = 14;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_textBox.Location = new System.Drawing.Point(140, 15);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(299, 24);
            this.Name_textBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата поставки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Наименование";
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(212)))));
            this.Cancel_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(212)))));
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(340, 134);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(100, 30);
            this.Cancel_button.TabIndex = 9;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.ok_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ok_button.Location = new System.Drawing.Point(190, 134);
            this.ok_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(100, 30);
            this.ok_button.TabIndex = 8;
            this.ok_button.Text = "Применить";
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // EditInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 184);
            this.ControlBox = false;
            this.Controls.Add(this.DateDelivery_dateTimePicker);
            this.Controls.Add(this.Count_numericUpDown);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.ok_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.Count_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateDelivery_dateTimePicker;
        private System.Windows.Forms.NumericUpDown Count_numericUpDown;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button ok_button;
    }
}