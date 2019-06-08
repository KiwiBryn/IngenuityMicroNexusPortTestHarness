/*
The MIT License(MIT)
Copyright (C) December 2018 devMobile Software

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;

using IngenuityMicro.Nexus;


namespace devMobile.IoT.IngenuityMicro.Nexus.GpioPorts
{
	public class Program
	{
		const Cpu.Pin ButtonLedPin =
			Pins.Gpio.Socket1Pin1;
			//Pins.Gpio.Socket1Pin2;
			//Pins.Gpio.Socket2Pin1;
			//Pins.Gpio.Socket2Pin2;
			//Pins.Gpio.Socket3Pin1;
			//Pins.Gpio.Socket3Pin2;
			//Pins.Gpio.Socket4Pin1;
			//Pins.Gpio.Socket4Pin2;
			//Pins.Gpio.Socket5Pin1;
			//Pins.Gpio.Socket5Pin2;
			//Pins.Gpio.Socket6Pin1;
			//Pins.Gpio.Socket6Pin2;
			//Pins.Gpio.Socket7Pin1;
			//Pins.Gpio.Socket7Pin2;
			//Pins.Gpio.Socket8Pin1;
			//Pins.Gpio.Socket8Pin2;
			//Pins.Gpio.Socket9Pin1;
			//Pins.Gpio.Socket9Pin2;
			//Pins.Gpio.Socket10Pin1;
			//Pins.Gpio.Socket10Pin2;
			//Pins.Gpio.Socket11Pin1;
			//Pins.Gpio.Socket11Pin2;
		const Cpu.Pin ButtonPin =
			//Pins.Gpio.Socket1Pin1;
			Pins.Gpio.Socket1Pin2;
			//Pins.Gpio.Socket2Pin1;
			//Pins.Gpio.Socket2Pin2;
			//Pins.Gpio.Socket3Pin1;
			//Pins.Gpio.Socket3Pin2;
			//Pins.Gpio.Socket4Pin1;
			//Pins.Gpio.Socket4Pin2;
			//Pins.Gpio.Socket5Pin1;
			//Pins.Gpio.Socket5Pin2;
			//Pins.Gpio.Socket6Pin1;
			//Pins.Gpio.Socket6Pin2;
			//Pins.Gpio.Socket7Pin1;
			//Pins.Gpio.Socket7Pin2;
			//Pins.Gpio.Socket8Pin1;
			//Pins.Gpio.Socket8Pin2;
			//Pins.Gpio.Socket9Pin1;
			//Pins.Gpio.Socket9Pin2;
			//Pins.Gpio.Socket10Pin1;
			//Pins.Gpio.Socket10Pin2;
			//Pins.Gpio.Socket11Pin1;
			//Pins.Gpio.Socket11Pin2;
		static OutputPort buttonLed = new OutputPort(ButtonLedPin, false);

		public static void Main()
		{
			InterruptPort button = new InterruptPort(ButtonPin, false, Port.ResistorMode.Disabled, Port.InterruptMode.InterruptEdgeBoth);
			button.OnInterrupt += Button_OnInterrupt;

			Debug.Print("Program running");

			Thread.Sleep(Timeout.Infinite);
		}

		private static void Button_OnInterrupt(uint data1, uint data2, DateTime time)
		{
			Debug.Print(time.ToString("hh:mm:ss") + " Data1:" + data1 + " Data 2:" + data2);

			buttonLed.Write(!buttonLed.Read());
		}
	}
}
