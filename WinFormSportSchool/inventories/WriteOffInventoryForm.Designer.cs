namespace WinFormSportSchool.inventories
{
    partial class WriteOffInventoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.count_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateWriteOff_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.writtenOff_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.count_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(277, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(541, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата списания";
            // 
            // Name_label
            // 
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(13, 63);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(261, 40);
            this.Name_label.TabIndex = 3;
            this.Name_label.Text = "Наименование";
            // 
            // count_numericUpDown
            // 
            this.count_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_numericUpDown.Location = new System.Drawing.Point(280, 63);
            this.count_numericUpDown.Name = "count_numericUpDown";
            this.count_numericUpDown.Size = new System.Drawing.Size(184, 24);
            this.count_numericUpDown.TabIndex = 4;
            // 
            // dateWriteOff_dateTimePicker
            // 
            this.dateWriteOff_dateTimePicker.AllowDrop = true;
            this.dateWriteOff_dateTimePicker.Enabled = false;
            this.dateWriteOff_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateWriteOff_dateTimePicker.Location = new System.Drawing.Point(544, 63);
            this.dateWriteOff_dateTimePicker.Name = "dateWriteOff_dateTimePicker";
            this.dateWriteOff_dateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.dateWriteOff_dateTimePicker.TabIndex = 5;
            // 
            // writtenOff_button
            // 
            this.writtenOff_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.writtenOff_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.writtenOff_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.writtenOff_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writtenOff_button.Location = new System.Drawing.Point(502, 131);
            this.writtenOff_button.Name = "writtenOff_button";
            this.writtenOff_button.Size = new System.Drawing.Size(100, 30);
            this.writtenOff_button.TabIndex = 6;
            this.writtenOff_button.Text = "Списать";
            this.writtenOff_button.UseVisualStyleBackColor = false;
            this.writtenOff_button.Click += new System.EventHandler(this.writtenOff_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(212)))));
            this.Cancel_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(212)))));
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(652, 131);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(100, 30);
            this.Cancel_button.TabIndex = 7;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // WriteOffInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 209);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.writtenOff_button);
            this.Controls.Add(this.dateWriteOff_dateTimePicker);
            this.Controls.Add(this.count_numericUpDown);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WriteOffInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Списание";
            ((System.ComponentModel.ISupportInitialize)(this.count_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.NumericUpDown count_numericUpDown;
        private System.Windows.Forms.DateTimePicker dateWriteOff_dateTimePicker;
        private System.Windows.Forms.Button writtenOff_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}