namespace StopSleep
{
    partial class NoSleepForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoSleepForm));
            this.Start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.cycle_label = new System.Windows.Forms.Label();
            this.cycle_tb = new System.Windows.Forms.TextBox();
            this.s_label = new System.Windows.Forms.Label();
            this.nosleep_timer = new System.Windows.Forms.Timer(this.components);
            this.Status_ImageList = new System.Windows.Forms.ImageList(this.components);
            this.status_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.status_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(146, 52);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(75, 23);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.Text = "开始";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(146, 81);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(75, 23);
            this.stop_btn.TabIndex = 0;
            this.stop_btn.Text = "结束";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // cycle_label
            // 
            this.cycle_label.AutoSize = true;
            this.cycle_label.Location = new System.Drawing.Point(26, 25);
            this.cycle_label.Name = "cycle_label";
            this.cycle_label.Size = new System.Drawing.Size(101, 12);
            this.cycle_label.TabIndex = 1;
            this.cycle_label.Text = "定时周期（2~60）";
            this.cycle_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // cycle_tb
            // 
            this.cycle_tb.Location = new System.Drawing.Point(146, 22);
            this.cycle_tb.Name = "cycle_tb";
            this.cycle_tb.Size = new System.Drawing.Size(48, 21);
            this.cycle_tb.TabIndex = 2;
            this.cycle_tb.Text = "30";
            this.cycle_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // s_label
            // 
            this.s_label.AutoSize = true;
            this.s_label.Location = new System.Drawing.Point(204, 25);
            this.s_label.Name = "s_label";
            this.s_label.Size = new System.Drawing.Size(17, 12);
            this.s_label.TabIndex = 3;
            this.s_label.Text = "秒";
            this.s_label.Click += new System.EventHandler(this.s_label_Click);
            // 
            // nosleep_timer
            // 
            this.nosleep_timer.Tick += new System.EventHandler(this.nosleep_timer_Tick);
            // 
            // Status_ImageList
            // 
            this.Status_ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Status_ImageList.ImageStream")));
            this.Status_ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.Status_ImageList.Images.SetKeyName(0, "Start.gif");
            this.Status_ImageList.Images.SetKeyName(1, "Stop.gif");
            // 
            // status_pb
            // 
            this.status_pb.Location = new System.Drawing.Point(49, 52);
            this.status_pb.Name = "status_pb";
            this.status_pb.Size = new System.Drawing.Size(50, 50);
            this.status_pb.TabIndex = 4;
            this.status_pb.TabStop = false;
            // 
            // NoSleepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 119);
            this.Controls.Add(this.status_pb);
            this.Controls.Add(this.s_label);
            this.Controls.Add(this.cycle_tb);
            this.Controls.Add(this.cycle_label);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.Start_btn);
            this.Name = "NoSleepForm";
            this.Text = "禁止休眠助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.status_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Label cycle_label;
        private System.Windows.Forms.TextBox cycle_tb;
        private System.Windows.Forms.Label s_label;
        private System.Windows.Forms.Timer nosleep_timer;
        private System.Windows.Forms.ImageList Status_ImageList;
        private System.Windows.Forms.PictureBox status_pb;
    }
}

