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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInstructorForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddInstructor_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.InstructorsList_dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InstructorsList_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddInstructor_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(839, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddInstructor_toolStripButton
            // 
            this.AddInstructor_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddInstructor_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddInstructor_toolStripButton.Image")));
            this.AddInstructor_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddInstructor_toolStripButton.Name = "AddInstructor_toolStripButton";
            this.AddInstructor_toolStripButton.Size = new System.Drawing.Size(29, 24);
            this.AddInstructor_toolStripButton.Text = "Добавить тренера";
            this.AddInstructor_toolStripButton.Click += new System.EventHandler(this.AddInstructor_toolStripButton_Click);
            // 
            // InstructorsList_dataGridView
            // 
            this.InstructorsList_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstructorsList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstructorsList_dataGridView.Location = new System.Drawing.Point(13, 31);
            this.InstructorsList_dataGridView.Name = "InstructorsList_dataGridView";
            this.InstructorsList_dataGridView.RowHeadersWidth = 51;
            this.InstructorsList_dataGridView.RowTemplate.Height = 24;
            this.InstructorsList_dataGridView.Size = new System.Drawing.Size(814, 159);
            this.InstructorsList_dataGridView.TabIndex = 1;
            // 
            // MainInstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.InstructorsList_dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainInstructorForm";
            this.Text = "MainInstructorForm";
            this.Load += new System.EventHandler(this.MainInstructorForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InstructorsList_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddInstructor_toolStripButton;
        private System.Windows.Forms.DataGridView InstructorsList_dataGridView;
    }
}