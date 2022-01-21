
namespace program2
{
    partial class Form1
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
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.text_FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Start = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnAlgorithms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPadding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnDeCrypt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(383, 12);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectFile.TabIndex = 0;
            this.btn_SelectFile.Text = "Select";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // text_FilePath
            // 
            this.text_FilePath.Location = new System.Drawing.Point(116, 14);
            this.text_FilePath.Name = "text_FilePath";
            this.text_FilePath.ReadOnly = true;
            this.text_FilePath.Size = new System.Drawing.Size(261, 20);
            this.text_FilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(434, 71);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAlgorithms,
            this.ColumnMode,
            this.ColumnPadding,
            this.ColumnEnDeCrypt,
            this.ColumnTime});
            this.dataGridView1.Location = new System.Drawing.Point(45, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 295);
            this.dataGridView1.TabIndex = 4;
            // 
            // ColumnAlgorithms
            // 
            this.ColumnAlgorithms.HeaderText = "Algorithms";
            this.ColumnAlgorithms.Name = "ColumnAlgorithms";
            this.ColumnAlgorithms.ReadOnly = true;
            // 
            // ColumnMode
            // 
            this.ColumnMode.HeaderText = "Mode";
            this.ColumnMode.Name = "ColumnMode";
            this.ColumnMode.ReadOnly = true;
            // 
            // ColumnPadding
            // 
            this.ColumnPadding.HeaderText = "Padding";
            this.ColumnPadding.Name = "ColumnPadding";
            this.ColumnPadding.ReadOnly = true;
            // 
            // ColumnEnDeCrypt
            // 
            this.ColumnEnDeCrypt.HeaderText = "En/De crypt";
            this.ColumnEnDeCrypt.Name = "ColumnEnDeCrypt";
            this.ColumnEnDeCrypt.ReadOnly = true;
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_FilePath);
            this.Controls.Add(this.btn_SelectFile);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.TextBox text_FilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAlgorithms;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPadding;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnDeCrypt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
    }
}

