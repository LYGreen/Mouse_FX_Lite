namespace Mouse_FX_Winform
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label_CurrentWindowOpacity = new System.Windows.Forms.Label();
            this.trackBar_Opacity = new System.Windows.Forms.TrackBar();
            this.label_ParticleWindow = new System.Windows.Forms.Label();
            this.label_VelocityRange = new System.Windows.Forms.Label();
            this.label_VelocityX = new System.Windows.Forms.Label();
            this.label_VelocityY = new System.Windows.Forms.Label();
            this.textBox_VelocityXMin = new System.Windows.Forms.TextBox();
            this.textBox_VelocityYMin = new System.Windows.Forms.TextBox();
            this.label_Range1 = new System.Windows.Forms.Label();
            this.label_Range2 = new System.Windows.Forms.Label();
            this.textBox_VelocityXMax = new System.Windows.Forms.TextBox();
            this.textBox_VelocityYMax = new System.Windows.Forms.TextBox();
            this.label_SizeRange = new System.Windows.Forms.Label();
            this.textBox_SizeMax = new System.Windows.Forms.TextBox();
            this.label_Range3 = new System.Windows.Forms.Label();
            this.textBox_SizeMin = new System.Windows.Forms.TextBox();
            this.label_Life = new System.Windows.Forms.Label();
            this.textBox_LifeMax = new System.Windows.Forms.TextBox();
            this.label_Range5 = new System.Windows.Forms.Label();
            this.textBox_LifeMin = new System.Windows.Forms.TextBox();
            this.label_Opacity = new System.Windows.Forms.Label();
            this.textBox_AlphaMax = new System.Windows.Forms.TextBox();
            this.label_Range6 = new System.Windows.Forms.Label();
            this.textBox_AlphaMin = new System.Windows.Forms.TextBox();
            this.button_UpdateParticleWindow = new System.Windows.Forms.Button();
            this.label_Color = new System.Windows.Forms.Label();
            this.label_R = new System.Windows.Forms.Label();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.label_G = new System.Windows.Forms.Label();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.label_B = new System.Windows.Forms.Label();
            this.label_MaxCount = new System.Windows.Forms.Label();
            this.textBox_MaxCount = new System.Windows.Forms.TextBox();
            this.checkBox_RandomColor = new System.Windows.Forms.CheckBox();
            this.label_ParticleWindowOpacity = new System.Windows.Forms.Label();
            this.textBox_G = new System.Windows.Forms.TextBox();
            this.trackBar_ParticleWindowOpacity = new System.Windows.Forms.TrackBar();
            this.label_ThreadWaitTime = new System.Windows.Forms.Label();
            this.textBox_ThreadWaitTime = new System.Windows.Forms.TextBox();
            this.label_ms = new System.Windows.Forms.Label();
            this.button_ThreadWaitTimeOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Opacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ParticleWindowOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CurrentWindowOpacity
            // 
            this.label_CurrentWindowOpacity.AutoSize = true;
            this.label_CurrentWindowOpacity.Location = new System.Drawing.Point(12, 9);
            this.label_CurrentWindowOpacity.Name = "label_CurrentWindowOpacity";
            this.label_CurrentWindowOpacity.Size = new System.Drawing.Size(127, 15);
            this.label_CurrentWindowOpacity.TabIndex = 0;
            this.label_CurrentWindowOpacity.Text = "当前窗口透明度：";
            // 
            // trackBar_Opacity
            // 
            this.trackBar_Opacity.AutoSize = false;
            this.trackBar_Opacity.Location = new System.Drawing.Point(14, 27);
            this.trackBar_Opacity.Maximum = 100;
            this.trackBar_Opacity.Name = "trackBar_Opacity";
            this.trackBar_Opacity.Size = new System.Drawing.Size(182, 28);
            this.trackBar_Opacity.TabIndex = 1;
            this.trackBar_Opacity.Value = 100;
            this.trackBar_Opacity.Scroll += new System.EventHandler(this.trackBar_Opacity_Scroll);
            // 
            // label_ParticleWindow
            // 
            this.label_ParticleWindow.AutoSize = true;
            this.label_ParticleWindow.Location = new System.Drawing.Point(12, 81);
            this.label_ParticleWindow.Name = "label_ParticleWindow";
            this.label_ParticleWindow.Size = new System.Drawing.Size(82, 15);
            this.label_ParticleWindow.TabIndex = 2;
            this.label_ParticleWindow.Text = "粒子窗口：";
            // 
            // label_VelocityRange
            // 
            this.label_VelocityRange.AutoSize = true;
            this.label_VelocityRange.Location = new System.Drawing.Point(12, 133);
            this.label_VelocityRange.Name = "label_VelocityRange";
            this.label_VelocityRange.Size = new System.Drawing.Size(52, 15);
            this.label_VelocityRange.TabIndex = 3;
            this.label_VelocityRange.Text = "速度：";
            // 
            // label_VelocityX
            // 
            this.label_VelocityX.AutoSize = true;
            this.label_VelocityX.Location = new System.Drawing.Point(71, 133);
            this.label_VelocityX.Name = "label_VelocityX";
            this.label_VelocityX.Size = new System.Drawing.Size(23, 15);
            this.label_VelocityX.TabIndex = 4;
            this.label_VelocityX.Text = "X:";
            // 
            // label_VelocityY
            // 
            this.label_VelocityY.AutoSize = true;
            this.label_VelocityY.Location = new System.Drawing.Point(71, 164);
            this.label_VelocityY.Name = "label_VelocityY";
            this.label_VelocityY.Size = new System.Drawing.Size(23, 15);
            this.label_VelocityY.TabIndex = 5;
            this.label_VelocityY.Text = "Y:";
            // 
            // textBox_VelocityXMin
            // 
            this.textBox_VelocityXMin.Location = new System.Drawing.Point(100, 130);
            this.textBox_VelocityXMin.Name = "textBox_VelocityXMin";
            this.textBox_VelocityXMin.Size = new System.Drawing.Size(100, 25);
            this.textBox_VelocityXMin.TabIndex = 6;
            this.textBox_VelocityXMin.Text = "-16";
            // 
            // textBox_VelocityYMin
            // 
            this.textBox_VelocityYMin.Location = new System.Drawing.Point(100, 161);
            this.textBox_VelocityYMin.Name = "textBox_VelocityYMin";
            this.textBox_VelocityYMin.Size = new System.Drawing.Size(100, 25);
            this.textBox_VelocityYMin.TabIndex = 7;
            this.textBox_VelocityYMin.Text = "-16";
            // 
            // label_Range1
            // 
            this.label_Range1.AutoSize = true;
            this.label_Range1.Location = new System.Drawing.Point(206, 133);
            this.label_Range1.Name = "label_Range1";
            this.label_Range1.Size = new System.Drawing.Size(15, 15);
            this.label_Range1.TabIndex = 8;
            this.label_Range1.Text = "~";
            // 
            // label_Range2
            // 
            this.label_Range2.AutoSize = true;
            this.label_Range2.Location = new System.Drawing.Point(206, 164);
            this.label_Range2.Name = "label_Range2";
            this.label_Range2.Size = new System.Drawing.Size(15, 15);
            this.label_Range2.TabIndex = 9;
            this.label_Range2.Text = "~";
            // 
            // textBox_VelocityXMax
            // 
            this.textBox_VelocityXMax.Location = new System.Drawing.Point(227, 130);
            this.textBox_VelocityXMax.Name = "textBox_VelocityXMax";
            this.textBox_VelocityXMax.Size = new System.Drawing.Size(100, 25);
            this.textBox_VelocityXMax.TabIndex = 10;
            this.textBox_VelocityXMax.Text = "16";
            // 
            // textBox_VelocityYMax
            // 
            this.textBox_VelocityYMax.Location = new System.Drawing.Point(227, 161);
            this.textBox_VelocityYMax.Name = "textBox_VelocityYMax";
            this.textBox_VelocityYMax.Size = new System.Drawing.Size(100, 25);
            this.textBox_VelocityYMax.TabIndex = 11;
            this.textBox_VelocityYMax.Text = "16";
            // 
            // label_SizeRange
            // 
            this.label_SizeRange.AutoSize = true;
            this.label_SizeRange.Location = new System.Drawing.Point(11, 226);
            this.label_SizeRange.Name = "label_SizeRange";
            this.label_SizeRange.Size = new System.Drawing.Size(52, 15);
            this.label_SizeRange.TabIndex = 12;
            this.label_SizeRange.Text = "大小：";
            // 
            // textBox_SizeMax
            // 
            this.textBox_SizeMax.Location = new System.Drawing.Point(196, 223);
            this.textBox_SizeMax.Name = "textBox_SizeMax";
            this.textBox_SizeMax.Size = new System.Drawing.Size(100, 25);
            this.textBox_SizeMax.TabIndex = 21;
            this.textBox_SizeMax.Text = "3";
            // 
            // label_Range3
            // 
            this.label_Range3.AutoSize = true;
            this.label_Range3.Location = new System.Drawing.Point(175, 226);
            this.label_Range3.Name = "label_Range3";
            this.label_Range3.Size = new System.Drawing.Size(15, 15);
            this.label_Range3.TabIndex = 19;
            this.label_Range3.Text = "~";
            // 
            // textBox_SizeMin
            // 
            this.textBox_SizeMin.Location = new System.Drawing.Point(69, 223);
            this.textBox_SizeMin.Name = "textBox_SizeMin";
            this.textBox_SizeMin.Size = new System.Drawing.Size(100, 25);
            this.textBox_SizeMin.TabIndex = 17;
            this.textBox_SizeMin.Text = "3";
            // 
            // label_Life
            // 
            this.label_Life.AutoSize = true;
            this.label_Life.Location = new System.Drawing.Point(12, 257);
            this.label_Life.Name = "label_Life";
            this.label_Life.Size = new System.Drawing.Size(106, 15);
            this.label_Life.TabIndex = 23;
            this.label_Life.Text = "持续时间(s)：";
            // 
            // textBox_LifeMax
            // 
            this.textBox_LifeMax.Location = new System.Drawing.Point(198, 254);
            this.textBox_LifeMax.Name = "textBox_LifeMax";
            this.textBox_LifeMax.Size = new System.Drawing.Size(50, 25);
            this.textBox_LifeMax.TabIndex = 26;
            this.textBox_LifeMax.Text = "0.5";
            // 
            // label_Range5
            // 
            this.label_Range5.AutoSize = true;
            this.label_Range5.Location = new System.Drawing.Point(177, 257);
            this.label_Range5.Name = "label_Range5";
            this.label_Range5.Size = new System.Drawing.Size(15, 15);
            this.label_Range5.TabIndex = 25;
            this.label_Range5.Text = "~";
            // 
            // textBox_LifeMin
            // 
            this.textBox_LifeMin.Location = new System.Drawing.Point(121, 254);
            this.textBox_LifeMin.Name = "textBox_LifeMin";
            this.textBox_LifeMin.Size = new System.Drawing.Size(50, 25);
            this.textBox_LifeMin.TabIndex = 24;
            this.textBox_LifeMin.Text = "0";
            // 
            // label_Opacity
            // 
            this.label_Opacity.AutoSize = true;
            this.label_Opacity.Location = new System.Drawing.Point(12, 288);
            this.label_Opacity.Name = "label_Opacity";
            this.label_Opacity.Size = new System.Drawing.Size(123, 15);
            this.label_Opacity.TabIndex = 27;
            this.label_Opacity.Text = "透明度(0~255)：";
            // 
            // textBox_AlphaMax
            // 
            this.textBox_AlphaMax.Location = new System.Drawing.Point(218, 285);
            this.textBox_AlphaMax.Name = "textBox_AlphaMax";
            this.textBox_AlphaMax.Size = new System.Drawing.Size(50, 25);
            this.textBox_AlphaMax.TabIndex = 30;
            this.textBox_AlphaMax.Text = "255";
            // 
            // label_Range6
            // 
            this.label_Range6.AutoSize = true;
            this.label_Range6.Location = new System.Drawing.Point(197, 288);
            this.label_Range6.Name = "label_Range6";
            this.label_Range6.Size = new System.Drawing.Size(15, 15);
            this.label_Range6.TabIndex = 29;
            this.label_Range6.Text = "~";
            // 
            // textBox_AlphaMin
            // 
            this.textBox_AlphaMin.Location = new System.Drawing.Point(141, 285);
            this.textBox_AlphaMin.Name = "textBox_AlphaMin";
            this.textBox_AlphaMin.Size = new System.Drawing.Size(50, 25);
            this.textBox_AlphaMin.TabIndex = 28;
            this.textBox_AlphaMin.Text = "255";
            // 
            // button_UpdateParticleWindow
            // 
            this.button_UpdateParticleWindow.Location = new System.Drawing.Point(15, 371);
            this.button_UpdateParticleWindow.Name = "button_UpdateParticleWindow";
            this.button_UpdateParticleWindow.Size = new System.Drawing.Size(114, 32);
            this.button_UpdateParticleWindow.TabIndex = 31;
            this.button_UpdateParticleWindow.Text = "更新粒子窗口";
            this.button_UpdateParticleWindow.UseVisualStyleBackColor = true;
            this.button_UpdateParticleWindow.Click += new System.EventHandler(this.button_UpdateParticleWindow_Click);
            // 
            // label_Color
            // 
            this.label_Color.AutoSize = true;
            this.label_Color.Location = new System.Drawing.Point(12, 195);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(108, 15);
            this.label_Color.TabIndex = 32;
            this.label_Color.Text = "颜色(0~255)：";
            // 
            // label_R
            // 
            this.label_R.AutoSize = true;
            this.label_R.Location = new System.Drawing.Point(126, 195);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(23, 15);
            this.label_R.TabIndex = 33;
            this.label_R.Text = "R:";
            // 
            // textBox_R
            // 
            this.textBox_R.Location = new System.Drawing.Point(156, 192);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(50, 25);
            this.textBox_R.TabIndex = 36;
            this.textBox_R.Text = "0";
            // 
            // label_G
            // 
            this.label_G.AutoSize = true;
            this.label_G.Location = new System.Drawing.Point(212, 195);
            this.label_G.Name = "label_G";
            this.label_G.Size = new System.Drawing.Size(23, 15);
            this.label_G.TabIndex = 37;
            this.label_G.Text = "G:";
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(328, 192);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(50, 25);
            this.textBox_B.TabIndex = 40;
            this.textBox_B.Text = "0";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(298, 195);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(23, 15);
            this.label_B.TabIndex = 39;
            this.label_B.Text = "B:";
            // 
            // label_MaxCount
            // 
            this.label_MaxCount.AutoSize = true;
            this.label_MaxCount.Location = new System.Drawing.Point(12, 102);
            this.label_MaxCount.Name = "label_MaxCount";
            this.label_MaxCount.Size = new System.Drawing.Size(82, 15);
            this.label_MaxCount.TabIndex = 41;
            this.label_MaxCount.Text = "最大数量：";
            // 
            // textBox_MaxCount
            // 
            this.textBox_MaxCount.Location = new System.Drawing.Point(100, 99);
            this.textBox_MaxCount.Name = "textBox_MaxCount";
            this.textBox_MaxCount.Size = new System.Drawing.Size(100, 25);
            this.textBox_MaxCount.TabIndex = 43;
            this.textBox_MaxCount.Text = "320";
            // 
            // checkBox_RandomColor
            // 
            this.checkBox_RandomColor.AutoSize = true;
            this.checkBox_RandomColor.Checked = true;
            this.checkBox_RandomColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RandomColor.Location = new System.Drawing.Point(384, 195);
            this.checkBox_RandomColor.Name = "checkBox_RandomColor";
            this.checkBox_RandomColor.Size = new System.Drawing.Size(89, 19);
            this.checkBox_RandomColor.TabIndex = 44;
            this.checkBox_RandomColor.Text = "随机颜色";
            this.checkBox_RandomColor.UseVisualStyleBackColor = true;
            // 
            // label_ParticleWindowOpacity
            // 
            this.label_ParticleWindowOpacity.AutoSize = true;
            this.label_ParticleWindowOpacity.Location = new System.Drawing.Point(12, 313);
            this.label_ParticleWindowOpacity.Name = "label_ParticleWindowOpacity";
            this.label_ParticleWindowOpacity.Size = new System.Drawing.Size(127, 15);
            this.label_ParticleWindowOpacity.TabIndex = 45;
            this.label_ParticleWindowOpacity.Text = "粒子窗口透明度：";
            // 
            // textBox_G
            // 
            this.textBox_G.Location = new System.Drawing.Point(242, 192);
            this.textBox_G.Name = "textBox_G";
            this.textBox_G.Size = new System.Drawing.Size(50, 25);
            this.textBox_G.TabIndex = 38;
            this.textBox_G.Text = "255";
            // 
            // trackBar_ParticleWindowOpacity
            // 
            this.trackBar_ParticleWindowOpacity.AutoSize = false;
            this.trackBar_ParticleWindowOpacity.Location = new System.Drawing.Point(12, 331);
            this.trackBar_ParticleWindowOpacity.Maximum = 100;
            this.trackBar_ParticleWindowOpacity.Name = "trackBar_ParticleWindowOpacity";
            this.trackBar_ParticleWindowOpacity.Size = new System.Drawing.Size(461, 34);
            this.trackBar_ParticleWindowOpacity.TabIndex = 46;
            this.trackBar_ParticleWindowOpacity.Value = 100;
            this.trackBar_ParticleWindowOpacity.Scroll += new System.EventHandler(this.trackBar_ParticleWindowOpacity_Scroll);
            // 
            // label_ThreadWaitTime
            // 
            this.label_ThreadWaitTime.Location = new System.Drawing.Point(195, 9);
            this.label_ThreadWaitTime.Name = "label_ThreadWaitTime";
            this.label_ThreadWaitTime.Size = new System.Drawing.Size(168, 63);
            this.label_ThreadWaitTime.TabIndex = 47;
            this.label_ThreadWaitTime.Text = "线程等待时间(可自行调整，调整 CPU 或 GPU 的占用，默认是 20 )：";
            // 
            // textBox_ThreadWaitTime
            // 
            this.textBox_ThreadWaitTime.Location = new System.Drawing.Point(369, 9);
            this.textBox_ThreadWaitTime.Name = "textBox_ThreadWaitTime";
            this.textBox_ThreadWaitTime.Size = new System.Drawing.Size(75, 25);
            this.textBox_ThreadWaitTime.TabIndex = 48;
            this.textBox_ThreadWaitTime.Text = "20";
            // 
            // label_ms
            // 
            this.label_ms.AutoSize = true;
            this.label_ms.Location = new System.Drawing.Point(450, 12);
            this.label_ms.Name = "label_ms";
            this.label_ms.Size = new System.Drawing.Size(23, 15);
            this.label_ms.TabIndex = 49;
            this.label_ms.Text = "ms";
            // 
            // button_ThreadWaitTimeOK
            // 
            this.button_ThreadWaitTimeOK.Location = new System.Drawing.Point(369, 40);
            this.button_ThreadWaitTimeOK.Name = "button_ThreadWaitTimeOK";
            this.button_ThreadWaitTimeOK.Size = new System.Drawing.Size(104, 32);
            this.button_ThreadWaitTimeOK.TabIndex = 50;
            this.button_ThreadWaitTimeOK.Text = "确定";
            this.button_ThreadWaitTimeOK.UseVisualStyleBackColor = true;
            this.button_ThreadWaitTimeOK.Click += new System.EventHandler(this.button_ThreadWaitTimeOK_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(486, 415);
            this.Controls.Add(this.button_ThreadWaitTimeOK);
            this.Controls.Add(this.label_ms);
            this.Controls.Add(this.textBox_ThreadWaitTime);
            this.Controls.Add(this.label_ThreadWaitTime);
            this.Controls.Add(this.trackBar_ParticleWindowOpacity);
            this.Controls.Add(this.label_ParticleWindowOpacity);
            this.Controls.Add(this.checkBox_RandomColor);
            this.Controls.Add(this.textBox_MaxCount);
            this.Controls.Add(this.label_MaxCount);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.textBox_G);
            this.Controls.Add(this.label_G);
            this.Controls.Add(this.textBox_R);
            this.Controls.Add(this.label_R);
            this.Controls.Add(this.label_Color);
            this.Controls.Add(this.button_UpdateParticleWindow);
            this.Controls.Add(this.textBox_AlphaMax);
            this.Controls.Add(this.label_Range6);
            this.Controls.Add(this.textBox_AlphaMin);
            this.Controls.Add(this.label_Opacity);
            this.Controls.Add(this.textBox_LifeMax);
            this.Controls.Add(this.label_Range5);
            this.Controls.Add(this.textBox_LifeMin);
            this.Controls.Add(this.label_Life);
            this.Controls.Add(this.textBox_SizeMax);
            this.Controls.Add(this.label_Range3);
            this.Controls.Add(this.textBox_SizeMin);
            this.Controls.Add(this.label_SizeRange);
            this.Controls.Add(this.textBox_VelocityYMax);
            this.Controls.Add(this.textBox_VelocityXMax);
            this.Controls.Add(this.label_Range2);
            this.Controls.Add(this.label_Range1);
            this.Controls.Add(this.textBox_VelocityYMin);
            this.Controls.Add(this.textBox_VelocityXMin);
            this.Controls.Add(this.label_VelocityY);
            this.Controls.Add(this.label_VelocityX);
            this.Controls.Add(this.label_VelocityRange);
            this.Controls.Add(this.label_ParticleWindow);
            this.Controls.Add(this.trackBar_Opacity);
            this.Controls.Add(this.label_CurrentWindowOpacity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mouse_FX_Lite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Opacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ParticleWindowOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CurrentWindowOpacity;
        private System.Windows.Forms.TrackBar trackBar_Opacity;
        private System.Windows.Forms.Label label_ParticleWindow;
        private System.Windows.Forms.Label label_VelocityRange;
        private System.Windows.Forms.Label label_VelocityX;
        private System.Windows.Forms.Label label_VelocityY;
        private System.Windows.Forms.TextBox textBox_VelocityXMin;
        private System.Windows.Forms.TextBox textBox_VelocityYMin;
        private System.Windows.Forms.Label label_Range1;
        private System.Windows.Forms.Label label_Range2;
        private System.Windows.Forms.TextBox textBox_VelocityXMax;
        private System.Windows.Forms.TextBox textBox_VelocityYMax;
        private System.Windows.Forms.Label label_SizeRange;
        private System.Windows.Forms.TextBox textBox_SizeMax;
        private System.Windows.Forms.Label label_Range3;
        private System.Windows.Forms.TextBox textBox_SizeMin;
        private System.Windows.Forms.Label label_Life;
        private System.Windows.Forms.TextBox textBox_LifeMax;
        private System.Windows.Forms.Label label_Range5;
        private System.Windows.Forms.TextBox textBox_LifeMin;
        private System.Windows.Forms.Label label_Opacity;
        private System.Windows.Forms.TextBox textBox_AlphaMax;
        private System.Windows.Forms.Label label_Range6;
        private System.Windows.Forms.TextBox textBox_AlphaMin;
        private System.Windows.Forms.Button button_UpdateParticleWindow;
        private System.Windows.Forms.Label label_Color;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.Label label_G;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_MaxCount;
        private System.Windows.Forms.TextBox textBox_MaxCount;
        private System.Windows.Forms.CheckBox checkBox_RandomColor;
        private System.Windows.Forms.Label label_ParticleWindowOpacity;
        private System.Windows.Forms.TextBox textBox_G;
        private System.Windows.Forms.TrackBar trackBar_ParticleWindowOpacity;
        private System.Windows.Forms.Label label_ThreadWaitTime;
        private System.Windows.Forms.TextBox textBox_ThreadWaitTime;
        private System.Windows.Forms.Label label_ms;
        private System.Windows.Forms.Button button_ThreadWaitTimeOK;
    }
}

