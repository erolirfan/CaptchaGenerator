using System;

namespace UniqueProvider.Common
{
    public class RandomProvider
    {
        private Random m_RNG1;
        private double m_StoredUniformDeviate;
        private bool m_StoredUniformDeviateIsGood = false;

        #region -- Construction/Initialization --

        public RandomProvider()
        {
            Reset();
        }
        public void Reset()
        {
            m_RNG1 = new Random(Environment.TickCount);
        }
        public void Reset(int seed)
        {
            m_RNG1 = new Random(seed);
        }
        #endregion

        #region -- Uniform Deviates --

        /// <summary>
        /// Returns double in the range [0, 1)
        /// </summary>
        public int Next()
        {
            return m_RNG1.Next();
        }

        /// <summary>
        /// Returns true or false randomly.
        /// </summary>
        public bool NextBoolean()
        {
            if (m_RNG1.Next(0, 2) == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Returns double in the range [0, 1)
        /// </summary>
        public double NextDouble()
        {
            double rn = m_RNG1.NextDouble();
            return rn;
        }

        /// <summary>
        /// Returns Int16 in the range [min, max)
        /// </summary>
        public Int16 Next(Int16 min, Int16 max)
        {
            if (max <= min)
            {
                string message = "Max must be greater than min.";
                throw new ArgumentException(message);
            }
            double rn = (max * 1.0 - min * 1.0) * m_RNG1.NextDouble() + min * 1.0;
            return Convert.ToInt16(rn);
        }

        /// <summary>
        /// Returns Int32 in the range [min, max)
        /// </summary>
        public int Next(int min, int max)
        {
            return m_RNG1.Next(min, max);
        }

        /// <summary>
        /// Returns Int64 in the range [min, max)
        /// </summary>
        public Int64 Next(Int64 min, Int64 max)
        {
            if (max <= min)
            {
                string message = "Max must be greater than min.";
                throw new ArgumentException(message);
            }

            double rn = (max * 1.0 - min * 1.0) * m_RNG1.NextDouble() + min * 1.0;
            return Convert.ToInt64(rn);
        }

        /// <summary>
        /// Returns float (Single) in the range [min, max)
        /// </summary>
        public Single Next(Single min, Single max)
        {
            if (max <= min)
            {
                string message = "Max must be greater than min.";
                throw new ArgumentException(message);
            }

            double rn = (max * 1.0 - min * 1.0) * m_RNG1.NextDouble() + min * 1.0;
            return Convert.ToSingle(rn);
        }

        /// <summary>
        /// Returns double in the range [min, max)
        /// </summary>
        public double Next(double min, double max)
        {
            if (max <= min)
            {
                string message = "Max must be greater than min.";
                throw new ArgumentException(message);
            }

            double rn = (max - min) * m_RNG1.NextDouble() + min;
            return rn;
        }

        /// <summary>
        /// Returns DateTime in the range [min, max)
        /// </summary>
        public DateTime Next(DateTime min, DateTime max)
        {
            if (max <= min)
            {
                string message = "Max must be greater than min.";
                throw new ArgumentException(message);
            }
            long minTicks = min.Ticks;
            long maxTicks = max.Ticks;
            double rn = (Convert.ToDouble(maxTicks)
               - Convert.ToDouble(minTicks)) * m_RNG1.NextDouble()
               + Convert.ToDouble(minTicks);
            return new DateTime(Convert.ToInt64(rn));
        }

        /// <summary>
        /// Returns TimeSpan in the range [min, max)
        /// </summary>
        public TimeSpan Next(TimeSpan min, TimeSpan max)
        {
            if (max <= min)
            {
                string message = "Max must be greater than min.";
                throw new ArgumentException(message);
            }

            long minTicks = min.Ticks;
            long maxTicks = max.Ticks;
            double rn = (Convert.ToDouble(maxTicks)
               - Convert.ToDouble(minTicks)) * m_RNG1.NextDouble()
               + Convert.ToDouble(minTicks);
            return new TimeSpan(Convert.ToInt64(rn));
        }

        /// <summary>
        /// Returns double in the range [min, max)
        /// </summary>
        public double NextUniform()
        {
            return m_RNG1.NextDouble();
        }

        /// <summary>
        /// Returns a uniformly random integer representing one of the values 
        /// in the enum.
        /// </summary>
        public int NextEnum(Type enumType)
        {
            int[] values = (int[])Enum.GetValues(enumType);
            int randomIndex = Next(0, values.Length);
            return values[randomIndex];
        }

        #endregion
    }
}
