namespace myCalculator
{
    partial class Mortgage
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
            this.avecappi = new System.Windows.Forms.RadioButton();
            this.avecap = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_recalculate = new System.Windows.Forms.Button();
            this.YeartextBox = new System.Windows.Forms.TextBox();
            this.LoantextBox = new System.Windows.Forms.TextBox();
            this.RatetextBox = new System.Windows.Forms.TextBox();
            this.MonthtextBox = new System.Windows.Forms.TextBox();
            this.InteresttextBox = new System.Windows.Forms.TextBox();
            this.AlltextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // avecappi
            // 
            this.avecappi.AutoSize = true;
            this.avecappi.Location = new System.Drawing.Point(146, 33);
            this.avecappi.Name = "avecappi";
            this.avecappi.Size = new System.Drawing.Size(88, 19);
            this.avecappi.TabIndex = 0;
            this.avecappi.Text = "等额本息";
            this.avecappi.UseVisualStyleBackColor = true;
            // 
            // avecap
            // 
            this.avecap.AutoSize = true;
            this.avecap.Location = new System.Drawing.Point(240, 33);
            this.avecap.Name = "avecap";
            this.avecap.Size = new System.Drawing.Size(88, 19);
            this.avecap.TabIndex = 1;
            this.avecap.Text = "等额本金";
            this.avecap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "还款方式:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "还款总额(元):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "利息总额(元):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "月均还款(元):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "贷款利率(%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "贷款金额(万元):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "贷款年限(年):";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(53, 166);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(94, 35);
            this.btn_calculate.TabIndex = 9;
            this.btn_calculate.Text = "计算";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_recalculate
            // 
            this.btn_recalculate.Location = new System.Drawing.Point(197, 166);
            this.btn_recalculate.Name = "btn_recalculate";
            this.btn_recalculate.Size = new System.Drawing.Size(94, 35);
            this.btn_recalculate.TabIndex = 10;
            this.btn_recalculate.Text = "重新计算";
            this.btn_recalculate.UseVisualStyleBackColor = true;
            this.btn_recalculate.Click += new System.EventHandler(this.btn_recalculate_Click);
            // 
            // YeartextBox
            // 
            this.YeartextBox.Location = new System.Drawing.Point(146, 63);
            this.YeartextBox.Name = "YeartextBox";
            this.YeartextBox.Size = new System.Drawing.Size(182, 25);
            this.YeartextBox.TabIndex = 11;
            // 
            // LoantextBox
            // 
            this.LoantextBox.Location = new System.Drawing.Point(146, 94);
            this.LoantextBox.Name = "LoantextBox";
            this.LoantextBox.Size = new System.Drawing.Size(182, 25);
            this.LoantextBox.TabIndex = 12;
            // 
            // RatetextBox
            // 
            this.RatetextBox.Location = new System.Drawing.Point(146, 125);
            this.RatetextBox.Name = "RatetextBox";
            this.RatetextBox.Size = new System.Drawing.Size(182, 25);
            this.RatetextBox.TabIndex = 13;
            // 
            // MonthtextBox
            // 
            this.MonthtextBox.Location = new System.Drawing.Point(146, 218);
            this.MonthtextBox.Name = "MonthtextBox";
            this.MonthtextBox.ReadOnly = true;
            this.MonthtextBox.Size = new System.Drawing.Size(182, 25);
            this.MonthtextBox.TabIndex = 14;
            // 
            // InteresttextBox
            // 
            this.InteresttextBox.Location = new System.Drawing.Point(146, 249);
            this.InteresttextBox.Name = "InteresttextBox";
            this.InteresttextBox.ReadOnly = true;
            this.InteresttextBox.Size = new System.Drawing.Size(182, 25);
            this.InteresttextBox.TabIndex = 15;
            // 
            // AlltextBox
            // 
            this.AlltextBox.Location = new System.Drawing.Point(146, 280);
            this.AlltextBox.Name = "AlltextBox";
            this.AlltextBox.ReadOnly = true;
            this.AlltextBox.Size = new System.Drawing.Size(182, 25);
            this.AlltextBox.TabIndex = 16;
            // 
            // Mortgage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 331);
            this.Controls.Add(this.AlltextBox);
            this.Controls.Add(this.InteresttextBox);
            this.Controls.Add(this.MonthtextBox);
            this.Controls.Add(this.RatetextBox);
            this.Controls.Add(this.LoantextBox);
            this.Controls.Add(this.YeartextBox);
            this.Controls.Add(this.btn_recalculate);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avecap);
            this.Controls.Add(this.avecappi);
            this.Name = "Mortgage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myMortgage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton avecappi;
        private System.Windows.Forms.RadioButton avecap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_recalculate;
        private System.Windows.Forms.TextBox YeartextBox;
        private System.Windows.Forms.TextBox LoantextBox;
        private System.Windows.Forms.TextBox RatetextBox;
        private System.Windows.Forms.TextBox MonthtextBox;
        private System.Windows.Forms.TextBox InteresttextBox;
        private System.Windows.Forms.TextBox AlltextBox;
    }
}