using Castle.Components.DictionaryAdapter.Xml;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormSportSchool
{
    partial class MainTraineeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTraineeForm));
            this.AddTrainee_button = new System.Windows.Forms.Button();
            this.tableListTrainees_dataGridView = new System.Windows.Forms.DataGridView();
            this.iconBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableListTrainees_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTrainee_button
            // 
            this.AddTrainee_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.AddTrainee_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.AddTrainee_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddTrainee_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTrainee_button.Location = new System.Drawing.Point(13, 14);
            this.AddTrainee_button.Margin = new System.Windows.Forms.Padding(4);
            this.AddTrainee_button.Name = "AddTrainee_button";
            this.AddTrainee_button.Size = new System.Drawing.Size(123, 30);
            this.AddTrainee_button.TabIndex = 4;
            this.AddTrainee_button.Text = "Добавить";
            this.AddTrainee_button.UseVisualStyleBackColor = false;
            this.AddTrainee_button.Click += new System.EventHandler(this.AddTrainee_button_Click);
            // 
            // tableListTrainees_dataGridView
            // 
            this.tableListTrainees_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableListTrainees_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableListTrainees_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tableListTrainees_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableListTrainees_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableListTrainees_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableListTrainees_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableListTrainees_dataGridView.GridColor = System.Drawing.SystemColors.MenuBar;
            this.tableListTrainees_dataGridView.Location = new System.Drawing.Point(13, 52);
            this.tableListTrainees_dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.tableListTrainees_dataGridView.Name = "tableListTrainees_dataGridView";
            this.tableListTrainees_dataGridView.RowHeadersWidth = 51;
            this.tableListTrainees_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableListTrainees_dataGridView.Size = new System.Drawing.Size(1237, 549);
            this.tableListTrainees_dataGridView.TabIndex = 3;
            this.tableListTrainees_dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableListTrainees_dataGridView_MouseDown);
            // 
            // iconBox
            // 
            this.iconBox.Image = global::WinFormSportSchool.Properties.Resources.icon;
            this.iconBox.Location = new System.Drawing.Point(8, 4);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(32, 32);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBox.TabIndex = 0;
            this.iconBox.TabStop = false;
            // 
            // MainTraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 614);
            this.ControlBox = false;
            this.Controls.Add(this.AddTrainee_button);
            this.Controls.Add(this.tableListTrainees_dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainTraineeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ученики";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableListTrainees_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddTrainee_button;
        private System.Windows.Forms.DataGridView tableListTrainees_dataGridView;
        private PictureBox iconBox;
    }
}

