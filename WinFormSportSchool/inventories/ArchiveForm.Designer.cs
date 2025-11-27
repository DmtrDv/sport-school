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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.archive_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.archive_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.archive_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.archive_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.archive_dataGridView.GridColor = System.Drawing.SystemColors.MenuBar;
            this.archive_dataGridView.Location = new System.Drawing.Point(13, 48);
            this.archive_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.archive_dataGridView.Name = "archive_dataGridView";
            this.archive_dataGridView.RowHeadersWidth = 51;
            this.archive_dataGridView.RowTemplate.Height = 24;
            this.archive_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.archive_dataGridView.Size = new System.Drawing.Size(1131, 558);
            this.archive_dataGridView.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.Location = new System.Drawing.Point(13, 7);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(100, 32);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "← Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Visible = false;
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ArchiveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Архив";
            this.Load += new System.EventHandler(this.ArchiveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.archive_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView archive_dataGridView;
        public System.Windows.Forms.Button back_button;
    }
}