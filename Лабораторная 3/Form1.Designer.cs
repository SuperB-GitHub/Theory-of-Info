namespace Лабораторная_3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGW_Matrix = new System.Windows.Forms.DataGridView();
            this.B_Matrix = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Row = new System.Windows.Forms.ComboBox();
            this.CB_Column = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RB_H = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RB_G = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1284, 861);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPage1.Controls.Add(this.DGW_Matrix);
            this.tabPage1.Controls.Add(this.B_Matrix);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.CB_Row);
            this.tabPage1.Controls.Add(this.CB_Column);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.RB_H);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.RB_G);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1276, 835);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Этап 1. Введение G и H";
            // 
            // DGW_Matrix
            // 
            this.DGW_Matrix.AllowUserToAddRows = false;
            this.DGW_Matrix.AllowUserToDeleteRows = false;
            this.DGW_Matrix.AllowUserToResizeColumns = false;
            this.DGW_Matrix.AllowUserToResizeRows = false;
            this.DGW_Matrix.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGW_Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Matrix.ColumnHeadersVisible = false;
            this.DGW_Matrix.Location = new System.Drawing.Point(160, 65);
            this.DGW_Matrix.Name = "DGW_Matrix";
            this.DGW_Matrix.RowHeadersVisible = false;
            this.DGW_Matrix.Size = new System.Drawing.Size(363, 363);
            this.DGW_Matrix.TabIndex = 9;
            // 
            // B_Matrix
            // 
            this.B_Matrix.BackColor = System.Drawing.Color.SlateBlue;
            this.B_Matrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Matrix.Location = new System.Drawing.Point(1065, 17);
            this.B_Matrix.Name = "B_Matrix";
            this.B_Matrix.Size = new System.Drawing.Size(178, 30);
            this.B_Matrix.TabIndex = 8;
            this.B_Matrix.Text = "Создание";
            this.B_Matrix.UseVisualStyleBackColor = false;
            this.B_Matrix.Click += new System.EventHandler(this.B_Matrix_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(915, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Х";
            // 
            // CB_Row
            // 
            this.CB_Row.FormattingEnabled = true;
            this.CB_Row.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Row.Location = new System.Drawing.Point(834, 20);
            this.CB_Row.Name = "CB_Row";
            this.CB_Row.Size = new System.Drawing.Size(75, 28);
            this.CB_Row.TabIndex = 6;
            this.CB_Row.Text = "2";
            // 
            // CB_Column
            // 
            this.CB_Column.FormattingEnabled = true;
            this.CB_Column.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CB_Column.Location = new System.Drawing.Point(947, 20);
            this.CB_Column.MaxDropDownItems = 4;
            this.CB_Column.Name = "CB_Column";
            this.CB_Column.Size = new System.Drawing.Size(75, 28);
            this.CB_Column.TabIndex = 5;
            this.CB_Column.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(493, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "матрицу для ввода и её размер:";
            // 
            // RB_H
            // 
            this.RB_H.AutoSize = true;
            this.RB_H.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RB_H.Location = new System.Drawing.Point(441, 17);
            this.RB_H.Name = "RB_H";
            this.RB_H.Size = new System.Drawing.Size(46, 29);
            this.RB_H.TabIndex = 3;
            this.RB_H.Text = "H";
            this.RB_H.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(387, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "или";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сначала необходимо выбрать ";
            // 
            // RB_G
            // 
            this.RB_G.AutoSize = true;
            this.RB_G.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RB_G.Location = new System.Drawing.Point(335, 17);
            this.RB_G.Name = "RB_G";
            this.RB_G.Size = new System.Drawing.Size(47, 29);
            this.RB_G.TabIndex = 0;
            this.RB_G.Text = "G";
            this.RB_G.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1276, 835);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1284, 861);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №3";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Matrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton RB_G;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RB_H;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Row;
        private System.Windows.Forms.ComboBox CB_Column;
        private System.Windows.Forms.Button B_Matrix;
        private System.Windows.Forms.DataGridView DGW_Matrix;
    }
}

