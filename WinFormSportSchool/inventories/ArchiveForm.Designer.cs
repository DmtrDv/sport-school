namespace WinFormSportSchool.inventories
{
    partial class ArchiveForm
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
            this.archive_dataGridView = new System.Windows.Forms.DataGridView();
            this.back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.archive_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // archive_dataGridView
            // 
            this.archive_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.archive_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.archive_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.archive_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archive_dataGridView.Location = new System.Drawing.Point(13, 48);
            this.archive_dataGridView.Name = "archive_dataGridView";
            this.archive_dataGridView.RowHeadersWidth = 51;
            this.archive_dataGridView.RowTemplate.Height = 24;
            this.archive_dataGridView.Size = new System.Drawing.Size(1130, 557);
            this.archive_dataGridView.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.Location = new System.Drawing.Point(13, 7);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(96, 35);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "← Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // ArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 617);
            this.ControlBox = false;
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.archive_dataGridView);
            this.Name = "ArchiveForm";
            this.Text = "Архив";
            this.Load += new System.EventHandler(this.ArchiveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.archive_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView archive_dataGridView;
        private System.Windows.Forms.Button back_button;
    }
}