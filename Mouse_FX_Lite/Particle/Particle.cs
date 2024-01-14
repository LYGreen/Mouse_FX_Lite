using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Mouse_FX_Winform
{
    public struct Range
    {
        public Range(int min, int max) {  Min = min; Max = max; }
        public int Min;
        public int Max;
    }
    public struct RangeF
    {
        public RangeF(float min, float max) {  Min = min; Max = max; }
        public float Min;
        public float Max;
    }
    partial class ParticleSpawner
    {
        public PointF Position;
        public RangeF VelocityXRange;
        public RangeF VelocityYRange;
        public RangeF SizeRange;
        public RangeF LifeRange;
        public Range AlphaRange;
        public int MaxCount;
        public Color ParticlesColor;/* 只使用 R,G,B ，不使用 A  */
        public bool RandomColor;
        public Random RandomNum = new Random(); /* 不放在函数里面的原因： */
        /* 1 -- RandomNum 放在循环体里面：
         *      for(int i = 0; i < 10; i++)
         *      {
         *          Random r = new Random();
         *          Console.WriteLine(r.Next(1,100));
         *      }
         *      由于时间间隔过短，生成的随机种子相同，因此得到的随机数也相同
         * 
         * 2 -- RandomNum 放在循环体外面：
         *      Random r = new Random();
         *      for(int i = 0; i < 10; i++)
         *      {
         *          Console.WriteLine(r.Next(1.100));
         *      }
         *      RandomNum 只初始化了一次(只生成了一次随机种子)，RandomNum.Next() 得到的数不同
         *      
         */

        //public Particle[] Particles;/* Particles 变量由 List<T> 变成了 Array(数组),此处 Array(数组) 效率和 List<T> 差不多 */
        public List<Particle> Particles = new List<Particle>();/* 用于储存粒子 */
        public ParticleSpawner(
            Color particlesColor, 
            int maxCount, 
            RangeF velocityXRange, 
            RangeF velocityYRange, 
            RangeF sizeRange, 
            RangeF lifeRange, 
            Range alphaRange,
            bool randomColor = true
            )
        {
            ParticlesColor = particlesColor;
            MaxCount = maxCount;
            VelocityXRange = velocityXRange;
            VelocityYRange = velocityYRange;
            SizeRange = sizeRange;
            LifeRange = lifeRange;
            AlphaRange = alphaRange;
            RandomColor = randomColor;

            /* Array 版本 */
            //Particles = new Particle[MaxCount];
            ///* 补充粒子 */
            //for(int i = 0; i < MaxCount; i++)
            //{
            //    Thread.Sleep(1);
            //    Particles[i] = SpawnParticle();
            //}
            

        }
        public void UpdateParticles(float delta)
        {
            /* Array 版本 */
            ///* 当某粒子的 Life <= 0 时，重新生成一个粒子 */
            //for (int i = 0; i < Particles.Length; i++)
            //{
            //    if (Particles[i].Life <= 0)
            //    {
            //        Particles[i] = SpawnParticle();
            //    }
            //}

            /* Array 版本 */
            ///* 移动粒子 */
            //for (int i = 0; i < Particles.Length; i++)
            //{
            //    Particles[i].Rect.X += Particles[i].Velocity.X * Convert.ToSingle(delta);
            //    Particles[i].Rect.Y += Particles[i].Velocity.Y * Convert.ToSingle(delta);
            //    Particles[i].Life -= Convert.ToSingle(delta);
            //}

            /* List<T> 版本 */
            /* 补充粒子 */
            while (Particles.Count < MaxCount)
            {
                Particle p = SpawnParticle();
                Particles.Add(p);
            }
            /* List<T> 版本 */
            /* 删除 Life <= 0 的粒子 */
            for (int i = 0; i < Particles.Count; i++)
            {
                if (Particles[i].Life <= 0)
                {
                    Particles.RemoveAt(i);
                    i--;
                }
            }
            /* List<T> 版本 */
            /* 移动粒子 */
            foreach (Particle p in Particles)
            {
                p.Rect.X += p.Velocity.X * Convert.ToSingle(delta);
                p.Rect.Y += p.Velocity.Y * Convert.ToSingle(delta);
                p.Life -= delta;
            }

        }

        /* 自定义函数，用于生成粒子 */
        private Particle SpawnParticle()
        {
            RectangleF rect = new RectangleF(
                Position.X,
                Position.Y,
                Convert.ToSingle(RandomNum.NextDouble() * (SizeRange.Max - SizeRange.Min) + SizeRange.Min),
                Convert.ToSingle(RandomNum.NextDouble() * (SizeRange.Max - SizeRange.Min) + SizeRange.Min)
                );

            PointF velocity = new PointF(
                Convert.ToSingle(RandomNum.NextDouble() * (VelocityXRange.Max - VelocityXRange.Min) + VelocityXRange.Min),
                Convert.ToSingle(RandomNum.NextDouble() * (VelocityYRange.Max - VelocityYRange.Min) + VelocityYRange.Min)
                );

            float life = Convert.ToSingle(RandomNum.NextDouble() * (LifeRange.Max - LifeRange.Min) + LifeRange.Min);

            Color color = new Color();
            byte alpha = Convert.ToByte(RandomNum.Next(AlphaRange.Min, AlphaRange.Max));
            if(RandomColor)
            {
                byte red = Convert.ToByte(RandomNum.Next(0, 255));
                byte green = Convert.ToByte(RandomNum.Next(0, 255));
                byte blue = Convert.ToByte(RandomNum.Next(0, 255));
                color = Color.FromArgb(alpha, red, green, blue);
            }
            else
            {
                color = Color.FromArgb(alpha, ParticlesColor.R, ParticlesColor.G, ParticlesColor.B);
            }

            Particle p = new Particle(rect, velocity, life, color);
            return p;
        }
    }
    partial class Particle
    {
        public RectangleF Rect;
        public PointF Velocity;
        public float Life;
        public Color ParticleColor;/* 使用 R,G,B,A  */
        public Particle(RectangleF rect, PointF velocity, float life, Color particleColor)
        {
            Rect = rect;
            Velocity = velocity;
            Life = life;
            ParticleColor = particleColor;
        }
    }
}
