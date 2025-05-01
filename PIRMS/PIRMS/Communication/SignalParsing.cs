using MathNet.Numerics.IntegralTransforms;
using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIRMS.Communication
{
    internal static class SignalParsing
    {
        public static List<(double Frequency, double Amplitude)> CalculateFft(short[] audioSamples, int sampleRate = 44100)
        {
            int length = audioSamples.Length;

            // Convert short[] to Complex32[]
            var complexSamples = new Complex32[length];
            for (int i = 0; i < length; i++)
            {
                complexSamples[i] = new Complex32(audioSamples[i], 0);
            }

            // Apply FFT in-place
            Fourier.Forward(complexSamples, FourierOptions.Matlab);

            var results = new List<(double Frequency, double Amplitude)>();
            int halfLength = length / 2;

            for (int i = 0; i < halfLength; i++)
            {
                double frequency = (double)i * sampleRate / length;
                double amplitude = complexSamples[i].Magnitude;
                results.Add((frequency, amplitude));
            }

            return results;
        }
    }
}
