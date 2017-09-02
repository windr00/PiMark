namespace PiMark
{
    partial class frmMain
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
            this.numThread = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numTimes = new System.Windows.Forms.NumericUpDown();
            this.barAll = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFinished = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numThread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // numThread
            // 
            this.numThread.Location = new System.Drawing.Point(102, 12);
            this.numThread.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numThread.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThread.Name = "numThread";
            this.numThread.Size = new System.Drawing.Size(120, 23);
            this.numThread.TabIndex = 0;
            this.numThread.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "线程数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "计算次数";
            // 
            // numTimes
            // 
            this.numTimes.Location = new System.Drawing.Point(424, 12);
            this.numTimes.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numTimes.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTimes.Name = "numTimes";
            this.numTimes.Size = new System.Drawing.Size(120, 23);
            this.numTimes.TabIndex = 2;
            this.numTimes.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // barAll
            // 
            this.barAll.Location = new System.Drawing.Point(12, 87);
            this.barAll.Name = "barAll";
            this.barAll.Size = new System.Drawing.Size(588, 23);
            this.barAll.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "得分";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(459, 58);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 17);
            this.lbTime.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(525, 116);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "已完成次数";
            // 
            // lbFinished
            // 
            this.lbFinished.AutoSize = true;
            this.lbFinished.Location = new System.Drawing.Point(87, 58);
            this.lbFinished.Name = "lbFinished";
            this.lbFinished.Size = new System.Drawing.Size(0, 17);
            this.lbFinished.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "参考基准： Intel Core i5 2310 @ 3.10 GHz 单核心得分 1000";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 150);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbFinished);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numTimes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numThread);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "跑π";
            ((System.ComponentModel.ISupportInitialize)(this.numThread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numThread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTimes;
        private System.Windows.Forms.ProgressBar barAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbFinished;
        private System.Windows.Forms.Label label5;
    }
}

