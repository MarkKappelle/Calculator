namespace Calculator
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
            this.buttonNumOne = new System.Windows.Forms.Button();
            this.buttonNumTwo = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.buttonOpPlus = new System.Windows.Forms.Button();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonNumThree = new System.Windows.Forms.Button();
            this.buttonNumSix = new System.Windows.Forms.Button();
            this.buttonNumFive = new System.Windows.Forms.Button();
            this.buttonNumFour = new System.Windows.Forms.Button();
            this.buttonNumNine = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.buttonNumZero = new System.Windows.Forms.Button();
            this.buttonNumPoint = new System.Windows.Forms.Button();
            this.buttonOpMinus = new System.Windows.Forms.Button();
            this.buttonOpTimes = new System.Windows.Forms.Button();
            this.buttonOpDevided = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.historyBox = new System.Windows.Forms.TextBox();
            this.buttonMemoryOne = new System.Windows.Forms.Button();
            this.buttonMemoryTwo = new System.Windows.Forms.Button();
            this.buttonMemoryThree = new System.Windows.Forms.Button();
            this.buttonMemoryClear = new System.Windows.Forms.Button();
            this.buttonOpPercent = new System.Windows.Forms.Button();
            this.checkBoxEuro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonNumOne
            // 
            this.buttonNumOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumOne.Location = new System.Drawing.Point(17, 262);
            this.buttonNumOne.Name = "buttonNumOne";
            this.buttonNumOne.Size = new System.Drawing.Size(50, 50);
            this.buttonNumOne.TabIndex = 0;
            this.buttonNumOne.Text = "1";
            this.buttonNumOne.UseVisualStyleBackColor = true;
            this.buttonNumOne.Click += new System.EventHandler(this.NumClick);
            // 
            // buttonNumTwo
            // 
            this.buttonNumTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumTwo.Location = new System.Drawing.Point(73, 262);
            this.buttonNumTwo.Name = "buttonNumTwo";
            this.buttonNumTwo.Size = new System.Drawing.Size(50, 50);
            this.buttonNumTwo.TabIndex = 1;
            this.buttonNumTwo.Text = "2";
            this.buttonNumTwo.UseVisualStyleBackColor = true;
            this.buttonNumTwo.Click += new System.EventHandler(this.NumClick);
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(12, 77);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(417, 67);
            this.resultBox.TabIndex = 2;
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonOpPlus
            // 
            this.buttonOpPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpPlus.Location = new System.Drawing.Point(185, 150);
            this.buttonOpPlus.Name = "buttonOpPlus";
            this.buttonOpPlus.Size = new System.Drawing.Size(50, 50);
            this.buttonOpPlus.TabIndex = 3;
            this.buttonOpPlus.Text = "+";
            this.buttonOpPlus.UseVisualStyleBackColor = true;
            this.buttonOpPlus.Click += new System.EventHandler(this.OpClick);
            // 
            // buttonSolve
            // 
            this.buttonSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSolve.Location = new System.Drawing.Point(17, 374);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(162, 50);
            this.buttonSolve.TabIndex = 4;
            this.buttonSolve.Text = "=";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.MouseCaptureChanged += new System.EventHandler(this.solveClick);
            // 
            // buttonNumThree
            // 
            this.buttonNumThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumThree.Location = new System.Drawing.Point(129, 262);
            this.buttonNumThree.Name = "buttonNumThree";
            this.buttonNumThree.Size = new System.Drawing.Size(50, 50);
            this.buttonNumThree.TabIndex = 5;
            this.buttonNumThree.Text = "3";
            this.buttonNumThree.UseVisualStyleBackColor = true;
            this.buttonNumThree.Click += new System.EventHandler(this.NumClick);
            // 
            // buttonNumSix
            // 
            this.buttonNumSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumSix.Location = new System.Drawing.Point(129, 206);
            this.buttonNumSix.Name = "buttonNumSix";
            this.buttonNumSix.Size = new System.Drawing.Size(50, 50);
            this.buttonNumSix.TabIndex = 8;
            this.buttonNumSix.Text = "6";
            this.buttonNumSix.UseVisualStyleBackColor = true;
            this.buttonNumSix.Click += new System.EventHandler(this.NumClick);
            // 
            // buttonNumFive
            // 
            this.buttonNumFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumFive.Location = new System.Drawing.Point(73, 206);
            this.buttonNumFive.Name = "buttonNumFive";
            this.buttonNumFive.Size = new System.Drawing.Size(50, 50);
            this.buttonNumFive.TabIndex = 7;
            this.buttonNumFive.Text = "5";
            this.buttonNumFive.UseVisualStyleBackColor = true;
            this.buttonNumFive.Click += new System.EventHandler(this.NumClick);
            // 
            // buttonNumFour
            // 
            this.buttonNumFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumFour.Location = new System.Drawing.Point(17, 206);
            this.buttonNumFour.Name = "buttonNumFour";
            this.buttonNumFour.Size = new System.Drawing.Size(50, 50);
            this.buttonNumFour.TabIndex = 6;
            this.buttonNumFour.Text = "4";
            this.buttonNumFour.UseVisualStyleBackColor = true;
            this.buttonNumFour.Click += new System.EventHandler(this.NumClick);
            // 
            // buttonNumNine
            // 
            this.buttonNumNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumNine.Location = new System.Drawing.Point(129, 150);
            this.buttonNumNine.Name = "buttonNumNine";
            this.buttonNumNine.Size = new System.Drawing.Size(50, 50);
            this.buttonNumNine.TabIndex = 11;
            this.buttonNumNine.Text = "9";
            this.buttonNumNine.UseVisualStyleBackColor = true;
            this.buttonNumNine.Click += new System.EventHandler(this.NumClick);
            // 
            // buttonNum8
            // 
            this.buttonNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum8.Location = new System.Drawing.Point(73, 150);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(50, 50);
            this.buttonNum8.TabIndex = 10;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = true;
            this.buttonNum8.Click += new System.EventHandler(this.NumClick);
            // 
            // buttonNum7
            // 
            this.buttonNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum7.Location = new System.Drawing.Point(17, 150);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(50, 50);
            this.buttonNum7.TabIndex = 9;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = true;
            this.buttonNum7.Click += new System.EventHandler(this.NumClick);
            // 
            // buttonNumZero
            // 
            this.buttonNumZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumZero.Location = new System.Drawing.Point(17, 318);
            this.buttonNumZero.Name = "buttonNumZero";
            this.buttonNumZero.Size = new System.Drawing.Size(50, 50);
            this.buttonNumZero.TabIndex = 12;
            this.buttonNumZero.Text = "0";
            this.buttonNumZero.UseVisualStyleBackColor = true;
            this.buttonNumZero.Click += new System.EventHandler(this.NumClick);
            // 
            // buttonNumPoint
            // 
            this.buttonNumPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumPoint.Location = new System.Drawing.Point(73, 318);
            this.buttonNumPoint.Name = "buttonNumPoint";
            this.buttonNumPoint.Size = new System.Drawing.Size(50, 50);
            this.buttonNumPoint.TabIndex = 13;
            this.buttonNumPoint.Text = ",";
            this.buttonNumPoint.UseVisualStyleBackColor = true;
            this.buttonNumPoint.Click += new System.EventHandler(this.NumClick);
            // 
            // buttonOpMinus
            // 
            this.buttonOpMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpMinus.Location = new System.Drawing.Point(185, 206);
            this.buttonOpMinus.Name = "buttonOpMinus";
            this.buttonOpMinus.Size = new System.Drawing.Size(50, 50);
            this.buttonOpMinus.TabIndex = 14;
            this.buttonOpMinus.Text = "-";
            this.buttonOpMinus.UseVisualStyleBackColor = true;
            this.buttonOpMinus.Click += new System.EventHandler(this.OpClick);
            // 
            // buttonOpTimes
            // 
            this.buttonOpTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpTimes.Location = new System.Drawing.Point(185, 262);
            this.buttonOpTimes.Name = "buttonOpTimes";
            this.buttonOpTimes.Size = new System.Drawing.Size(50, 50);
            this.buttonOpTimes.TabIndex = 15;
            this.buttonOpTimes.Text = "*";
            this.buttonOpTimes.UseVisualStyleBackColor = true;
            this.buttonOpTimes.Click += new System.EventHandler(this.OpClick);
            // 
            // buttonOpDevided
            // 
            this.buttonOpDevided.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpDevided.Location = new System.Drawing.Point(185, 318);
            this.buttonOpDevided.Name = "buttonOpDevided";
            this.buttonOpDevided.Size = new System.Drawing.Size(50, 50);
            this.buttonOpDevided.TabIndex = 16;
            this.buttonOpDevided.Text = "/";
            this.buttonOpDevided.UseVisualStyleBackColor = true;
            this.buttonOpDevided.Click += new System.EventHandler(this.OpClick);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(241, 374);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(50, 50);
            this.buttonC.TabIndex = 17;
            this.buttonC.Text = "CE";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.CClick);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(185, 374);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(50, 50);
            this.buttonCE.TabIndex = 18;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.CEClick);
            // 
            // historyBox
            // 
            this.historyBox.BackColor = System.Drawing.Color.LightGray;
            this.historyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyBox.ForeColor = System.Drawing.Color.DimGray;
            this.historyBox.Location = new System.Drawing.Point(12, 18);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(417, 53);
            this.historyBox.TabIndex = 19;
            this.historyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonMemoryOne
            // 
            this.buttonMemoryOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemoryOne.Location = new System.Drawing.Point(241, 150);
            this.buttonMemoryOne.Name = "buttonMemoryOne";
            this.buttonMemoryOne.Size = new System.Drawing.Size(50, 50);
            this.buttonMemoryOne.TabIndex = 20;
            this.buttonMemoryOne.Text = "M1";
            this.buttonMemoryOne.UseVisualStyleBackColor = true;
            this.buttonMemoryOne.Click += new System.EventHandler(this.MemoryOneClick);
            // 
            // buttonMemoryTwo
            // 
            this.buttonMemoryTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemoryTwo.Location = new System.Drawing.Point(241, 206);
            this.buttonMemoryTwo.Name = "buttonMemoryTwo";
            this.buttonMemoryTwo.Size = new System.Drawing.Size(50, 50);
            this.buttonMemoryTwo.TabIndex = 21;
            this.buttonMemoryTwo.Text = "M2";
            this.buttonMemoryTwo.UseVisualStyleBackColor = true;
            this.buttonMemoryTwo.Click += new System.EventHandler(this.MemoryTwoClick);
            // 
            // buttonMemoryThree
            // 
            this.buttonMemoryThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemoryThree.Location = new System.Drawing.Point(241, 262);
            this.buttonMemoryThree.Name = "buttonMemoryThree";
            this.buttonMemoryThree.Size = new System.Drawing.Size(50, 50);
            this.buttonMemoryThree.TabIndex = 22;
            this.buttonMemoryThree.Text = "M3";
            this.buttonMemoryThree.UseVisualStyleBackColor = true;
            this.buttonMemoryThree.Click += new System.EventHandler(this.MemoryThreeClick);
            // 
            // buttonMemoryClear
            // 
            this.buttonMemoryClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemoryClear.Location = new System.Drawing.Point(241, 318);
            this.buttonMemoryClear.Name = "buttonMemoryClear";
            this.buttonMemoryClear.Size = new System.Drawing.Size(50, 50);
            this.buttonMemoryClear.TabIndex = 23;
            this.buttonMemoryClear.Text = "MC";
            this.buttonMemoryClear.UseVisualStyleBackColor = true;
            this.buttonMemoryClear.Click += new System.EventHandler(this.MemoryClearClick);
            // 
            // buttonOpPercent
            // 
            this.buttonOpPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpPercent.Location = new System.Drawing.Point(129, 318);
            this.buttonOpPercent.Name = "buttonOpPercent";
            this.buttonOpPercent.Size = new System.Drawing.Size(50, 50);
            this.buttonOpPercent.TabIndex = 24;
            this.buttonOpPercent.Text = "%";
            this.buttonOpPercent.UseVisualStyleBackColor = true;
            this.buttonOpPercent.Click += new System.EventHandler(this.OpClick);
            // 
            // checkBoxEuro
            // 
            this.checkBoxEuro.AutoSize = true;
            this.checkBoxEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEuro.Location = new System.Drawing.Point(297, 161);
            this.checkBoxEuro.Name = "checkBoxEuro";
            this.checkBoxEuro.Size = new System.Drawing.Size(40, 28);
            this.checkBoxEuro.TabIndex = 25;
            this.checkBoxEuro.Text = "€";
            this.checkBoxEuro.UseVisualStyleBackColor = true;
            this.checkBoxEuro.CheckedChanged += new System.EventHandler(this.CheckBox1_Euro);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.checkBoxEuro);
            this.Controls.Add(this.buttonOpPercent);
            this.Controls.Add(this.buttonMemoryClear);
            this.Controls.Add(this.buttonMemoryThree);
            this.Controls.Add(this.buttonMemoryTwo);
            this.Controls.Add(this.buttonMemoryOne);
            this.Controls.Add(this.historyBox);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonOpDevided);
            this.Controls.Add(this.buttonOpTimes);
            this.Controls.Add(this.buttonOpMinus);
            this.Controls.Add(this.buttonNumPoint);
            this.Controls.Add(this.buttonNumZero);
            this.Controls.Add(this.buttonNumNine);
            this.Controls.Add(this.buttonNum8);
            this.Controls.Add(this.buttonNum7);
            this.Controls.Add(this.buttonNumSix);
            this.Controls.Add(this.buttonNumFive);
            this.Controls.Add(this.buttonNumFour);
            this.Controls.Add(this.buttonNumThree);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.buttonOpPlus);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.buttonNumTwo);
            this.Controls.Add(this.buttonNumOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNumOne;
        private System.Windows.Forms.Button buttonNumTwo;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button buttonOpPlus;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Button buttonNumThree;
        private System.Windows.Forms.Button buttonNumSix;
        private System.Windows.Forms.Button buttonNumFive;
        private System.Windows.Forms.Button buttonNumFour;
        private System.Windows.Forms.Button buttonNumNine;
        private System.Windows.Forms.Button buttonNum8;
        private System.Windows.Forms.Button buttonNum7;
        private System.Windows.Forms.Button buttonNumZero;
        private System.Windows.Forms.Button buttonNumPoint;
        private System.Windows.Forms.Button buttonOpMinus;
        private System.Windows.Forms.Button buttonOpTimes;
        private System.Windows.Forms.Button buttonOpDevided;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.TextBox historyBox;
        private System.Windows.Forms.Button buttonMemoryOne;
        private System.Windows.Forms.Button buttonMemoryTwo;
        private System.Windows.Forms.Button buttonMemoryThree;
        private System.Windows.Forms.Button buttonMemoryClear;
        private System.Windows.Forms.Button buttonOpPercent;
        private System.Windows.Forms.CheckBox checkBoxEuro;
    }
}

