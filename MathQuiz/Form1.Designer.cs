namespace MathQuiz
{

    partial class Form1 : Form
    {
        Random randomizer = new Random();

        int addend1;
        int addend2;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        int timeLeft;

        private System.ComponentModel.IContainer components = null;

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);


            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();


            sum.Value = 0;


            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;


            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;


            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

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
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            plusRightLabel = new Label();
            sum = new NumericUpDown();
            difference = new NumericUpDown();
            product = new NumericUpDown();
            quotient = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            minusRightLabel = new Label();
            timesRightLabel = new Label();
            dividedRightLabel = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            minusLeftLabel = new Label();
            timesLeftLabel = new Label();
            dividedLeftLabel = new Label();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(288, -2);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            timeLabel.Click += timeLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(183, -2);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 1;
            label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusLeftLabel.Location = new Point(50, 37);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(248, 37);
            label2.Name = "label2";
            label2.Size = new Size(60, 50);
            label2.TabIndex = 3;
            label2.Text = "=";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(116, 37);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 4;
            label3.Text = "+";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusRightLabel.Location = new Point(183, 48);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 5;
            plusRightLabel.Text = "plusRightLabel";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sum.Location = new Point(314, 48);
            sum.Name = "sum";
            sum.Size = new Size(100, 39);
            sum.TabIndex = 1;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            difference.Location = new Point(314, 116);
            difference.Name = "difference";
            difference.Size = new Size(100, 39);
            difference.TabIndex = 2;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            product.Location = new Point(314, 180);
            product.Name = "product";
            product.Size = new Size(100, 39);
            product.TabIndex = 3;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quotient.Location = new Point(314, 248);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 39);
            quotient.TabIndex = 4;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(248, 109);
            label5.Name = "label5";
            label5.Size = new Size(60, 50);
            label5.TabIndex = 10;
            label5.Text = "=";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(248, 173);
            label6.Name = "label6";
            label6.Size = new Size(60, 50);
            label6.TabIndex = 11;
            label6.Text = "=";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(248, 241);
            label7.Name = "label7";
            label7.Size = new Size(60, 50);
            label7.TabIndex = 12;
            label7.Text = "=";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusRightLabel.Location = new Point(183, 116);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 13;
            minusRightLabel.Text = "plusRightLabel";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesRightLabel.Location = new Point(183, 173);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 14;
            timesRightLabel.Text = "plusRightLabel";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedRightLabel.Location = new Point(182, 248);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 15;
            dividedRightLabel.Text = "plusRightLabel";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(116, 109);
            label11.Name = "label11";
            label11.Size = new Size(60, 50);
            label11.TabIndex = 16;
            label11.Text = "-";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(116, 173);
            label12.Name = "label12";
            label12.Size = new Size(60, 50);
            label12.TabIndex = 17;
            label12.Text = "*";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(116, 241);
            label13.Name = "label13";
            label13.Size = new Size(60, 50);
            label13.TabIndex = 18;
            label13.Text = "/";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusLeftLabel.Location = new Point(50, 109);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 19;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesLeftLabel.Location = new Point(50, 169);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 20;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedLeftLabel.Location = new Point(50, 237);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 21;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(182, 315);
            startButton.Name = "startButton";
            startButton.Size = new Size(133, 35);
            startButton.TabIndex = 0;
            startButton.Text = "Start the quiz";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(startButton);
            Controls.Add(dividedLeftLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(minusLeftLabel);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(dividedRightLabel);
            Controls.Add(timesRightLabel);
            Controls.Add(minusRightLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(quotient);
            Controls.Add(product);
            Controls.Add(difference);
            Controls.Add(sum);
            Controls.Add(plusRightLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Math Quiz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label label2;
        private Label label3;
        private Label plusRightLabel;
        private NumericUpDown sum;
        private NumericUpDown difference;
        private NumericUpDown product;
        private NumericUpDown quotient;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label minusRightLabel;
        private Label timesRightLabel;
        private Label dividedRightLabel;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label minusLeftLabel;
        private Label timesLeftLabel;
        private Label dividedLeftLabel;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}