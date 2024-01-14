using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_FX_Winform
{
    public partial class ParticlesWindow : Form
    {
        Graphics MainGraphics;/* 用于双重缓冲 */
        Graphics BufferGraphics;/* 用于双重缓冲 */
        ParticleSpawner Particler;/* 粒子生成器 */
        const float FPS = 1.0f / 60;/* 每秒 60 帧 */
        bool IsPlaying = false;/* 用于表示是否播放动画(线程是否执行) */
        public int ThreadWaitTime = 20;/* 线程等待时间(可自行调整，调整 CPU 或 GPU 的占用，默认是 20 ) */
        public ParticlesWindow()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ShowInTaskbar = false;/* 在任务栏中不显示该窗口 */

            /* 鼠标穿透 */
            Opacity = 50;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            TransparencyKey = Color.Transparent;
            Winapi.SetWindowLongW(Handle, Winapi.GWL_EXSTYLE, Winapi.WS_EX_TRANSPARENT | Winapi.WS_EX_LAYERED);
            BackColor = Color.FromArgb(255, Color.Transparent);
            TopMost = true;

            this.Show();

            /* 窗口全屏 */
            Location = new Point(0, 0);
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;

            /* 初始化粒子生成器 --- 以下都是默认值 */
            Particler = new ParticleSpawner(
                Color.FromArgb(255, 0, 255, 0), 
                128, 
                new RangeF(-16, 16), 
                new RangeF(-16, 16), 
                new RangeF(3, 3), 
                new RangeF(0, 0.5f), 
                new Range(255, 255)
                );

            MainGraphics = this.CreateGraphics();

            /* Timer 版本 */
            //timer.Start();

            IsPlaying = true;
            Thread t = new Thread(new ThreadStart(ThreadLoop));
            t.Start();
        }

        private void ThreadLoop()
        {
            while (IsPlaying)
            {
                Thread.Sleep(ThreadWaitTime);/* 线程等待时间(可自行调整，调整 CPU 或 GPU 的占用) */

                Winapi.POINT p = new Winapi.POINT();
                Winapi.GetCursorPos(ref p);

                Particler.Position.X = p.x;
                Particler.Position.Y = p.y;
                Particler.UpdateParticles(FPS);

                Bitmap bitmap = new Bitmap(Width, Height);
                BufferGraphics = Graphics.FromImage(bitmap);
                BufferGraphics.Clear(Color.White);
                for (int i = 0; i < Particler.Particles.Count; i++)
                {
                    Brush brush = new SolidBrush(Particler.Particles[i].ParticleColor);
                    //BufferGraphics.FillRectangle(brush, Particler.Particles[i].Rect);/* 画长方形 */

                    BufferGraphics.FillEllipse(brush, Particler.Particles[i].Rect);/* 画椭圆 */
                    brush.Dispose();/* 如果不释放内存，会导致内存占用过多 */
                }
                MainGraphics.DrawImage(bitmap, 0, 0);
                bitmap.Dispose();/* 如果不释放内存，会导致内存占用过多 */
                BufferGraphics.Dispose();/* 如果不释放内存，会导致内存占用过多 */
            }
        }

        /* Timer 版本 */
        private void timer_Tick(object sender, EventArgs e)
        {
            //Winapi.POINT p = new Winapi.POINT();
            //Winapi.GetCursorPos(ref p);

            //Particler.Position.X = p.x;
            //Particler.Position.Y = p.y;
            //Particler.UpdateParticles(FPS);

            //Bitmap bitmap = new Bitmap(Width, Height);
            //BufferGraphics = Graphics.FromImage(bitmap);
            //BufferGraphics.Clear(Color.White);
            //for (int i = 0; i < Particler.Particles.Count; i++)
            //{
            //    Brush brush = new SolidBrush(Particler.Particles[i].ParticleColor);
            //    //BufferGraphics.FillRectangle(brush, Particler.Particles[i].Rect);/* 画长方形 */

            //    BufferGraphics.FillEllipse(brush, Particler.Particles[i].Rect);/* 画椭圆 */
            //    brush.Dispose();/* 如果不释放内存，会导致内存占用过多 */
            //}
            //MainGraphics.DrawImage(bitmap, 0, 0);
            //bitmap.Dispose();/* 如果不释放内存，会导致内存占用过多 */
            //BufferGraphics.Dispose();/* 如果不释放内存，会导致内存占用过多 */
        }

        /* 自定义函数 */
        public void SetParticleSpawnerValues(
            Color color,
            int maxCount,
            RangeF velocityXRange, 
            RangeF velocityYRange, 
            RangeF sizeRange, 
            RangeF lifeRange,
            Range alphaRange,
            bool randomColor = false
            )
        {
            Particler.ParticlesColor = color;
            Particler.MaxCount = maxCount;
            Particler.VelocityXRange = velocityXRange;
            Particler.VelocityYRange = velocityYRange;
            Particler.SizeRange = sizeRange;
            Particler.LifeRange = lifeRange;
            Particler.AlphaRange = alphaRange;
            Particler.RandomColor = randomColor;
        }
    }
}
