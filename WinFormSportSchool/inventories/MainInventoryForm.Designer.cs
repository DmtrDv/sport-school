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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddInventory_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.InventoryList_dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryList_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddInventory_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddInventory_toolStripButton
            // 
            this.AddInventory_toolStripButton.AutoSize = false;
            this.AddInventory_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddInventory_toolStripButton.Image = global::WinFormSportSchool.Properties.Resources.button_Add;
            this.AddInventory_toolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddInventory_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddInventory_toolStripButton.Name = "AddInventory_toolStripButton";
            this.AddInventory_toolStripButton.Size = new System.Drawing.Size(44, 44);
            this.AddInventory_toolStripButton.Text = "Добавить инвентарь";
            this.AddInventory_toolStripButton.Click += new System.EventHandler(this.AddInventory_toolStripButton_Click);
            // 
            // InventoryList_dataGridView
            // 
            this.InventoryList_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoryList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryList_dataGridView.Location = new System.Drawing.Point(13, 51);
            this.InventoryList_dataGridView.Name = "InventoryList_dataGridView";
            this.InventoryList_dataGridView.RowHeadersWidth = 51;
            this.InventoryList_dataGridView.RowTemplate.Height = 24;
            this.InventoryList_dataGridView.Size = new System.Drawing.Size(775, 202);
            this.InventoryList_dataGridView.TabIndex = 1;
            // 
            // MainInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 268);
            this.Controls.Add(this.InventoryList_dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainInventoryForm";
            this.Text = "Инвентарь";
            this.Load += new System.EventHandler(this.MainInventoryForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryList_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddInventory_toolStripButton;
        private System.Windows.Forms.DataGridView InventoryList_dataGridView;
    }
}