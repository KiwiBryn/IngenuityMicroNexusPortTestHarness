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
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;

namespace devMobile.IoT.IngenuityMicro.Nexus.I2CPorts
{
	public class Program
	{
		private const byte I2CAddressDefault = 0x53;
		private const int ClockRateKHz = 400;
		private const int TransactionTimeoutMilliseconds = 1000;

		private const byte RegisterDevice = 0x00;
		private const byte RegisterDeviceId = 0xE5; //

		public static void Main()
		{
			using (I2CDevice device = new I2CDevice(new I2CDevice.Configuration(I2CAddressDefault, ClockRateKHz)))
			{
				byte[] writeBuffer = { RegisterDevice };
				byte[] readBuffer = new byte[1];

				// check that the ADXL345 sensor connected
				I2CDevice.I2CTransaction[] action = new I2CDevice.I2CTransaction[]
				{
					I2CDevice.CreateWriteTransaction(writeBuffer),
					I2CDevice.CreateReadTransaction(readBuffer)
				};

				if (device.Execute(action, TransactionTimeoutMilliseconds) != 0)
				{
					Debug.Print("DeviceId read success");
				}
				else
				{
					Debug.Print("DeviceId read failure");
				}

				if (readBuffer[0] == RegisterDeviceId)
				{
					Debug.Print("DeviceId correct");
				}
				else
				{
					Debug.Print("DeviceId incorrect");
				}
			}
		}
	}
}
