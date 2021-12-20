using CSCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTAudioFX
{
    internal class DelaySource : SampleAggregatorBase
    {
        public int LeftDelay { get; set; } = 0;
        public int RightDelay { get; set; } = 0;

        private float[] ringBuf = new float[88200 ];
        private int ringBufOffset = 0;

        public DelaySource(ISampleSource source) : base(source)
        {
        }

        public override int Read(float[] buffer, int offset, int count)
        {
            var ringBufCount = Math.Min(count, ringBuf.Length - ringBufOffset);
            int num = base.Read(ringBuf, ringBufOffset, ringBufCount);
            if (num % 2 != 0)
            {
                throw new InvalidOperationException("Read samples has to be a multiple of two.");
            }


            for (int n = 0; n < num / 2; n++)
            {
                buffer[offset + 2 * n] = SampleAt(n, 0, LeftDelay);
                buffer[offset + 2 * n + 1] = SampleAt(n, 1, RightDelay);
            }

            ringBufOffset += num;
            if (ringBufOffset >= buffer.Length)
                ringBufOffset = 0;
            return num;
        }

        private float SampleAt(int idx, int chan, int delay)
        {
            var samplePos = ringBufOffset + 2 * (idx - delay);

            if (samplePos < 0)
            {
                samplePos = ringBuf.Length + samplePos;
            }
            

            return ringBuf[samplePos + chan];
        }

    }
}
