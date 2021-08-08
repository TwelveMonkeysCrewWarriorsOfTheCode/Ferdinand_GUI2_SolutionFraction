
namespace ProjetFractionUIWithNumericComp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.CBSelectOperation = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBArithmeticResult = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.NUDArithDenominator2 = new System.Windows.Forms.NumericUpDown();
            this.NUDArithNumerator2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUDArithDenominator1 = new System.Windows.Forms.NumericUpDown();
            this.NUDArithNumerator1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.TBComparingResult = new System.Windows.Forms.TextBox();
            this.BtnCompare = new System.Windows.Forms.Button();
            this.NUDCompDenominator2 = new System.Windows.Forms.NumericUpDown();
            this.NUDCompNumerator2 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NUDCompDenominator1 = new System.Windows.Forms.NumericUpDown();
            this.NUDCompNumerator1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RTBSavingHistoric = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArithDenominator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArithNumerator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArithDenominator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArithNumerator1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCompDenominator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCompNumerator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCompDenominator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCompNumerator1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.CBSelectOperation);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.TBArithmeticResult);
            this.tabPage1.Controls.Add(this.BtnCalculate);
            this.tabPage1.Controls.Add(this.NUDArithDenominator2);
            this.tabPage1.Controls.Add(this.NUDArithNumerator2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.NUDArithDenominator1);
            this.tabPage1.Controls.Add(this.NUDArithNumerator1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arithmétique";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "Choix opération";
            // 
            // CBSelectOperation
            // 
            this.CBSelectOperation.FormattingEnabled = true;
            this.CBSelectOperation.Items.AddRange(new object[] {
            "Addition",
            "Soustraction",
            "Multiplication",
            "Division"});
            this.CBSelectOperation.Location = new System.Drawing.Point(139, 216);
            this.CBSelectOperation.Name = "CBSelectOperation";
            this.CBSelectOperation.Size = new System.Drawing.Size(121, 23);
            this.CBSelectOperation.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Résultat";
            // 
            // TBArithmeticResult
            // 
            this.TBArithmeticResult.Location = new System.Drawing.Point(19, 346);
            this.TBArithmeticResult.Name = "TBArithmeticResult";
            this.TBArithmeticResult.Size = new System.Drawing.Size(241, 23);
            this.TBArithmeticResult.TabIndex = 11;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(19, 274);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(241, 38);
            this.BtnCalculate.TabIndex = 10;
            this.BtnCalculate.Text = "Calculer";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // NUDArithDenominator2
            // 
            this.NUDArithDenominator2.Location = new System.Drawing.Point(140, 173);
            this.NUDArithDenominator2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDArithDenominator2.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NUDArithDenominator2.Name = "NUDArithDenominator2";
            this.NUDArithDenominator2.ReadOnly = true;
            this.NUDArithDenominator2.Size = new System.Drawing.Size(120, 23);
            this.NUDArithDenominator2.TabIndex = 9;
            // 
            // NUDArithNumerator2
            // 
            this.NUDArithNumerator2.Location = new System.Drawing.Point(140, 138);
            this.NUDArithNumerator2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDArithNumerator2.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NUDArithNumerator2.Name = "NUDArithNumerator2";
            this.NUDArithNumerator2.ReadOnly = true;
            this.NUDArithNumerator2.Size = new System.Drawing.Size(120, 23);
            this.NUDArithNumerator2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dénominateur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Numérateur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fraction 2";
            // 
            // NUDArithDenominator1
            // 
            this.NUDArithDenominator1.Location = new System.Drawing.Point(140, 83);
            this.NUDArithDenominator1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDArithDenominator1.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NUDArithDenominator1.Name = "NUDArithDenominator1";
            this.NUDArithDenominator1.ReadOnly = true;
            this.NUDArithDenominator1.Size = new System.Drawing.Size(120, 23);
            this.NUDArithDenominator1.TabIndex = 4;
            // 
            // NUDArithNumerator1
            // 
            this.NUDArithNumerator1.Location = new System.Drawing.Point(140, 48);
            this.NUDArithNumerator1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDArithNumerator1.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NUDArithNumerator1.Name = "NUDArithNumerator1";
            this.NUDArithNumerator1.ReadOnly = true;
            this.NUDArithNumerator1.Size = new System.Drawing.Size(120, 23);
            this.NUDArithNumerator1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dénominateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numérateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fraction 1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.TBComparingResult);
            this.tabPage2.Controls.Add(this.BtnCompare);
            this.tabPage2.Controls.Add(this.NUDCompDenominator2);
            this.tabPage2.Controls.Add(this.NUDCompNumerator2);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.NUDCompDenominator1);
            this.tabPage2.Controls.Add(this.NUDCompNumerator1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comparaison";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Résultat";
            // 
            // TBComparingResult
            // 
            this.TBComparingResult.Location = new System.Drawing.Point(19, 300);
            this.TBComparingResult.Name = "TBComparingResult";
            this.TBComparingResult.Size = new System.Drawing.Size(248, 23);
            this.TBComparingResult.TabIndex = 11;
            // 
            // BtnCompare
            // 
            this.BtnCompare.Location = new System.Drawing.Point(19, 218);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(248, 43);
            this.BtnCompare.TabIndex = 10;
            this.BtnCompare.Text = "Comparer";
            this.BtnCompare.UseVisualStyleBackColor = true;
            this.BtnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // NUDCompDenominator2
            // 
            this.NUDCompDenominator2.Location = new System.Drawing.Point(147, 171);
            this.NUDCompDenominator2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDCompDenominator2.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NUDCompDenominator2.Name = "NUDCompDenominator2";
            this.NUDCompDenominator2.ReadOnly = true;
            this.NUDCompDenominator2.Size = new System.Drawing.Size(120, 23);
            this.NUDCompDenominator2.TabIndex = 9;
            // 
            // NUDCompNumerator2
            // 
            this.NUDCompNumerator2.Location = new System.Drawing.Point(147, 140);
            this.NUDCompNumerator2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDCompNumerator2.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NUDCompNumerator2.Name = "NUDCompNumerator2";
            this.NUDCompNumerator2.ReadOnly = true;
            this.NUDCompNumerator2.Size = new System.Drawing.Size(120, 23);
            this.NUDCompNumerator2.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Dénominateur";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Numérateur";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "Fraction 2";
            // 
            // NUDCompDenominator1
            // 
            this.NUDCompDenominator1.Location = new System.Drawing.Point(147, 76);
            this.NUDCompDenominator1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDCompDenominator1.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NUDCompDenominator1.Name = "NUDCompDenominator1";
            this.NUDCompDenominator1.ReadOnly = true;
            this.NUDCompDenominator1.Size = new System.Drawing.Size(120, 23);
            this.NUDCompDenominator1.TabIndex = 4;
            // 
            // NUDCompNumerator1
            // 
            this.NUDCompNumerator1.Location = new System.Drawing.Point(147, 45);
            this.NUDCompNumerator1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDCompNumerator1.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NUDCompNumerator1.Name = "NUDCompNumerator1";
            this.NUDCompNumerator1.ReadOnly = true;
            this.NUDCompNumerator1.Size = new System.Drawing.Size(120, 23);
            this.NUDCompNumerator1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Dénominateur";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Numérateur";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fraction 1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RTBSavingHistoric);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(798, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Historique de sauvegarde";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RTBSavingHistoric
            // 
            this.RTBSavingHistoric.Location = new System.Drawing.Point(3, 3);
            this.RTBSavingHistoric.Name = "RTBSavingHistoric";
            this.RTBSavingHistoric.Size = new System.Drawing.Size(792, 422);
            this.RTBSavingHistoric.TabIndex = 0;
            this.RTBSavingHistoric.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Opérations sur les fractions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArithDenominator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArithNumerator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArithDenominator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArithNumerator1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCompDenominator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCompNumerator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCompDenominator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCompNumerator1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBArithmeticResult;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.NumericUpDown NUDArithDenominator2;
        private System.Windows.Forms.NumericUpDown NUDArithNumerator2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUDArithDenominator1;
        private System.Windows.Forms.NumericUpDown NUDArithNumerator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TBComparingResult;
        private System.Windows.Forms.Button BtnCompare;
        private System.Windows.Forms.NumericUpDown NUDCompDenominator2;
        private System.Windows.Forms.NumericUpDown NUDCompNumerator2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown NUDCompDenominator1;
        private System.Windows.Forms.NumericUpDown NUDCompNumerator1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox RTBSavingHistoric;
        private System.Windows.Forms.ComboBox CBSelectOperation;
        private System.Windows.Forms.Label label15;
    }
}

