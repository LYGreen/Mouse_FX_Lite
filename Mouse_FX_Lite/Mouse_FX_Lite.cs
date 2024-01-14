using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_FX_Winform
{
    public partial class MainForm : Form
    {
        ParticlesWindow MainParticlesWindow;
        NotifyIcon MainNotifyIcon;
        public MainForm()
        {
            InitializeComponent();
            InitNotifyIcon();

            MainParticlesWindow = new ParticlesWindow();
            MainParticlesWindow.Show();
        }

        /* 按下了 X 关闭时 */
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void trackBar_Opacity_Scroll(object sender, EventArgs e)
        {
            Opacity = trackBar_Opacity.Value / 100.0;
        }

        private void trackBar_ParticleWindowOpacity_Scroll(object sender, EventArgs e)
        {
            MainParticlesWindow.Opacity = trackBar_ParticleWindowOpacity.Value / 100.0;
        }

        private void button_ThreadWaitTimeOK_Click(object sender, EventArgs e)
        {
            MainParticlesWindow.ThreadWaitTime = Convert.ToInt32(textBox_ThreadWaitTime.Text);
        }

        private void button_UpdateParticleWindow_Click(object sender, EventArgs e)
        {
            /* 粒子发射器 */

            int maxCount = Convert.ToInt32(textBox_MaxCount.Text);

            RangeF velocityX = new RangeF(
                Convert.ToSingle(textBox_VelocityXMin.Text), 
                Convert.ToSingle(textBox_VelocityXMax.Text)
                );

            RangeF velocityY = new RangeF(
                Convert.ToSingle(textBox_VelocityYMin.Text),
                Convert.ToSingle (textBox_VelocityYMax.Text)
                );

            Color color = Color.FromArgb(
                255,/* 由于不使用 A ，因此随机输入一个值 */
                Convert.ToInt32(textBox_R.Text),
                Convert.ToInt32(textBox_G.Text),
                Convert.ToInt32(textBox_B.Text)
                );

            RangeF size = new RangeF(
                Convert.ToSingle(textBox_SizeMin.Text), 
                Convert.ToSingle(textBox_SizeMax.Text)
                );

            RangeF life = new RangeF(
                Convert.ToSingle(textBox_LifeMin.Text), 
                Convert.ToSingle(textBox_LifeMax.Text)
                );

            Range alpha = new Range(
                Convert.ToInt32(textBox_AlphaMin.Text), 
                Convert.ToInt32(textBox_AlphaMax.Text)
                );

            bool randomColor = checkBox_RandomColor.Checked;

            MainParticlesWindow.SetParticleSpawnerValues(color, maxCount, velocityX, velocityY, size, life, alpha, randomColor);

        }

        /* 自定义函数 */
        #region 托盘图标

        private void InitNotifyIcon()
        {
            MainNotifyIcon = new NotifyIcon();
            MainNotifyIcon.Text = "Mouse_FX_Lite";
            MainNotifyIcon.Icon = new Icon("Mouse_FX.ico");/* 当点击图标时 */
            MainNotifyIcon.MouseClick += MainNotifyIcon_MouseClick;
            MainNotifyIcon.Visible = true;

            ContextMenuStrip cms = new ContextMenuStrip();/* 创建一个菜单 */
            ToolStripMenuItem tsmi_OpenMainWindow = new ToolStripMenuItem();/* 创建一个菜单项用于打开主窗口 */
            tsmi_OpenMainWindow.Text = "打开";
            tsmi_OpenMainWindow.Click += Tsmi_OpenMainWindow_Click;/* 当点击菜单项时 */
            cms.Items.Add(tsmi_OpenMainWindow);/* 将该菜单项添加到菜单里 */
            ToolStripMenuItem tsmi_Exit = new ToolStripMenuItem();/* 创建一个菜单项用于退出 */
            tsmi_Exit.Text = "退出";
            tsmi_Exit.Click += Tsmi_Exit_Click;/* 当点击菜单项时 */
            cms.Items.Add(tsmi_Exit);/* 将该菜单项添加到菜单里 */
            MainNotifyIcon.ContextMenuStrip = cms;/* MainNotifyIcon 实例使用该菜单 */
        }

        /* 当点击图标时 */
        private void MainNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Show();
            }
        }

        /* 当点击 "打开" 菜单项时 */
        private void Tsmi_OpenMainWindow_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        /* 当点击 "退出" 菜单项时 */
        private void Tsmi_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        #endregion


    }
}
