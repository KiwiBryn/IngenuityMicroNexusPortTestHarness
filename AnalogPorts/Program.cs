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
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;

using IngenuityMicro.Nexus;


namespace devMobile.IoT.IngenuityMicro.Nexus.AnalogPorts
{
	public class Program
	{
		public static void Main()
		{
			AnalogInput analogSensor1 = new AnalogInput
				(
				Pins.Analog.Socket1Pin1
				//Pins.Analog.Socket2Pin1
				//Pins.Analog.Socket3Pin1
				//Pins.Analog.Socket4Pin1
				);
			AnalogInput analogSensor2 = new AnalogInput
				(
				Pins.Analog.Socket1Pin2
				//Pins.Analog.Socket2Pin2
				//Pins.Analog.Socket3Pin2
				//Pins.Analog.Socket4Pin2
				);

			Debug.Print("Program running");

			while (true)
			{
				double sensorValue1 = analogSensor1.Read();
				double sensorValue2 = analogSensor2.Read();

				Debug.Print("Value 1:" + sensorValue1.ToString("F2") + " Value 2:" + sensorValue2.ToString("F2"));

				Thread.Sleep(500);
			}
		}
	}
}
