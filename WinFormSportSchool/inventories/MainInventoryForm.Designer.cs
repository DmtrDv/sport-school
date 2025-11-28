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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInventoryForm));
            this.InventoryList_dataGridView = new System.Windows.Forms.DataGridView();
            this.Add_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.WriteOff_button = new System.Windows.Forms.Button();
            this.Archive_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryList_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryList_dataGridView
            // 
            this.InventoryList_dataGridView.AllowUserToAddRows = false;
            this.InventoryList_dataGridView.AllowUserToDeleteRows = false;
            this.InventoryList_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoryList_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryList_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.InventoryList_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.InventoryList_dataGridView.Location = new System.Drawing.Point(8, 43);
            this.InventoryList_dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InventoryList_dataGridView.MultiSelect = false;
            this.InventoryList_dataGridView.Name = "InventoryList_dataGridView";
            this.InventoryList_dataGridView.ReadOnly = true;
            this.InventoryList_dataGridView.RowHeadersWidth = 51;
            this.InventoryList_dataGridView.RowTemplate.Height = 24;
            this.InventoryList_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryList_dataGridView.Size = new System.Drawing.Size(926, 476);
            this.InventoryList_dataGridView.TabIndex = 1;
            this.InventoryList_dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InventoryList_dataGridView_MouseDown);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.Add_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(10, 12);
            this.Add_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(112, 24);
            this.Add_button.TabIndex = 2;
            this.Add_button.Text = "➕ Добавить";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(164)))));
            this.Edit_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(129)))));
            this.Edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(145, 12);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(112, 24);
            this.Edit_button.TabIndex = 3;
            this.Edit_button.Text = "✏️ Редактировать";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // WriteOff_button
            // 
            this.WriteOff_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(167)))));
            this.WriteOff_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(167)))));
            this.WriteOff_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WriteOff_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteOff_button.Location = new System.Drawing.Point(280, 12);
            this.WriteOff_button.Name = "WriteOff_button";
            this.WriteOff_button.Size = new System.Drawing.Size(112, 24);
            this.WriteOff_button.TabIndex = 3;
            this.WriteOff_button.Text = "📄⬇️ Списать";
            this.WriteOff_button.UseVisualStyleBackColor = false;
            this.WriteOff_button.Click += new System.EventHandler(this.WriteOff_button_Click);
            // 
            // Archive_button
            // 
            this.Archive_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Archive_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.Archive_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.Archive_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Archive_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Archive_button.Location = new System.Drawing.Point(844, 12);
            this.Archive_button.Name = "Archive_button";
            this.Archive_button.Size = new System.Drawing.Size(92, 24);
            this.Archive_button.TabIndex = 4;
            this.Archive_button.Text = "📁 Архив";
            this.Archive_button.UseVisualStyleBackColor = false;
            this.Archive_button.Click += new System.EventHandler(this.Archive_button_Click);
            // 
            // MainInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 530);
            this.Controls.Add(this.Archive_button);
            this.Controls.Add(this.WriteOff_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.InventoryList_dataGridView);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Инвентарь";
            this.Load += new System.EventHandler(this.MainInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryList_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView InventoryList_dataGridView;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button WriteOff_button;
        private System.Windows.Forms.Button Archive_button;
    }
}