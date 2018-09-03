namespace Calculator
{
    partial class mainForm
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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btSeven = new System.Windows.Forms.Button();
            this.btEight = new System.Windows.Forms.Button();
            this.btNine = new System.Windows.Forms.Button();
            this.btSix = new System.Windows.Forms.Button();
            this.btFive = new System.Windows.Forms.Button();
            this.btFour = new System.Windows.Forms.Button();
            this.btThree = new System.Windows.Forms.Button();
            this.btTwo = new System.Windows.Forms.Button();
            this.btOne = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.btZero = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btTimes = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCos = new System.Windows.Forms.Button();
            this.btSin = new System.Windows.Forms.Button();
            this.btTan = new System.Windows.Forms.Button();
            this.btInv = new System.Windows.Forms.Button();
            this.btCurt = new System.Windows.Forms.Button();
            this.btSqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDisplay.Location = new System.Drawing.Point(12, 12);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.Size = new System.Drawing.Size(227, 20);
            this.tbDisplay.TabIndex = 0;
            // 
            // btSeven
            // 
            this.btSeven.Location = new System.Drawing.Point(245, 12);
            this.btSeven.Name = "btSeven";
            this.btSeven.Size = new System.Drawing.Size(38, 36);
            this.btSeven.TabIndex = 1;
            this.btSeven.Text = "7";
            this.btSeven.UseVisualStyleBackColor = true;
            this.btSeven.Click += new System.EventHandler(this.btSeven_Click);
            // 
            // btEight
            // 
            this.btEight.Location = new System.Drawing.Point(289, 12);
            this.btEight.Name = "btEight";
            this.btEight.Size = new System.Drawing.Size(38, 36);
            this.btEight.TabIndex = 2;
            this.btEight.Text = "8";
            this.btEight.UseVisualStyleBackColor = true;
            this.btEight.Click += new System.EventHandler(this.btEight_Click);
            // 
            // btNine
            // 
            this.btNine.Location = new System.Drawing.Point(333, 12);
            this.btNine.Name = "btNine";
            this.btNine.Size = new System.Drawing.Size(38, 36);
            this.btNine.TabIndex = 3;
            this.btNine.Text = "9";
            this.btNine.UseVisualStyleBackColor = true;
            this.btNine.Click += new System.EventHandler(this.btNine_Click);
            // 
            // btSix
            // 
            this.btSix.Location = new System.Drawing.Point(333, 54);
            this.btSix.Name = "btSix";
            this.btSix.Size = new System.Drawing.Size(38, 36);
            this.btSix.TabIndex = 6;
            this.btSix.Text = "6";
            this.btSix.UseVisualStyleBackColor = true;
            this.btSix.Click += new System.EventHandler(this.btSix_Click);
            // 
            // btFive
            // 
            this.btFive.Location = new System.Drawing.Point(289, 54);
            this.btFive.Name = "btFive";
            this.btFive.Size = new System.Drawing.Size(38, 36);
            this.btFive.TabIndex = 5;
            this.btFive.Text = "5";
            this.btFive.UseVisualStyleBackColor = true;
            this.btFive.Click += new System.EventHandler(this.btFive_Click);
            // 
            // btFour
            // 
            this.btFour.Location = new System.Drawing.Point(245, 54);
            this.btFour.Name = "btFour";
            this.btFour.Size = new System.Drawing.Size(38, 36);
            this.btFour.TabIndex = 4;
            this.btFour.Text = "4";
            this.btFour.UseVisualStyleBackColor = true;
            this.btFour.Click += new System.EventHandler(this.btFour_Click);
            // 
            // btThree
            // 
            this.btThree.Location = new System.Drawing.Point(333, 96);
            this.btThree.Name = "btThree";
            this.btThree.Size = new System.Drawing.Size(38, 36);
            this.btThree.TabIndex = 9;
            this.btThree.Text = "3";
            this.btThree.UseVisualStyleBackColor = true;
            this.btThree.Click += new System.EventHandler(this.btThree_Click);
            // 
            // btTwo
            // 
            this.btTwo.Location = new System.Drawing.Point(289, 96);
            this.btTwo.Name = "btTwo";
            this.btTwo.Size = new System.Drawing.Size(38, 36);
            this.btTwo.TabIndex = 8;
            this.btTwo.Text = "2";
            this.btTwo.UseVisualStyleBackColor = true;
            this.btTwo.Click += new System.EventHandler(this.btTwo_Click);
            // 
            // btOne
            // 
            this.btOne.Location = new System.Drawing.Point(245, 96);
            this.btOne.Name = "btOne";
            this.btOne.Size = new System.Drawing.Size(38, 36);
            this.btOne.TabIndex = 7;
            this.btOne.Text = "1";
            this.btOne.UseVisualStyleBackColor = true;
            this.btOne.Click += new System.EventHandler(this.btOne_Click);
            // 
            // btEquals
            // 
            this.btEquals.Location = new System.Drawing.Point(333, 138);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(38, 36);
            this.btEquals.TabIndex = 12;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click);
            // 
            // btDot
            // 
            this.btDot.Location = new System.Drawing.Point(289, 138);
            this.btDot.Name = "btDot";
            this.btDot.Size = new System.Drawing.Size(38, 36);
            this.btDot.TabIndex = 11;
            this.btDot.Text = ".";
            this.btDot.UseVisualStyleBackColor = true;
            this.btDot.Click += new System.EventHandler(this.btDot_Click);
            // 
            // btZero
            // 
            this.btZero.Location = new System.Drawing.Point(245, 138);
            this.btZero.Name = "btZero";
            this.btZero.Size = new System.Drawing.Size(38, 36);
            this.btZero.TabIndex = 10;
            this.btZero.Text = "0";
            this.btZero.UseVisualStyleBackColor = true;
            this.btZero.Click += new System.EventHandler(this.btZero_Click);
            // 
            // btDivide
            // 
            this.btDivide.Location = new System.Drawing.Point(377, 138);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(38, 36);
            this.btDivide.TabIndex = 16;
            this.btDivide.Text = "/";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.btDivide_Click);
            // 
            // btTimes
            // 
            this.btTimes.Location = new System.Drawing.Point(377, 96);
            this.btTimes.Name = "btTimes";
            this.btTimes.Size = new System.Drawing.Size(38, 36);
            this.btTimes.TabIndex = 15;
            this.btTimes.Text = "*";
            this.btTimes.UseVisualStyleBackColor = true;
            this.btTimes.Click += new System.EventHandler(this.btTimes_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(377, 54);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(38, 36);
            this.btMinus.TabIndex = 14;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(377, 12);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(38, 36);
            this.btPlus.TabIndex = 13;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(144, 138);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(95, 36);
            this.btClear.TabIndex = 23;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCos
            // 
            this.btCos.Location = new System.Drawing.Point(100, 96);
            this.btCos.Name = "btCos";
            this.btCos.Size = new System.Drawing.Size(38, 36);
            this.btCos.TabIndex = 22;
            this.btCos.Text = "Cos";
            this.btCos.UseVisualStyleBackColor = true;
            this.btCos.Click += new System.EventHandler(this.btCos_Click);
            // 
            // btSin
            // 
            this.btSin.Location = new System.Drawing.Point(56, 96);
            this.btSin.Name = "btSin";
            this.btSin.Size = new System.Drawing.Size(38, 36);
            this.btSin.TabIndex = 21;
            this.btSin.Text = "Sin";
            this.btSin.UseVisualStyleBackColor = true;
            this.btSin.Click += new System.EventHandler(this.btSin_Click);
            // 
            // btTan
            // 
            this.btTan.Location = new System.Drawing.Point(12, 96);
            this.btTan.Name = "btTan";
            this.btTan.Size = new System.Drawing.Size(38, 36);
            this.btTan.TabIndex = 20;
            this.btTan.Text = "Tan";
            this.btTan.UseVisualStyleBackColor = true;
            this.btTan.Click += new System.EventHandler(this.btTan_Click);
            // 
            // btInv
            // 
            this.btInv.Location = new System.Drawing.Point(100, 54);
            this.btInv.Name = "btInv";
            this.btInv.Size = new System.Drawing.Size(38, 36);
            this.btInv.TabIndex = 19;
            this.btInv.Text = "Inv";
            this.btInv.UseVisualStyleBackColor = true;
            this.btInv.Click += new System.EventHandler(this.btInv_Click);
            // 
            // btCurt
            // 
            this.btCurt.Location = new System.Drawing.Point(56, 54);
            this.btCurt.Name = "btCurt";
            this.btCurt.Size = new System.Drawing.Size(38, 36);
            this.btCurt.TabIndex = 18;
            this.btCurt.Text = "Curt";
            this.btCurt.UseVisualStyleBackColor = true;
            this.btCurt.Click += new System.EventHandler(this.btCurt_Click);
            // 
            // btSqrt
            // 
            this.btSqrt.Location = new System.Drawing.Point(12, 54);
            this.btSqrt.Name = "btSqrt";
            this.btSqrt.Size = new System.Drawing.Size(38, 36);
            this.btSqrt.TabIndex = 17;
            this.btSqrt.Text = "Sqrt";
            this.btSqrt.UseVisualStyleBackColor = true;
            this.btSqrt.Click += new System.EventHandler(this.btSqrt_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 183);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCos);
            this.Controls.Add(this.btSin);
            this.Controls.Add(this.btTan);
            this.Controls.Add(this.btInv);
            this.Controls.Add(this.btCurt);
            this.Controls.Add(this.btSqrt);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btTimes);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.btDot);
            this.Controls.Add(this.btZero);
            this.Controls.Add(this.btThree);
            this.Controls.Add(this.btTwo);
            this.Controls.Add(this.btOne);
            this.Controls.Add(this.btSix);
            this.Controls.Add(this.btFive);
            this.Controls.Add(this.btFour);
            this.Controls.Add(this.btNine);
            this.Controls.Add(this.btEight);
            this.Controls.Add(this.btSeven);
            this.Controls.Add(this.tbDisplay);
            this.Name = "mainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btSeven;
        private System.Windows.Forms.Button btEight;
        private System.Windows.Forms.Button btNine;
        private System.Windows.Forms.Button btSix;
        private System.Windows.Forms.Button btFive;
        private System.Windows.Forms.Button btFour;
        private System.Windows.Forms.Button btThree;
        private System.Windows.Forms.Button btTwo;
        private System.Windows.Forms.Button btOne;
        private System.Windows.Forms.Button btEquals;
        private System.Windows.Forms.Button btDot;
        private System.Windows.Forms.Button btZero;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btTimes;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCos;
        private System.Windows.Forms.Button btSin;
        private System.Windows.Forms.Button btTan;
        private System.Windows.Forms.Button btInv;
        private System.Windows.Forms.Button btCurt;
        private System.Windows.Forms.Button btSqrt;
    }
}

