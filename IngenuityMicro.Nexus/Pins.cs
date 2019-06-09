using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;

// ReSharper disable CheckNamespace

namespace IngenuityMicro.Nexus
{
	public class Pins
	{
		public class Analog
		{
			public const Cpu.AnalogChannel Socket1Pin1 = (Cpu.AnalogChannel)0;
			public const Cpu.AnalogChannel Socket1Pin2 = (Cpu.AnalogChannel)1;

			public const Cpu.AnalogChannel Socket2Pin1 = (Cpu.AnalogChannel)3;
			public const Cpu.AnalogChannel Socket2Pin2 = (Cpu.AnalogChannel)2;

			public const Cpu.AnalogChannel Socket3Pin1 = (Cpu.AnalogChannel)4;
			public const Cpu.AnalogChannel Socket3Pin2 = (Cpu.AnalogChannel)5;

			public const Cpu.AnalogChannel Socket4Pin1 = (Cpu.AnalogChannel)6;
			public const Cpu.AnalogChannel Socket4Pin2 = (Cpu.AnalogChannel)7;
		}
		public class Gpio
		{
			public const Cpu.Pin Socket1Pin1 = (Cpu.Pin)((0 * 16) + 0);
			public const Cpu.Pin Socket1Pin2 = (Cpu.Pin)((0 * 16) + 1);

			public const Cpu.Pin Socket2Pin1 = (Cpu.Pin)((0 * 16) + 3);
			public const Cpu.Pin Socket2Pin2 = (Cpu.Pin)((0 * 16) + 2);

			public const Cpu.Pin Socket3Pin1 = (Cpu.Pin)((0 * 16) + 4);
			public const Cpu.Pin Socket3Pin2 = (Cpu.Pin)((0 * 16) + 5);

			public const Cpu.Pin Socket4Pin1 = (Cpu.Pin)((0 * 16) + 6);
			public const Cpu.Pin Socket4Pin2 = (Cpu.Pin)((0 * 16) + 7);

			public const Cpu.Pin Socket5Pin1 = (Cpu.Pin)((0 * 16) + 10);
			public const Cpu.Pin Socket5Pin2 = (Cpu.Pin)((0 * 16) + 9);

			public const Cpu.Pin Socket6Pin1 = (Cpu.Pin)((0 * 16) + 8);
			public const Cpu.Pin Socket6Pin2 = (Cpu.Pin)((1 * 16) + 9);

			public const Cpu.Pin Socket7Pin1 = (Cpu.Pin)((1 * 16) + 6);
			public const Cpu.Pin Socket7Pin2 = (Cpu.Pin)((1 * 16) + 7);

			public const Cpu.Pin Socket8Pin1 = (Cpu.Pin)((1 * 16) + 6);
			public const Cpu.Pin Socket8Pin2 = (Cpu.Pin)((1 * 16) + 7);

			public const Cpu.Pin Socket9Pin1 = (Cpu.Pin)((1 * 16) + 6);
			public const Cpu.Pin Socket9Pin2 = (Cpu.Pin)((1 * 16) + 7);

			public const Cpu.Pin Socket10Pin1 = (Cpu.Pin)((1 * 16) + 6);
			public const Cpu.Pin Socket10Pin2 = (Cpu.Pin)((1 * 16) + 7);

			public const Cpu.Pin Socket11Pin1 = (Cpu.Pin)((1 * 16) + 6);
			public const Cpu.Pin Socket11Pin2 = (Cpu.Pin)((1 * 16) + 7);
		}
		public class Pwm
		{
			public const Cpu.PWMChannel Socket6Pin1 = (Cpu.PWMChannel)0;
			public const Cpu.PWMChannel Socket6Pin2 = (Cpu.PWMChannel)10;
		}
		public class Uart
		{
			public const string Socket2 = "COM2";
			public const string Socket5 = "COM1";
		}
	}
}
