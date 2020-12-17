
namespace Практическая_работа__10
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.table = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.NumericUpDown();
            this.kol1 = new System.Windows.Forms.NumericUpDown();
            this.min1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minRez1 = new System.Windows.Forms.TextBox();
            this.maxRez1 = new System.Windows.Forms.TextBox();
            this.A1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(13, 28);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(668, 91);
            this.table.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Заполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Вычислить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.max1);
            this.groupBox1.Controls.Add(this.kol1);
            this.groupBox1.Controls.Add(this.min1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(13, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Интервал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = " - количество элементов";
            // 
            // max1
            // 
            this.max1.Location = new System.Drawing.Point(101, 29);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(93, 26);
            this.max1.TabIndex = 1;
            this.max1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // kol1
            // 
            this.kol1.Location = new System.Drawing.Point(6, 84);
            this.kol1.Name = "kol1";
            this.kol1.Size = new System.Drawing.Size(93, 26);
            this.kol1.TabIndex = 5;
            this.kol1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.kol1.ValueChanged += new System.EventHandler(this.kol1_ValueChanged);
            // 
            // min1
            // 
            this.min1.Location = new System.Drawing.Point(7, 29);
            this.min1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(93, 26);
            this.min1.TabIndex = 0;
            this.min1.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.minRez1);
            this.groupBox2.Controls.Add(this.maxRez1);
            this.groupBox2.Location = new System.Drawing.Point(377, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 184);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Минимальное число, \r\nкратное А:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Максимальное чётное число:";
            // 
            // minRez1
            // 
            this.minRez1.Location = new System.Drawing.Point(195, 148);
            this.minRez1.Name = "minRez1";
            this.minRez1.ReadOnly = true;
            this.minRez1.Size = new System.Drawing.Size(100, 26);
            this.minRez1.TabIndex = 3;
            // 
            // maxRez1
            // 
            this.maxRez1.Location = new System.Drawing.Point(195, 61);
            this.maxRez1.Name = "maxRez1";
            this.maxRez1.ReadOnly = true;
            this.maxRez1.Size = new System.Drawing.Size(100, 26);
            this.maxRez1.TabIndex = 2;
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(242, 252);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(122, 26);
            this.A1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Укажите число А:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.table);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Практическая работа №10";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown max1;
        private System.Windows.Forms.NumericUpDown kol1;
        private System.Windows.Forms.NumericUpDown min1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minRez1;
        private System.Windows.Forms.TextBox maxRez1;
        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.Label label2;
    }
}

