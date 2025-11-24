namespace WinFormSportSchool.inventories
{
    partial class MainInventoryForm
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
            this.InventoryList_dataGridView = new System.Windows.Forms.DataGridView();
            this.Add_button = new System.Windows.Forms.Button();
            this.WriteOff_button = new System.Windows.Forms.Button();
            this.Archive_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryList_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryList_dataGridView
            // 
            this.InventoryList_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoryList_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryList_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.InventoryList_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryList_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InventoryList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryList_dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryList_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.InventoryList_dataGridView.GridColor = System.Drawing.SystemColors.MenuBar;
            this.InventoryList_dataGridView.Location = new System.Drawing.Point(13, 50);
            this.InventoryList_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventoryList_dataGridView.Name = "InventoryList_dataGridView";
            this.InventoryList_dataGridView.RowHeadersWidth = 51;
            this.InventoryList_dataGridView.RowTemplate.Height = 24;
            this.InventoryList_dataGridView.Size = new System.Drawing.Size(1235, 586);
            this.InventoryList_dataGridView.TabIndex = 1;
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.Add_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_button.Location = new System.Drawing.Point(13, 15);
            this.Add_button.Margin = new System.Windows.Forms.Padding(4);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(123, 30);
            this.Add_button.TabIndex = 2;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // WriteOff_button
            // 
            this.WriteOff_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(167)))));
            this.WriteOff_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(167)))));
            this.WriteOff_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WriteOff_button.Location = new System.Drawing.Point(345, 15);
            this.WriteOff_button.Margin = new System.Windows.Forms.Padding(4);
            this.WriteOff_button.Name = "WriteOff_button";
            this.WriteOff_button.Size = new System.Drawing.Size(123, 30);
            this.WriteOff_button.TabIndex = 3;
            this.WriteOff_button.Text = "Списать";
            this.WriteOff_button.UseVisualStyleBackColor = false;
            this.WriteOff_button.Click += new System.EventHandler(this.WriteOff_button_Click);
            // 
            // Archive_button
            // 
            this.Archive_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.Archive_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.Archive_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Archive_button.Location = new System.Drawing.Point(1125, 15);
            this.Archive_button.Margin = new System.Windows.Forms.Padding(4);
            this.Archive_button.Name = "Archive_button";
            this.Archive_button.Size = new System.Drawing.Size(123, 30);
            this.Archive_button.TabIndex = 4;
            this.Archive_button.Text = "Архив";
            this.Archive_button.UseVisualStyleBackColor = false;
            this.Archive_button.Click += new System.EventHandler(this.Archive_button_Click);
            // 
            // MainInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 652);
            this.Controls.Add(this.Archive_button);
            this.Controls.Add(this.WriteOff_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.InventoryList_dataGridView);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainInventoryForm";
            this.Text = "Инвентарь";
            this.Load += new System.EventHandler(this.MainInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryList_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView InventoryList_dataGridView;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button WriteOff_button;
        private System.Windows.Forms.Button Archive_button;
    }
}