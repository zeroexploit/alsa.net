﻿using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Iot.Device.Media;

namespace Alsa.Samples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            SoundConnectionSettings settings = new SoundConnectionSettings();
            UnixSoundDevice device = new UnixSoundDevice(settings);

            await device.PlayAsync("/home/pi/1.wav", CancellationToken.None);

            Console.WriteLine(111);
            Console.ReadKey();
        }
    }
}
