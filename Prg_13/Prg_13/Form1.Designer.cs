namespace Prg_13
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.student_masterDataSet = new Prg_13.student_masterDataSet();
            this.bindstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bind_studentTableAdapter = new Prg_13.student_masterDataSetTableAdapters.bind_studentTableAdapter();
            this.student_masterDataSet1 = new Prg_13.student_masterDataSet1();
            this.bindstudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bind_studentTableAdapter1 = new Prg_13.student_masterDataSet1TableAdapters.bind_studentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.student_masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_masterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindstudentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bindstudentBindingSource1;
            this.comboBox1.DisplayMember = "eno";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "name";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // student_masterDataSet
            // 
            this.student_masterDataSet.DataSetName = "student_masterDataSet";
            this.student_masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindstudentBindingSource
            // 
            this.bindstudentBindingSource.DataMember = "bind_student";
            this.bindstudentBindingSource.DataSource = this.student_masterDataSet;
            // 
            // bind_studentTableAdapter
            // 
            this.bind_studentTableAdapter.ClearBeforeFill = true;
            // 
            // student_masterDataSet1
            // 
            this.student_masterDataSet1.DataSetName = "student_masterDataSet1";
            this.student_masterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindstudentBindingSource1
            // 
            this.bindstudentBindingSource1.DataMember = "bind_student";
            this.bindstudentBindingSource1.DataSource = this.student_masterDataSet1;
            // 
            // bind_studentTableAdapter1
            // 
            this.bind_studentTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 109);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_masterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindstudentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private student_masterDataSet student_masterDataSet;
        private System.Windows.Forms.BindingSource bindstudentBindingSource;
        private student_masterDataSetTableAdapters.bind_studentTableAdapter bind_studentTableAdapter;
        private student_masterDataSet1 student_masterDataSet1;
        private System.Windows.Forms.BindingSource bindstudentBindingSource1;
        private student_masterDataSet1TableAdapters.bind_studentTableAdapter bind_studentTableAdapter1;
    }
}

