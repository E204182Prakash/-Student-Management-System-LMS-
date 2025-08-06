
namespace Student_Management_System_cw2
{
    partial class View_Lecturer
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
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_srch_lec = new System.Windows.Forms.TextBox();
            this.rbn_lec_name = new System.Windows.Forms.RadioButton();
            this.btn_view_lec = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.IndianRed;
            this.btn_back.Location = new System.Drawing.Point(628, 59);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 27);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // txt_srch_lec
            // 
            this.txt_srch_lec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_srch_lec.Location = new System.Drawing.Point(183, 59);
            this.txt_srch_lec.Name = "txt_srch_lec";
            this.txt_srch_lec.Size = new System.Drawing.Size(287, 27);
            this.txt_srch_lec.TabIndex = 13;
            // 
            // rbn_lec_name
            // 
            this.rbn_lec_name.AutoSize = true;
            this.rbn_lec_name.Location = new System.Drawing.Point(23, 63);
            this.rbn_lec_name.Name = "rbn_lec_name";
            this.rbn_lec_name.Size = new System.Drawing.Size(123, 21);
            this.rbn_lec_name.TabIndex = 12;
            this.rbn_lec_name.TabStop = true;
            this.rbn_lec_name.Text = "Lecturer Name";
            this.rbn_lec_name.UseVisualStyleBackColor = true;
            // 
            // btn_view_lec
            // 
            this.btn_view_lec.BackColor = System.Drawing.Color.Khaki;
            this.btn_view_lec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_lec.Location = new System.Drawing.Point(501, 59);
            this.btn_view_lec.Name = "btn_view_lec";
            this.btn_view_lec.Size = new System.Drawing.Size(111, 27);
            this.btn_view_lec.TabIndex = 11;
            this.btn_view_lec.Text = "View";
            this.btn_view_lec.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 386);
            this.dataGridView1.TabIndex = 10;
            // 
            // View_Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_srch_lec);
            this.Controls.Add(this.rbn_lec_name);
            this.Controls.Add(this.btn_view_lec);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_Lecturer";
            this.Text = "View_Lecturer";
            this.Load += new System.EventHandler(this.View_Lecturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_srch_lec;
        private System.Windows.Forms.RadioButton rbn_lec_name;
        private System.Windows.Forms.Button btn_view_lec;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}