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
            this.MainConteiner_splitContainer = new System.Windows.Forms.SplitContainer();
            this.navigation_panel = new System.Windows.Forms.Panel();
            this.ClearWindows_button = new System.Windows.Forms.Button();
            this.FindOf_textBox = new System.Windows.Forms.TextBox();
            this.FindOf_label = new System.Windows.Forms.Label();
            this.archive_button = new System.Windows.Forms.Button();
            this.inventory_button = new System.Windows.Forms.Button();
            this.instructor_button = new System.Windows.Forms.Button();
            this.trainee_button = new System.Windows.Forms.Button();
            this.workArea_panel = new System.Windows.Forms.Panel();
            this.Report_button = new System.Windows.Forms.Button();
            this.ClearSearch_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainConteiner_splitContainer)).BeginInit();
            this.MainConteiner_splitContainer.Panel1.SuspendLayout();
            this.MainConteiner_splitContainer.Panel2.SuspendLayout();
            this.MainConteiner_splitContainer.SuspendLayout();
            this.navigation_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainConteiner_splitContainer
            // 
            this.MainConteiner_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainConteiner_splitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainConteiner_splitContainer.Name = "MainConteiner_splitContainer";
            // 
            // MainConteiner_splitContainer.Panel1
            // 
            this.MainConteiner_splitContainer.Panel1.Controls.Add(this.navigation_panel);
            // 
            // MainConteiner_splitContainer.Panel2
            // 
            this.MainConteiner_splitContainer.Panel2.Controls.Add(this.workArea_panel);
            this.MainConteiner_splitContainer.Size = new System.Drawing.Size(1322, 666);
            this.MainConteiner_splitContainer.SplitterDistance = 176;
            this.MainConteiner_splitContainer.TabIndex = 0;
            // 
            // navigation_panel
            // 
            this.navigation_panel.BackColor = System.Drawing.Color.LightGray;
            this.navigation_panel.Controls.Add(this.Report_button);
            this.navigation_panel.Controls.Add(this.ClearSearch_button);
            this.navigation_panel.Controls.Add(this.ClearWindows_button);
            this.navigation_panel.Controls.Add(this.FindOf_textBox);
            this.navigation_panel.Controls.Add(this.FindOf_label);
            this.navigation_panel.Controls.Add(this.archive_button);
            this.navigation_panel.Controls.Add(this.inventory_button);
            this.navigation_panel.Controls.Add(this.instructor_button);
            this.navigation_panel.Controls.Add(this.trainee_button);
            this.navigation_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigation_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigation_panel.Location = new System.Drawing.Point(0, 0);
            this.navigation_panel.Name = "navigation_panel";
            this.navigation_panel.Size = new System.Drawing.Size(176, 666);
            this.navigation_panel.TabIndex = 0;
            // 
            // ClearWindows_button
            // 
            this.ClearWindows_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearWindows_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearWindows_button.Location = new System.Drawing.Point(4, 285);
            this.ClearWindows_button.Name = "ClearWindows_button";
            this.ClearWindows_button.Size = new System.Drawing.Size(170, 30);
            this.ClearWindows_button.TabIndex = 6;
            this.ClearWindows_button.Text = "🗑️    Очистить окна";
            this.ClearWindows_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearWindows_button.UseVisualStyleBackColor = true;
            this.ClearWindows_button.Click += new System.EventHandler(this.ClearWindows_button_Click);
            // 
            // FindOf_textBox
            // 
            this.FindOf_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindOf_textBox.Enabled = false;
            this.FindOf_textBox.Location = new System.Drawing.Point(4, 28);
            this.FindOf_textBox.Name = "FindOf_textBox";
            this.FindOf_textBox.Size = new System.Drawing.Size(148, 23);
            this.FindOf_textBox.TabIndex = 5;
            this.FindOf_textBox.TextChanged += new System.EventHandler(this.FindOf_textBox_TextChanged);
            // 
            // FindOf_label
            // 
            this.FindOf_label.AutoSize = true;
            this.FindOf_label.Enabled = false;
            this.FindOf_label.Location = new System.Drawing.Point(3, 9);
            this.FindOf_label.Name = "FindOf_label";
            this.FindOf_label.Size = new System.Drawing.Size(48, 17);
            this.FindOf_label.TabIndex = 4;
            this.FindOf_label.Text = "Поиск";
            // 
            // archive_button
            // 
            this.archive_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.archive_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.archive_button.Location = new System.Drawing.Point(3, 177);
            this.archive_button.Name = "archive_button";
            this.archive_button.Size = new System.Drawing.Size(170, 30);
            this.archive_button.TabIndex = 3;
            this.archive_button.Text = "📁    Архив";
            this.archive_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.archive_button.UseVisualStyleBackColor = true;
            this.archive_button.Click += new System.EventHandler(this.archive_button_Click);
            // 
            // inventory_button
            // 
            this.inventory_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventory_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventory_button.Location = new System.Drawing.Point(3, 141);
            this.inventory_button.Name = "inventory_button";
            this.inventory_button.Size = new System.Drawing.Size(170, 30);
            this.inventory_button.TabIndex = 2;
            this.inventory_button.Text = "📦    Инвентарь";
            this.inventory_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory_button.UseVisualStyleBackColor = true;
            this.inventory_button.Click += new System.EventHandler(this.inventory_button_Click);
            // 
            // instructor_button
            // 
            this.instructor_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructor_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instructor_button.Location = new System.Drawing.Point(3, 105);
            this.instructor_button.Name = "instructor_button";
            this.instructor_button.Size = new System.Drawing.Size(170, 30);
            this.instructor_button.TabIndex = 1;
            this.instructor_button.Text = "🏋‍    Тренеры";
            this.instructor_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.instructor_button.UseVisualStyleBackColor = true;
            this.instructor_button.Click += new System.EventHandler(this.instructor_button_Click);
            // 
            // trainee_button
            // 
            this.trainee_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trainee_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainee_button.Location = new System.Drawing.Point(3, 69);
            this.trainee_button.Name = "trainee_button";
            this.trainee_button.Size = new System.Drawing.Size(170, 30);
            this.trainee_button.TabIndex = 0;
            this.trainee_button.Text = "👥    Учащиеся";
            this.trainee_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trainee_button.UseVisualStyleBackColor = true;
            this.trainee_button.Click += new System.EventHandler(this.trainee_button_Click);
            // 
            // workArea_panel
            // 
            this.workArea_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workArea_panel.Location = new System.Drawing.Point(0, 0);
            this.workArea_panel.Name = "workArea_panel";
            this.workArea_panel.Size = new System.Drawing.Size(1142, 666);
            this.workArea_panel.TabIndex = 0;
            // 
            // Report_button
            // 
            this.Report_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Report_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report_button.Location = new System.Drawing.Point(4, 213);
            this.Report_button.Name = "Report_button";
            this.Report_button.Size = new System.Drawing.Size(170, 30);
            this.Report_button.TabIndex = 8;
            this.Report_button.Text = "📄    Отчёт";
            this.Report_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Report_button.UseVisualStyleBackColor = true;
            this.Report_button.Click += new System.EventHandler(this.Report_button_Click);
            // 
            // ClearSearch_button
            // 
            this.ClearSearch_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearSearch_button.BackgroundImage = global::WinFormSportSchool.Properties.Resources.trashcan;
            this.ClearSearch_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClearSearch_button.Location = new System.Drawing.Point(150, 27);
            this.ClearSearch_button.Name = "ClearSearch_button";
            this.ClearSearch_button.Size = new System.Drawing.Size(25, 25);
            this.ClearSearch_button.TabIndex = 7;
            this.ClearSearch_button.UseVisualStyleBackColor = true;
            this.ClearSearch_button.Click += new System.EventHandler(this.ClearSearch_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 666);
            this.Controls.Add(this.MainConteiner_splitContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спортивная школа";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainConteiner_splitContainer.Panel1.ResumeLayout(false);
            this.MainConteiner_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainConteiner_splitContainer)).EndInit();
            this.MainConteiner_splitContainer.ResumeLayout(false);
            this.navigation_panel.ResumeLayout(false);
            this.navigation_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainConteiner_splitContainer;
        private System.Windows.Forms.Button trainee_button;
        private System.Windows.Forms.Panel navigation_panel;
        private System.Windows.Forms.Button archive_button;
        private System.Windows.Forms.Button inventory_button;
        private System.Windows.Forms.Button instructor_button;
        private System.Windows.Forms.Panel workArea_panel;
        private System.Windows.Forms.TextBox FindOf_textBox;
        private System.Windows.Forms.Label FindOf_label;
        private System.Windows.Forms.Button ClearWindows_button;
        private System.Windows.Forms.Button ClearSearch_button;
        private System.Windows.Forms.Button Report_button;
    }
}