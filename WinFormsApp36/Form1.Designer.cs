namespace WinFormsApp36
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
            groupBox1 = new GroupBox();
            dgvMass = new DataGridView();
            btGenerate = new Button();
            txtArray = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btBubbleSort = new Button();
            txtBubbleSort = new TextBox();
            label2 = new Label();
            btExit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMass).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvMass);
            groupBox1.Controls.Add(btGenerate);
            groupBox1.Controls.Add(txtArray);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(881, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Генерація масиву";
            // 
            // dgvMass
            // 
            dgvMass.AllowUserToOrderColumns = true;
            dgvMass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMass.Location = new Point(297, 26);
            dgvMass.Name = "dgvMass";
            dgvMass.RowHeadersWidth = 51;
            dgvMass.RowTemplate.Height = 29;
            dgvMass.Size = new Size(578, 152);
            dgvMass.TabIndex = 3;
            // 
            // btGenerate
            // 
            btGenerate.Location = new Point(361, 184);
            btGenerate.Name = "btGenerate";
            btGenerate.Size = new Size(429, 47);
            btGenerate.TabIndex = 2;
            btGenerate.Text = "Згенерувати порожній масив";
            btGenerate.UseVisualStyleBackColor = true;
            btGenerate.Click += btGenerate_Click;
            // 
            // txtArray
            // 
            txtArray.Location = new Point(27, 130);
            txtArray.Name = "txtArray";
            txtArray.Size = new Size(220, 34);
            txtArray.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(27, 63);
            label1.Name = "label1";
            label1.Size = new Size(234, 101);
            label1.TabIndex = 0;
            label1.Text = "Введіть кількість елементів масиву:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btBubbleSort);
            groupBox2.Controls.Add(txtBubbleSort);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(881, 154);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "«Бульбашкова» сортування";
            // 
            // btBubbleSort
            // 
            btBubbleSort.Location = new Point(6, 33);
            btBubbleSort.Name = "btBubbleSort";
            btBubbleSort.Size = new Size(255, 102);
            btBubbleSort.TabIndex = 2;
            btBubbleSort.Text = "Сортувати";
            btBubbleSort.UseVisualStyleBackColor = true;
            btBubbleSort.Click += btBubbleSort_Click;
            // 
            // txtBubbleSort
            // 
            txtBubbleSort.Location = new Point(297, 61);
            txtBubbleSort.Multiline = true;
            txtBubbleSort.Name = "txtBubbleSort";
            txtBubbleSort.Size = new Size(566, 84);
            txtBubbleSort.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 30);
            label2.Name = "label2";
            label2.Size = new Size(239, 28);
            label2.TabIndex = 0;
            label2.Text = "Масив після сортування:";
            // 
            // btExit
            // 
            btExit.Location = new Point(294, 415);
            btExit.Name = "btExit";
            btExit.Size = new Size(278, 42);
            btExit.TabIndex = 2;
            btExit.Text = "Вихід";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 469);
            Controls.Add(btExit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Сортування «бульбашкою»";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMass).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvMass;
        private Button btGenerate;
        private TextBox txtArray;
        private Label label1;
        private GroupBox groupBox2;
        private Button btBubbleSort;
        private TextBox txtBubbleSort;
        private Label label2;
        private Button btExit;
    }
}