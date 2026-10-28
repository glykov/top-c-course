namespace AdoNetDataProviders
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            btnProviders = new Button();
            label1 = new Label();
            txtConnectionString = new TextBox();
            label2 = new Label();
            txtRequest = new TextBox();
            dataGridView1 = new DataGridView();
            btnExecute = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(535, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnProviders
            // 
            btnProviders.Location = new Point(605, 20);
            btnProviders.Name = "btnProviders";
            btnProviders.Size = new Size(177, 36);
            btnProviders.TabIndex = 1;
            btnProviders.Text = "Get All Providers";
            btnProviders.UseVisualStyleBackColor = true;
            btnProviders.Click += btnProviders_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 67);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 2;
            label1.Text = "Connection String";
            // 
            // txtConnectionString
            // 
            txtConnectionString.Location = new Point(32, 95);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.ReadOnly = true;
            txtConnectionString.Size = new Size(745, 31);
            txtConnectionString.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 150);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 4;
            label2.Text = "SQL Request";
            // 
            // txtRequest
            // 
            txtRequest.Location = new Point(32, 178);
            txtRequest.Name = "txtRequest";
            txtRequest.Size = new Size(531, 31);
            txtRequest.TabIndex = 5;
            txtRequest.TextChanged += txtRequest_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(743, 300);
            dataGridView1.TabIndex = 6;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(605, 178);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(172, 37);
            btnExecute.TabIndex = 7;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(btnExecute);
            Controls.Add(dataGridView1);
            Controls.Add(txtRequest);
            Controls.Add(label2);
            Controls.Add(txtConnectionString);
            Controls.Add(label1);
            Controls.Add(btnProviders);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button btnProviders;
        private Label label1;
        private TextBox txtConnectionString;
        private Label label2;
        private TextBox txtRequest;
        private DataGridView dataGridView1;
        private Button btnExecute;
    }
}
