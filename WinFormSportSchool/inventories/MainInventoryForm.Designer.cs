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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InventoryList_dataGridView = new System.Windows.Forms.DataGridView();
            this.Add_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryList_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.InventoryList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryList_dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryList_dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.InventoryList_dataGridView.GridColor = System.Drawing.SystemColors.MenuBar;
            this.InventoryList_dataGridView.Location = new System.Drawing.Point(13, 50);
            this.InventoryList_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventoryList_dataGridView.Name = "InventoryList_dataGridView";
            this.InventoryList_dataGridView.RowHeadersWidth = 51;
            this.InventoryList_dataGridView.RowTemplate.Height = 24;
            this.InventoryList_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryList_dataGridView.Size = new System.Drawing.Size(1235, 586);
            this.InventoryList_dataGridView.TabIndex = 1;
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.Add_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_button.Location = new System.Drawing.Point(13, 15);
            this.Add_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(123, 30);
            this.Add_button.TabIndex = 2;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.Edit_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.Edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit_button.Location = new System.Drawing.Point(169, 15);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(123, 30);
            this.Edit_button.TabIndex = 3;
            this.Edit_button.Text = "Редактировать";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // MainInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 652);
            this.Controls.Add(this.Edit_button);
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
        private System.Windows.Forms.Button Edit_button;
    }
}