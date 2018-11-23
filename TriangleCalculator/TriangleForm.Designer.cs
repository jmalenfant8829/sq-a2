namespace TriangleCalculator
{
    partial class TriangleForm
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
            this.calcRightTriBtn = new System.Windows.Forms.Button();
            this.side2Box = new System.Windows.Forms.TextBox();
            this.side1Box = new System.Windows.Forms.TextBox();
            this.hypBox = new System.Windows.Forms.TextBox();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.angle1Box = new System.Windows.Forms.TextBox();
            this.angle2Box = new System.Windows.Forms.TextBox();
            this.angleResultbox = new System.Windows.Forms.TextBox();
            this.calcAngleBtn = new System.Windows.Forms.Button();
            this.rightTriCalcLbl = new System.Windows.Forms.Label();
            this.calcAngleLbl = new System.Windows.Forms.Label();
            this.errRightTriLbl = new System.Windows.Forms.Label();
            this.errAngleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcRightTriBtn
            // 
            this.calcRightTriBtn.Location = new System.Drawing.Point(381, 119);
            this.calcRightTriBtn.Name = "calcRightTriBtn";
            this.calcRightTriBtn.Size = new System.Drawing.Size(75, 23);
            this.calcRightTriBtn.TabIndex = 0;
            this.calcRightTriBtn.Text = "Submit";
            this.calcRightTriBtn.UseVisualStyleBackColor = true;
            this.calcRightTriBtn.Click += new System.EventHandler(this.calcRightTriBtn_Click);
            // 
            // side2Box
            // 
            this.side2Box.Location = new System.Drawing.Point(225, 119);
            this.side2Box.Name = "side2Box";
            this.side2Box.Size = new System.Drawing.Size(100, 20);
            this.side2Box.TabIndex = 1;
            // 
            // side1Box
            // 
            this.side1Box.Location = new System.Drawing.Point(89, 119);
            this.side1Box.Name = "side1Box";
            this.side1Box.Size = new System.Drawing.Size(100, 20);
            this.side1Box.TabIndex = 3;
            // 
            // hypBox
            // 
            this.hypBox.Location = new System.Drawing.Point(502, 119);
            this.hypBox.Name = "hypBox";
            this.hypBox.ReadOnly = true;
            this.hypBox.Size = new System.Drawing.Size(100, 20);
            this.hypBox.TabIndex = 4;
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(502, 167);
            this.areaBox.Name = "areaBox";
            this.areaBox.ReadOnly = true;
            this.areaBox.Size = new System.Drawing.Size(100, 20);
            this.areaBox.TabIndex = 5;
            // 
            // angle1Box
            // 
            this.angle1Box.Location = new System.Drawing.Point(89, 323);
            this.angle1Box.Name = "angle1Box";
            this.angle1Box.Size = new System.Drawing.Size(100, 20);
            this.angle1Box.TabIndex = 6;
            // 
            // angle2Box
            // 
            this.angle2Box.Location = new System.Drawing.Point(225, 323);
            this.angle2Box.Name = "angle2Box";
            this.angle2Box.Size = new System.Drawing.Size(100, 20);
            this.angle2Box.TabIndex = 7;
            // 
            // angleResultbox
            // 
            this.angleResultbox.Location = new System.Drawing.Point(501, 322);
            this.angleResultbox.Name = "angleResultbox";
            this.angleResultbox.ReadOnly = true;
            this.angleResultbox.Size = new System.Drawing.Size(100, 20);
            this.angleResultbox.TabIndex = 8;
            // 
            // calcAngleBtn
            // 
            this.calcAngleBtn.Location = new System.Drawing.Point(381, 323);
            this.calcAngleBtn.Name = "calcAngleBtn";
            this.calcAngleBtn.Size = new System.Drawing.Size(75, 23);
            this.calcAngleBtn.TabIndex = 9;
            this.calcAngleBtn.Text = "Submit";
            this.calcAngleBtn.UseVisualStyleBackColor = true;
            this.calcAngleBtn.Click += new System.EventHandler(this.calcAngleBtn_Click);
            // 
            // rightTriCalcLbl
            // 
            this.rightTriCalcLbl.AutoSize = true;
            this.rightTriCalcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightTriCalcLbl.Location = new System.Drawing.Point(45, 39);
            this.rightTriCalcLbl.Name = "rightTriCalcLbl";
            this.rightTriCalcLbl.Size = new System.Drawing.Size(732, 31);
            this.rightTriCalcLbl.TabIndex = 10;
            this.rightTriCalcLbl.Text = "Enter numbers to calculate area/hypotenuse of right triangle";
            // 
            // calcAngleLbl
            // 
            this.calcAngleLbl.AutoSize = true;
            this.calcAngleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcAngleLbl.Location = new System.Drawing.Point(133, 250);
            this.calcAngleLbl.Name = "calcAngleLbl";
            this.calcAngleLbl.Size = new System.Drawing.Size(469, 31);
            this.calcAngleLbl.TabIndex = 11;
            this.calcAngleLbl.Text = "Enter numbers to calculate third angle";
            this.calcAngleLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // errRightTriLbl
            // 
            this.errRightTriLbl.AutoSize = true;
            this.errRightTriLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errRightTriLbl.ForeColor = System.Drawing.Color.Red;
            this.errRightTriLbl.Location = new System.Drawing.Point(86, 184);
            this.errRightTriLbl.Name = "errRightTriLbl";
            this.errRightTriLbl.Size = new System.Drawing.Size(0, 18);
            this.errRightTriLbl.TabIndex = 12;
            this.errRightTriLbl.Click += new System.EventHandler(this.errRightTriLbl_Click);
            // 
            // errAngleLbl
            // 
            this.errAngleLbl.AutoSize = true;
            this.errAngleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errAngleLbl.ForeColor = System.Drawing.Color.Red;
            this.errAngleLbl.Location = new System.Drawing.Point(86, 403);
            this.errAngleLbl.Name = "errAngleLbl";
            this.errAngleLbl.Size = new System.Drawing.Size(0, 18);
            this.errAngleLbl.TabIndex = 13;
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errAngleLbl);
            this.Controls.Add(this.errRightTriLbl);
            this.Controls.Add(this.calcAngleLbl);
            this.Controls.Add(this.rightTriCalcLbl);
            this.Controls.Add(this.calcAngleBtn);
            this.Controls.Add(this.angleResultbox);
            this.Controls.Add(this.angle2Box);
            this.Controls.Add(this.angle1Box);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.hypBox);
            this.Controls.Add(this.side1Box);
            this.Controls.Add(this.side2Box);
            this.Controls.Add(this.calcRightTriBtn);
            this.Name = "TriangleForm";
            this.Text = "Triangle Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcRightTriBtn;
        private System.Windows.Forms.TextBox side2Box;
        private System.Windows.Forms.TextBox side1Box;
        private System.Windows.Forms.TextBox hypBox;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.TextBox angle1Box;
        private System.Windows.Forms.TextBox angle2Box;
        private System.Windows.Forms.TextBox angleResultbox;
        private System.Windows.Forms.Button calcAngleBtn;
        private System.Windows.Forms.Label rightTriCalcLbl;
        private System.Windows.Forms.Label calcAngleLbl;
        private System.Windows.Forms.Label errRightTriLbl;
        private System.Windows.Forms.Label errAngleLbl;
    }
}

