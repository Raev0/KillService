namespace KillService
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.清除按钮 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.触发模式 = new System.Windows.Forms.CheckBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.service11 = new KillService.Service1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.清除按钮);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.触发模式);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 502);
            this.panel1.TabIndex = 0;
            // 
            // 清除按钮
            // 
            this.清除按钮.Location = new System.Drawing.Point(389, 33);
            this.清除按钮.Name = "清除按钮";
            this.清除按钮.Size = new System.Drawing.Size(75, 23);
            this.清除按钮.TabIndex = 5;
            this.清除按钮.Text = "清除";
            this.清除按钮.UseVisualStyleBackColor = true;
            this.清除按钮.Visible = false;
            this.清除按钮.Click += new System.EventHandler(this.清除按钮_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 4;
            // 
            // 触发模式
            // 
            this.触发模式.AutoSize = true;
            this.触发模式.Location = new System.Drawing.Point(286, 33);
            this.触发模式.Name = "触发模式";
            this.触发模式.Size = new System.Drawing.Size(72, 16);
            this.触发模式.TabIndex = 3;
            this.触发模式.Text = "触发模式";
            this.触发模式.UseVisualStyleBackColor = true;
            this.触发模式.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(440, 73);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(384, 388);
            this.listBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(39, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(387, 388);
            this.listBox1.TabIndex = 0;
            // 
            // service11
            // 
            this.service11.ExitCode = 0;
            this.service11.ServiceName = "Service1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 502);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private Service1 service11;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox 触发模式;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 清除按钮;
        internal System.Windows.Forms.Button button1;
    }
}

