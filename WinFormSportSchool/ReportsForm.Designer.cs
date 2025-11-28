namespace WinFormSportSchool.reports
{
    partial class ReportsForm
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
            this.NameInventory_label = new System.Windows.Forms.Label();
            this.rep1_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameInventory_label
            // 
            this.NameInventory_label.AutoSize = true;
            this.NameInventory_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameInventory_label.Location = new System.Drawing.Point(13, 13);
            this.NameInventory_label.Name = "NameInventory_label";
            this.NameInventory_label.Size = new System.Drawing.Size(154, 16);
            this.NameInventory_label.TabIndex = 0;
            this.NameInventory_label.Text = "Отчёты по инвентарю:";
            // 
            // rep1_label
            // 
            this.rep1_label.AutoSize = true;
            this.rep1_label.BackColor = System.Drawing.SystemColors.Control;
            this.rep1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rep1_label.Location = new System.Drawing.Point(37, 40);
            this.rep1_label.Name = "rep1_label";
            this.rep1_label.Size = new System.Drawing.Size(199, 16);
            this.rep1_label.TabIndex = 1;
            this.rep1_label.Text = "Инвентарь с низким запасом";
            this.rep1_label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rep1_label_MouseClick);
            this.rep1_label.MouseLeave += new System.EventHandler(this.rep1_label_MouseLeave);
            this.rep1_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rep1_label_MouseMove);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 428);
            this.Controls.Add(this.rep1_label);
            this.Controls.Add(this.NameInventory_label);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameInventory_label;
        private System.Windows.Forms.Label rep1_label;
    }
}