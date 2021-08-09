
namespace EntityFrameworkDemo
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Student_List = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ogrid = new System.Windows.Forms.TextBox();
            this.txt_ogrname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_image = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_lessonid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_lessonname = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_average = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cg1 = new System.Windows.Forms.TextBox();
            this.txt_cg3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cg2 = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Grade_List = new System.Windows.Forms.Button();
            this.btn_Lesson_List = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(818, 164);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Student_List
            // 
            this.btn_Student_List.Location = new System.Drawing.Point(12, 182);
            this.btn_Student_List.Name = "btn_Student_List";
            this.btn_Student_List.Size = new System.Drawing.Size(111, 28);
            this.btn_Student_List.TabIndex = 1;
            this.btn_Student_List.Text = "Student List";
            this.btn_Student_List.UseVisualStyleBackColor = true;
            this.btn_Student_List.Click += new System.EventHandler(this.btn_Student_List_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(12, 216);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(111, 28);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(12, 250);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(111, 28);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(12, 284);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(111, 28);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(12, 318);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(111, 28);
            this.btn_Find.TabIndex = 5;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // txt_ogrid
            // 
            this.txt_ogrid.Location = new System.Drawing.Point(103, 23);
            this.txt_ogrid.Name = "txt_ogrid";
            this.txt_ogrid.Size = new System.Drawing.Size(100, 20);
            this.txt_ogrid.TabIndex = 7;
            // 
            // txt_ogrname
            // 
            this.txt_ogrname.Location = new System.Drawing.Point(103, 55);
            this.txt_ogrname.Name = "txt_ogrname";
            this.txt_ogrname.Size = new System.Drawing.Size(100, 20);
            this.txt_ogrname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(103, 92);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(100, 20);
            this.txt_lastname.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name:";
            // 
            // txt_image
            // 
            this.txt_image.Location = new System.Drawing.Point(103, 123);
            this.txt_image.Name = "txt_image";
            this.txt_image.Size = new System.Drawing.Size(100, 20);
            this.txt_image.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Image:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_image);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ogrid);
            this.groupBox1.Controls.Add(this.txt_lastname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ogrname);
            this.groupBox1.Location = new System.Drawing.Point(201, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 164);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_lessonid);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_lessonname);
            this.groupBox2.Location = new System.Drawing.Point(201, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 96);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lesson";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lesson ID:";
            // 
            // txt_lessonid
            // 
            this.txt_lessonid.Location = new System.Drawing.Point(103, 23);
            this.txt_lessonid.Name = "txt_lessonid";
            this.txt_lessonid.Size = new System.Drawing.Size(100, 20);
            this.txt_lessonid.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lesson Name:";
            // 
            // txt_lessonname
            // 
            this.txt_lessonname.Location = new System.Drawing.Point(103, 55);
            this.txt_lessonname.Name = "txt_lessonname";
            this.txt_lessonname.Size = new System.Drawing.Size(100, 20);
            this.txt_lessonname.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_status);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_average);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_cg1);
            this.groupBox3.Controls.Add(this.txt_cg3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_cg2);
            this.groupBox3.Location = new System.Drawing.Point(460, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 192);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Course Grade";
            // 
            // txt_average
            // 
            this.txt_average.Location = new System.Drawing.Point(91, 110);
            this.txt_average.Name = "txt_average";
            this.txt_average.Size = new System.Drawing.Size(100, 20);
            this.txt_average.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Course Grade 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Average:";
            // 
            // txt_cg1
            // 
            this.txt_cg1.Location = new System.Drawing.Point(91, 23);
            this.txt_cg1.Name = "txt_cg1";
            this.txt_cg1.Size = new System.Drawing.Size(100, 20);
            this.txt_cg1.TabIndex = 7;
            // 
            // txt_cg3
            // 
            this.txt_cg3.Location = new System.Drawing.Point(91, 81);
            this.txt_cg3.Name = "txt_cg3";
            this.txt_cg3.Size = new System.Drawing.Size(100, 20);
            this.txt_cg3.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Course Grade 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Course Grade 3:";
            // 
            // txt_cg2
            // 
            this.txt_cg2.Location = new System.Drawing.Point(91, 55);
            this.txt_cg2.Name = "txt_cg2";
            this.txt_cg2.Size = new System.Drawing.Size(100, 20);
            this.txt_cg2.TabIndex = 9;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(91, 136);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(100, 20);
            this.txt_status.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Status";
            // 
            // btn_Grade_List
            // 
            this.btn_Grade_List.Location = new System.Drawing.Point(12, 386);
            this.btn_Grade_List.Name = "btn_Grade_List";
            this.btn_Grade_List.Size = new System.Drawing.Size(111, 28);
            this.btn_Grade_List.TabIndex = 16;
            this.btn_Grade_List.Text = "Course Grade List";
            this.btn_Grade_List.UseVisualStyleBackColor = true;
            this.btn_Grade_List.Click += new System.EventHandler(this.btn_Grade_List_Click);
            // 
            // btn_Lesson_List
            // 
            this.btn_Lesson_List.Location = new System.Drawing.Point(12, 352);
            this.btn_Lesson_List.Name = "btn_Lesson_List";
            this.btn_Lesson_List.Size = new System.Drawing.Size(111, 28);
            this.btn_Lesson_List.TabIndex = 17;
            this.btn_Lesson_List.Text = "Lesson List";
            this.btn_Lesson_List.UseVisualStyleBackColor = true;
            this.btn_Lesson_List.Click += new System.EventHandler(this.btn_Lesson_List_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 453);
            this.Controls.Add(this.btn_Lesson_List);
            this.Controls.Add(this.btn_Grade_List);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Student_List);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Student_List;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ogrid;
        private System.Windows.Forms.TextBox txt_ogrname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_lessonid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_lessonname;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_average;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cg1;
        private System.Windows.Forms.TextBox txt_cg3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_cg2;
        private System.Windows.Forms.Button btn_Grade_List;
        private System.Windows.Forms.Button btn_Lesson_List;
    }
}

