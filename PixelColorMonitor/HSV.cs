using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelColorMonitor
{
    static class CHSV
    {
        static int CalcLargerIdx(float[] vec, int cur, int next)
        {
            return (vec[cur] >= vec[next]) ? cur : next;
        }

        static int CalcSmallerIdx(float[] vec, int cur, int next)
        {
            return (vec[cur] <= vec[next]) ? cur : next;
        }

        static int CalcMaxIdx(float[] vec)
        {
            int maxIdx = 0;
            maxIdx = CalcLargerIdx(vec, maxIdx, 1);
            maxIdx = CalcLargerIdx(vec, maxIdx, 2);
            return maxIdx;
        }

        static int CalcMinIdx(float[] vec)
        {
            int minIdx = 0;
            minIdx = CalcSmallerIdx(vec, minIdx, 1);
            minIdx = CalcSmallerIdx(vec, minIdx, 2);
            return minIdx;
        }

        public static float[] Calc(Color rgb2)
        {
            var rgb = new float[] { rgb2.R / 255.0f, rgb2.G / 255.0f, rgb2.B / 255.0f };
            int maxIdx = CalcMaxIdx(rgb);
            float max = rgb[maxIdx];
            int minIdx = CalcMinIdx(rgb);
            float min = rgb[minIdx];
            float delta = max - min;

            var hsv = new float[3];
            hsv[2] = max; // v
            if (max != 0.0)
            {
                hsv[1] = delta / max;//s
            }
            else
            {
                hsv[1] = 0.0f;//s
            }

            if (delta == 0)
            {
                hsv[0] = 0;
            }
            else if (maxIdx == 0)
            {
                hsv[0] = (rgb[1] - rgb[2]) / delta;// h
            }
            else if (maxIdx == 1)
            {
                hsv[0] = 2 + (rgb[2] - rgb[0]) / delta;// h
            }
            else
            {
                hsv[0] = 4 + (rgb[0] - rgb[1]) / delta;// h
            }
            hsv[0] /= 6.0f;
            if (hsv[0] < 0) hsv[0] += 1.0f;

            return hsv;
        }
    }
}
