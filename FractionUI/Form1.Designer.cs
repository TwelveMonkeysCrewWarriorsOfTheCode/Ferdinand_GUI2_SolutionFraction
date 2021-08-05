
namespace FractionUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TBArithmetic = new System.Windows.Forms.TabControl();
            this.tabArithmetic = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.TBArithmeticResult = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CBSelectOperation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBArithmeticFraction2 = new System.Windows.Forms.TextBox();
            this.TBArithmeticFraction1 = new System.Windows.Forms.TextBox();
            this.tabComparison = new System.Windows.Forms.TabPage();
            this.BtnCompare = new System.Windows.Forms.Button();
            this.TBCompResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBCompFraction2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBCompFraction1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBESave = new System.Windows.Forms.TabPage();
            this.RTBSave = new System.Windows.Forms.RichTextBox();
            this.TBArithmetic.SuspendLayout();
            this.tabArithmetic.SuspendLayout();
            this.tabComparison.SuspendLayout();
            this.TBESave.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TBArithmetic
            // 
            this.TBArithmetic.Controls.Add(this.tabArithmetic);
            this.TBArithmetic.Controls.Add(this.tabComparison);
            this.TBArithmetic.Controls.Add(this.TBESave);
            this.TBArithmetic.Location = new System.Drawing.Point(0, 0);
            this.TBArithmetic.Name = "TBArithmetic";
            this.TBArithmetic.SelectedIndex = 0;
            this.TBArithmetic.Size = new System.Drawing.Size(682, 422);
            this.TBArithmetic.TabIndex = 1;
            // 
            // tabArithmetic
            // 
            this.tabArithmetic.BackColor = System.Drawing.Color.Gainsboro;
            this.tabArithmetic.Controls.Add(this.label4);
            this.tabArithmetic.Controls.Add(this.TBArithmeticResult);
            this.tabArithmetic.Controls.Add(this.BtnCalculate);
            this.tabArithmetic.Controls.Add(this.label3);
            this.tabArithmetic.Controls.Add(this.CBSelectOperation);
            this.tabArithmetic.Controls.Add(this.label2);
            this.tabArithmetic.Controls.Add(this.label1);
            this.tabArithmetic.Controls.Add(this.TBArithmeticFraction2);
            this.tabArithmetic.Controls.Add(this.TBArithmeticFraction1);
            this.tabArithmetic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabArithmetic.Location = new System.Drawing.Point(4, 24);
            this.tabArithmetic.Name = "tabArithmetic";
            this.tabArithmetic.Padding = new System.Windows.Forms.Padding(3);
            this.tabArithmetic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabArithmetic.Size = new System.Drawing.Size(674, 394);
            this.tabArithmetic.TabIndex = 0;
            this.tabArithmetic.Text = "Arithmétique";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Résultat";
            // 
            // TBArithmeticResult
            // 
            this.TBArithmeticResult.Location = new System.Drawing.Point(8, 283);
            this.TBArithmeticResult.Name = "TBArithmeticResult";
            this.TBArithmeticResult.Size = new System.Drawing.Size(158, 23);
            this.TBArithmeticResult.TabIndex = 7;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(8, 200);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(158, 36);
            this.BtnCalculate.TabIndex = 6;
            this.BtnCalculate.Text = "Calculer";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choix opération";
            // 
            // CBSelectOperation
            // 
            this.CBSelectOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSelectOperation.FormattingEnabled = true;
            this.CBSelectOperation.Items.AddRange(new object[] {
            "Addition",
            "Soustraction",
            "Multiplication",
            "Division"});
            this.CBSelectOperation.Location = new System.Drawing.Point(8, 156);
            this.CBSelectOperation.MaxDropDownItems = 4;
            this.CBSelectOperation.Name = "CBSelectOperation";
            this.CBSelectOperation.Size = new System.Drawing.Size(158, 23);
            this.CBSelectOperation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fraction 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fraction 1";
            // 
            // TBArithmeticFraction2
            // 
            this.TBArithmeticFraction2.Location = new System.Drawing.Point(8, 95);
            this.TBArithmeticFraction2.Name = "TBArithmeticFraction2";
            this.TBArithmeticFraction2.Size = new System.Drawing.Size(158, 23);
            this.TBArithmeticFraction2.TabIndex = 1;
            // 
            // TBArithmeticFraction1
            // 
            this.TBArithmeticFraction1.Location = new System.Drawing.Point(8, 31);
            this.TBArithmeticFraction1.Name = "TBArithmeticFraction1";
            this.TBArithmeticFraction1.Size = new System.Drawing.Size(158, 23);
            this.TBArithmeticFraction1.TabIndex = 0;
            // 
            // tabComparison
            // 
            this.tabComparison.BackColor = System.Drawing.Color.Silver;
            this.tabComparison.Controls.Add(this.BtnCompare);
            this.tabComparison.Controls.Add(this.TBCompResult);
            this.tabComparison.Controls.Add(this.label8);
            this.tabComparison.Controls.Add(this.TBCompFraction2);
            this.tabComparison.Controls.Add(this.label6);
            this.tabComparison.Controls.Add(this.TBCompFraction1);
            this.tabComparison.Controls.Add(this.label5);
            this.tabComparison.Location = new System.Drawing.Point(4, 24);
            this.tabComparison.Name = "tabComparison";
            this.tabComparison.Padding = new System.Windows.Forms.Padding(3);
            this.tabComparison.Size = new System.Drawing.Size(674, 394);
            this.tabComparison.TabIndex = 1;
            this.tabComparison.Text = "Comparaison";
            // 
            // BtnCompare
            // 
            this.BtnCompare.Location = new System.Drawing.Point(9, 141);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(156, 37);
            this.BtnCompare.TabIndex = 8;
            this.BtnCompare.Text = "Comparer";
            this.BtnCompare.UseVisualStyleBackColor = true;
            this.BtnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // TBCompResult
            // 
            this.TBCompResult.Location = new System.Drawing.Point(10, 216);
            this.TBCompResult.Name = "TBCompResult";
            this.TBCompResult.Size = new System.Drawing.Size(156, 23);
            this.TBCompResult.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Résultat";
            // 
            // TBCompFraction2
            // 
            this.TBCompFraction2.Location = new System.Drawing.Point(10, 91);
            this.TBCompFraction2.Name = "TBCompFraction2";
            this.TBCompFraction2.Size = new System.Drawing.Size(155, 23);
            this.TBCompFraction2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fraction 2";
            // 
            // TBCompFraction1
            // 
            this.TBCompFraction1.Location = new System.Drawing.Point(9, 35);
            this.TBCompFraction1.Name = "TBCompFraction1";
            this.TBCompFraction1.Size = new System.Drawing.Size(156, 23);
            this.TBCompFraction1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fraction 1";
            // 
            // TBESave
            // 
            this.TBESave.Controls.Add(this.RTBSave);
            this.TBESave.Location = new System.Drawing.Point(4, 24);
            this.TBESave.Name = "TBESave";
            this.TBESave.Size = new System.Drawing.Size(674, 394);
            this.TBESave.TabIndex = 2;
            this.TBESave.Text = "Historique de Sauvegarde";
            this.TBESave.UseVisualStyleBackColor = true;
            // 
            // RTBSave
            // 
            this.RTBSave.Location = new System.Drawing.Point(8, 3);
            this.RTBSave.Name = "RTBSave";
            this.RTBSave.ReadOnly = true;
            this.RTBSave.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RTBSave.Size = new System.Drawing.Size(666, 384);
            this.RTBSave.TabIndex = 0;
            this.RTBSave.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 423);
            this.Controls.Add(this.TBArithmetic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Opérations sur les fractions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TBArithmetic.ResumeLayout(false);
            this.tabArithmetic.ResumeLayout(false);
            this.tabArithmetic.PerformLayout();
            this.tabComparison.ResumeLayout(false);
            this.tabComparison.PerformLayout();
            this.TBESave.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl TBArithmetic;
        private System.Windows.Forms.TabPage tabArithmetic;
        private System.Windows.Forms.ComboBox CBSelectOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBArithmeticFraction2;
        private System.Windows.Forms.TextBox TBArithmeticFraction1;
        private System.Windows.Forms.TabPage tabComparison;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBArithmeticResult;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBCompFraction1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCompare;
        private System.Windows.Forms.TextBox TBCompResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBCompFraction2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage TBESave;
        private System.Windows.Forms.RichTextBox RTBSave;
    }
}

