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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddInstructor_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.InstructorsList_dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.toolStrip1.Size = new System.Drawing.Size(629, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddInstructor_toolStripButton
            // 
            this.AddInstructor_toolStripButton.AutoSize = false;
            this.AddInstructor_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddInstructor_toolStripButton.Image = global::WinFormSportSchool.Properties.Resources.button_Add;
            this.AddInstructor_toolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddInstructor_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddInstructor_toolStripButton.Name = "AddInstructor_toolStripButton";
            this.AddInstructor_toolStripButton.Size = new System.Drawing.Size(44, 44);
            this.AddInstructor_toolStripButton.Text = "Добавить тренера";
            this.AddInstructor_toolStripButton.Click += new System.EventHandler(this.AddInstructor_toolStripButton_Click);
            // 
            // InstructorsList_dataGridView
            // 
            this.InstructorsList_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstructorsList_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InstructorsList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstructorsList_dataGridView.Location = new System.Drawing.Point(8, 49);
            this.InstructorsList_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.InstructorsList_dataGridView.Name = "InstructorsList_dataGridView";
            this.InstructorsList_dataGridView.RowHeadersWidth = 51;
            this.InstructorsList_dataGridView.RowTemplate.Height = 24;
            this.InstructorsList_dataGridView.Size = new System.Drawing.Size(610, 175);
            this.InstructorsList_dataGridView.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainInstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 236);
            this.Controls.Add(this.InstructorsList_dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainInstructorForm";
            this.Text = "Педагогический состав";
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}