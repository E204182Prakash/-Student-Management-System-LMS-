
namespace Student_Management_System_cw2
{
    partial class Result_View
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
            this.rbn_stuID_result = new System.Windows.Forms.RadioButton();
            this.txt_search_reslt = new System.Windows.Forms.TextBox();
            this.btn_View_result = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.IndianRed;
            this.btn_back.Location = new System.Drawing.Point(480, 65);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(95, 27);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // rbn_stuID_result
            // 
            this.rbn_stuID_result.AutoSize = true;
            this.rbn_stuID_result.Location = new System.Drawing.Point(27, 69);
            this.rbn_stuID_result.Name = "rbn_stuID_result";
            this.rbn_stuID_result.Size = new System.Drawing.Size(95, 21);
            this.rbn_stuID_result.TabIndex = 9;
            this.rbn_stuID_result.TabStop = true;
            this.rbn_stuID_result.Text = "Student ID";
            this.rbn_stuID_result.UseVisualStyleBackColor = true;
            // 
            // txt_search_reslt
            // 
            this.txt_search_reslt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_reslt.Location = new System.Drawing.Point(146, 65);
            this.txt_search_reslt.Name = "txt_search_reslt";
            this.txt_search_reslt.Size = new System.Drawing.Size(202, 27);
            this.txt_search_reslt.TabIndex = 8;
            // 
            // btn_View_result
            // 
            this.btn_View_result.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_View_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_result.Location = new System.Drawing.Point(364, 65);
            this.btn_View_result.Name = "btn_View_result";
            this.btn_View_result.Size = new System.Drawing.Size(109, 27);
            this.btn_View_result.TabIndex = 7;
            this.btn_View_result.Text = "View";
            this.btn_View_result.UseVisualStyleBackColor = false;
            this.btn_View_result.Click += new System.EventHandler(this.btn_View_result_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 361);
            this.dataGridView1.TabIndex = 6;
            // 
            // Result_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 500);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.rbn_stuID_result);
            this.Controls.Add(this.txt_search_reslt);
            this.Controls.Add(this.btn_View_result);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Result_View";
            this.Text = "Result_View";
            this.Load += new System.EventHandler(this.Result_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.RadioButton rbn_stuID_result;
        private System.Windows.Forms.TextBox txt_search_reslt;
        private System.Windows.Forms.Button btn_View_result;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}