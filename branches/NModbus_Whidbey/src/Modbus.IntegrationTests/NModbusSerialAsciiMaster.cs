using System;
using System.IO.Ports;
using Modbus.Device;
using NUnit.Framework;

namespace Modbus.IntegrationTests
{
	[TestFixture]
	public class NModbusSerialAsciiMaster
	{
		[Test, ExpectedException(typeof(TimeoutException))]
		public void NModbusAsciiMaster_ReadTimeout()
		{
			using (SerialPort port = ModbusMasterFixture.CreateAndOpenSerialPort(ModbusMasterFixture.DefaultMasterSerialPortName))
			{
				IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
				master.ReadCoils(100, 1, 1);
			}
		}
	}
}
