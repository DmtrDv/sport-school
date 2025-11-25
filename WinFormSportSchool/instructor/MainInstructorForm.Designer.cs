namespace WinFormSportSchool
{
    partial class MainInstructorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInstructorForm));
            this.InstructorsList_dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Add_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InstructorsList_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructorsList_dataGridView
            // 
            this.InstructorsList_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstructorsList_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InstructorsList_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.InstructorsList_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstructorsList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstructorsList_dataGridView.Location = new System.Drawing.Point(11, 51);
            this.InstructorsList_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InstructorsList_dataGridView.Name = "InstructorsList_dataGridView";
            this.InstructorsList_dataGridView.RowHeadersWidth = 51;
            this.InstructorsList_dataGridView.RowTemplate.Height = 24;
            this.InstructorsList_dataGridView.Size = new System.Drawing.Size(1101, 533);
            this.InstructorsList_dataGridView.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.Add_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(14, 14);
            this.Add_button.Margin = new System.Windows.Forms.Padding(5);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(123, 30);
            this.Add_button.TabIndex = 3;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // MainInstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 599);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.InstructorsList_dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainInstructorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Педагогический состав";
            this.Load += new System.EventHandler(this.MainInstructorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InstructorsList_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView InstructorsList_dataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Add_button;
    }
}