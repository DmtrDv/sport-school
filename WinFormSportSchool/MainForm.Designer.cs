namespace WinFormSportSchool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.main_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.trainee_panel = new System.Windows.Forms.Panel();
            this.trainee_label = new System.Windows.Forms.Label();
            this.instructor_panel = new System.Windows.Forms.Panel();
            this.instructor_label = new System.Windows.Forms.Label();
            this.inventory_panel = new System.Windows.Forms.Panel();
            this.inventory_label = new System.Windows.Forms.Label();
            this.archive_panel = new System.Windows.Forms.Panel();
            this.archive_label = new System.Windows.Forms.Label();
            this.trainee_button = new System.Windows.Forms.Button();
            this.instructor_button = new System.Windows.Forms.Button();
            this.inventory_button = new System.Windows.Forms.Button();
            this.archive_button = new System.Windows.Forms.Button();
            this.main_flowLayoutPanel.SuspendLayout();
            this.trainee_panel.SuspendLayout();
            this.instructor_panel.SuspendLayout();
            this.inventory_panel.SuspendLayout();
            this.archive_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_flowLayoutPanel
            // 
            this.main_flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_flowLayoutPanel.Controls.Add(this.trainee_panel);
            this.main_flowLayoutPanel.Controls.Add(this.instructor_panel);
            this.main_flowLayoutPanel.Controls.Add(this.inventory_panel);
            this.main_flowLayoutPanel.Controls.Add(this.archive_panel);
            this.main_flowLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.main_flowLayoutPanel.Name = "main_flowLayoutPanel";
            this.main_flowLayoutPanel.Size = new System.Drawing.Size(983, 545);
            this.main_flowLayoutPanel.TabIndex = 0;
            // 
            // trainee_panel
            // 
            this.trainee_panel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trainee_panel.Controls.Add(this.trainee_button);
            this.trainee_panel.Controls.Add(this.trainee_label);
            this.trainee_panel.Location = new System.Drawing.Point(3, 3);
            this.trainee_panel.Name = "trainee_panel";
            this.trainee_panel.Size = new System.Drawing.Size(200, 200);
            this.trainee_panel.TabIndex = 0;
            // 
            // trainee_label
            // 
            this.trainee_label.AutoSize = true;
            this.trainee_label.Location = new System.Drawing.Point(56, 180);
            this.trainee_label.Name = "trainee_label";
            this.trainee_label.Size = new System.Drawing.Size(107, 20);
            this.trainee_label.TabIndex = 0;
            this.trainee_label.Text = "УЧАЩИЕСЯ";
            // 
            // instructor_panel
            // 
            this.instructor_panel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.instructor_panel.Controls.Add(this.instructor_button);
            this.instructor_panel.Controls.Add(this.instructor_label);
            this.instructor_panel.Location = new System.Drawing.Point(209, 3);
            this.instructor_panel.Name = "instructor_panel";
            this.instructor_panel.Size = new System.Drawing.Size(200, 200);
            this.instructor_panel.TabIndex = 2;
            // 
            // instructor_label
            // 
            this.instructor_label.AutoSize = true;
            this.instructor_label.Location = new System.Drawing.Point(62, 180);
            this.instructor_label.Name = "instructor_label";
            this.instructor_label.Size = new System.Drawing.Size(92, 20);
            this.instructor_label.TabIndex = 0;
            this.instructor_label.Text = "ТРЕНЕРЫ";
            // 
            // inventory_panel
            // 
            this.inventory_panel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inventory_panel.Controls.Add(this.inventory_button);
            this.inventory_panel.Controls.Add(this.inventory_label);
            this.inventory_panel.Location = new System.Drawing.Point(415, 3);
            this.inventory_panel.Name = "inventory_panel";
            this.inventory_panel.Size = new System.Drawing.Size(200, 200);
            this.inventory_panel.TabIndex = 3;
            // 
            // inventory_label
            // 
            this.inventory_label.AutoSize = true;
            this.inventory_label.Location = new System.Drawing.Point(62, 180);
            this.inventory_label.Name = "inventory_label";
            this.inventory_label.Size = new System.Drawing.Size(114, 20);
            this.inventory_label.TabIndex = 0;
            this.inventory_label.Text = "ИНВЕНТАРЬ";
            // 
            // archive_panel
            // 
            this.archive_panel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.archive_panel.Controls.Add(this.archive_button);
            this.archive_panel.Controls.Add(this.archive_label);
            this.archive_panel.Location = new System.Drawing.Point(621, 3);
            this.archive_panel.Name = "archive_panel";
            this.archive_panel.Size = new System.Drawing.Size(200, 200);
            this.archive_panel.TabIndex = 4;
            // 
            // archive_label
            // 
            this.archive_label.AutoSize = true;
            this.archive_label.Location = new System.Drawing.Point(77, 180);
            this.archive_label.Name = "archive_label";
            this.archive_label.Size = new System.Drawing.Size(67, 20);
            this.archive_label.TabIndex = 0;
            this.archive_label.Text = "АРХИВ";
            // 
            // trainee_button
            // 
            this.trainee_button.BackColor = System.Drawing.Color.White;
            this.trainee_button.BackgroundImage = global::WinFormSportSchool.Properties.Resources.icon_student;
            this.trainee_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.trainee_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.trainee_button.ForeColor = System.Drawing.Color.Black;
            this.trainee_button.Location = new System.Drawing.Point(4, 4);
            this.trainee_button.Name = "trainee_button";
            this.trainee_button.Size = new System.Drawing.Size(193, 173);
            this.trainee_button.TabIndex = 1;
            this.trainee_button.UseVisualStyleBackColor = false;
            this.trainee_button.Click += new System.EventHandler(this.trainee_button_Click);
            // 
            // instructor_button
            // 
            this.instructor_button.BackColor = System.Drawing.Color.White;
            this.instructor_button.BackgroundImage = global::WinFormSportSchool.Properties.Resources.icon_trener;
            this.instructor_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.instructor_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.instructor_button.ForeColor = System.Drawing.Color.Black;
            this.instructor_button.Location = new System.Drawing.Point(4, 4);
            this.instructor_button.Name = "instructor_button";
            this.instructor_button.Size = new System.Drawing.Size(193, 173);
            this.instructor_button.TabIndex = 1;
            this.instructor_button.UseVisualStyleBackColor = false;
            this.instructor_button.Click += new System.EventHandler(this.instructor_button_Click);
            // 
            // inventory_button
            // 
            this.inventory_button.BackColor = System.Drawing.Color.White;
            this.inventory_button.BackgroundImage = global::WinFormSportSchool.Properties.Resources.icon_inventory;
            this.inventory_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventory_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inventory_button.ForeColor = System.Drawing.Color.Black;
            this.inventory_button.Location = new System.Drawing.Point(4, 4);
            this.inventory_button.Name = "inventory_button";
            this.inventory_button.Size = new System.Drawing.Size(193, 173);
            this.inventory_button.TabIndex = 1;
            this.inventory_button.UseVisualStyleBackColor = false;
            this.inventory_button.Click += new System.EventHandler(this.inventory_button_Click);
            // 
            // archive_button
            // 
            this.archive_button.BackColor = System.Drawing.Color.White;
            this.archive_button.BackgroundImage = global::WinFormSportSchool.Properties.Resources.icon_archive;
            this.archive_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.archive_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.archive_button.ForeColor = System.Drawing.Color.Black;
            this.archive_button.Location = new System.Drawing.Point(4, 4);
            this.archive_button.Name = "archive_button";
            this.archive_button.Size = new System.Drawing.Size(193, 173);
            this.archive_button.TabIndex = 1;
            this.archive_button.UseVisualStyleBackColor = false;
            this.archive_button.Click += new System.EventHandler(this.archive_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.main_flowLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спортивная школа";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.main_flowLayoutPanel.ResumeLayout(false);
            this.trainee_panel.ResumeLayout(false);
            this.trainee_panel.PerformLayout();
            this.instructor_panel.ResumeLayout(false);
            this.instructor_panel.PerformLayout();
            this.inventory_panel.ResumeLayout(false);
            this.inventory_panel.PerformLayout();
            this.archive_panel.ResumeLayout(false);
            this.archive_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel main_flowLayoutPanel;
        private System.Windows.Forms.Panel trainee_panel;
        private System.Windows.Forms.Label trainee_label;
        private System.Windows.Forms.Button trainee_button;
        private System.Windows.Forms.Panel instructor_panel;
        private System.Windows.Forms.Label instructor_label;
        private System.Windows.Forms.Button instructor_button;
        private System.Windows.Forms.Panel inventory_panel;
        private System.Windows.Forms.Button inventory_button;
        private System.Windows.Forms.Label inventory_label;
        private System.Windows.Forms.Panel archive_panel;
        private System.Windows.Forms.Button archive_button;
        private System.Windows.Forms.Label archive_label;
    }
}