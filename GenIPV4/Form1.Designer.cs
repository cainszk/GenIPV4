namespace GenIPV4
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn4genip = new System.Windows.Forms.Button();
            this.txt4ip1 = new System.Windows.Forms.TextBox();
            this.txt4ip2 = new System.Windows.Forms.TextBox();
            this.txt4ip3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt4ip4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt4ip8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt4ip7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt4ip6 = new System.Windows.Forms.TextBox();
            this.txt4ip5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = ".";
            // 
            // btn4genip
            // 
            this.btn4genip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4genip.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4genip.ForeColor = System.Drawing.Color.Green;
            this.btn4genip.Location = new System.Drawing.Point(16, 223);
            this.btn4genip.Name = "btn4genip";
            this.btn4genip.Size = new System.Drawing.Size(358, 56);
            this.btn4genip.TabIndex = 0;
            this.btn4genip.Text = "生成IP列表";
            this.btn4genip.UseVisualStyleBackColor = true;
            this.btn4genip.Click += new System.EventHandler(this.btn4genip_Click);
            // 
            // txt4ip1
            // 
            this.txt4ip1.Location = new System.Drawing.Point(92, 104);
            this.txt4ip1.Name = "txt4ip1";
            this.txt4ip1.Size = new System.Drawing.Size(51, 29);
            this.txt4ip1.TabIndex = 2;
            this.txt4ip1.Text = "192";
            this.txt4ip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4ip1.TextChanged += new System.EventHandler(this.txt4ip1_TextChanged);
            this.txt4ip1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4ip1_KeyPress);
            // 
            // txt4ip2
            // 
            this.txt4ip2.Location = new System.Drawing.Point(169, 104);
            this.txt4ip2.Name = "txt4ip2";
            this.txt4ip2.Size = new System.Drawing.Size(51, 29);
            this.txt4ip2.TabIndex = 3;
            this.txt4ip2.Text = "168";
            this.txt4ip2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4ip2.TextChanged += new System.EventHandler(this.txt4ip2_TextChanged);
            this.txt4ip2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4ip2_KeyPress);
            // 
            // txt4ip3
            // 
            this.txt4ip3.Location = new System.Drawing.Point(246, 104);
            this.txt4ip3.Name = "txt4ip3";
            this.txt4ip3.Size = new System.Drawing.Size(51, 29);
            this.txt4ip3.TabIndex = 5;
            this.txt4ip3.Text = "1";
            this.txt4ip3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4ip3.TextChanged += new System.EventHandler(this.txt4ip3_TextChanged);
            this.txt4ip3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4ip3_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = ".";
            // 
            // txt4ip4
            // 
            this.txt4ip4.Location = new System.Drawing.Point(323, 104);
            this.txt4ip4.Name = "txt4ip4";
            this.txt4ip4.Size = new System.Drawing.Size(51, 29);
            this.txt4ip4.TabIndex = 7;
            this.txt4ip4.Text = "0";
            this.txt4ip4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4ip4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4ip4_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "起始点：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "终结点：";
            // 
            // txt4ip8
            // 
            this.txt4ip8.Location = new System.Drawing.Point(323, 139);
            this.txt4ip8.Name = "txt4ip8";
            this.txt4ip8.Size = new System.Drawing.Size(51, 29);
            this.txt4ip8.TabIndex = 15;
            this.txt4ip8.Text = "255";
            this.txt4ip8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4ip8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4ip8_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = ".";
            // 
            // txt4ip7
            // 
            this.txt4ip7.Location = new System.Drawing.Point(246, 139);
            this.txt4ip7.Name = "txt4ip7";
            this.txt4ip7.Size = new System.Drawing.Size(51, 29);
            this.txt4ip7.TabIndex = 13;
            this.txt4ip7.Text = "1";
            this.txt4ip7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4ip7.TextChanged += new System.EventHandler(this.txt4ip7_TextChanged);
            this.txt4ip7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4ip7_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = ".";
            // 
            // txt4ip6
            // 
            this.txt4ip6.Location = new System.Drawing.Point(169, 139);
            this.txt4ip6.Name = "txt4ip6";
            this.txt4ip6.Size = new System.Drawing.Size(51, 29);
            this.txt4ip6.TabIndex = 11;
            this.txt4ip6.Text = "168";
            this.txt4ip6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4ip6.TextChanged += new System.EventHandler(this.txt4ip6_TextChanged);
            this.txt4ip6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4ip6_KeyPress);
            // 
            // txt4ip5
            // 
            this.txt4ip5.Location = new System.Drawing.Point(92, 139);
            this.txt4ip5.Name = "txt4ip5";
            this.txt4ip5.Size = new System.Drawing.Size(51, 29);
            this.txt4ip5.TabIndex = 10;
            this.txt4ip5.Text = "192";
            this.txt4ip5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4ip5.TextChanged += new System.EventHandler(this.txt4ip5_TextChanged);
            this.txt4ip5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4ip5_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = ".";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(16, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(358, 79);
            this.label9.TabIndex = 17;
            this.label9.Text = "GenIPV4";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(16, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(358, 30);
            this.label10.TabIndex = 18;
            this.label10.Text = "仅支持动态生成IP地址的第4段";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 292);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt4ip8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt4ip7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt4ip6);
            this.Controls.Add(this.txt4ip5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt4ip4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt4ip3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt4ip2);
            this.Controls.Add(this.txt4ip1);
            this.Controls.Add(this.btn4genip);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPV4地址生成器 - GenIPV4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn4genip;
        private System.Windows.Forms.TextBox txt4ip1;
        private System.Windows.Forms.TextBox txt4ip2;
        private System.Windows.Forms.TextBox txt4ip3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt4ip4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt4ip8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt4ip7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt4ip6;
        private System.Windows.Forms.TextBox txt4ip5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

