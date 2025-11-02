using System;
using System.Net;
using System.Runtime.InteropServices;

internal class Class42
{
	private enum Enum0
	{
		TCP_TABLE_BASIC_LISTENER,
		TCP_TABLE_BASIC_CONNECTIONS,
		TCP_TABLE_BASIC_ALL,
		TCP_TABLE_OWNER_PID_LISTENER,
		TCP_TABLE_OWNER_PID_CONNECTIONS,
		TCP_TABLE_OWNER_PID_ALL,
		TCP_TABLE_OWNER_MODULE_LISTENER,
		TCP_TABLE_OWNER_MODULE_CONNECTIONS,
		TCP_TABLE_OWNER_MODULE_ALL
	}

	private enum MibTcpState
	{
		CLOSED = 1,
		LISTENING = 2,
		SYN_SENT = 3,
		SYN_RCVD = 4,
		ESTABLISHED = 5,
		FIN_WAIT1 = 6,
		FIN_WAIT2 = 7,
		CLOSE_WAIT = 8,
		CLOSING = 9,
		LAST_ACK = 10,
		TIME_WAIT = 11,
		DELETE_TCB = 12,
		NONE = 0
	}

	private struct Struct20
	{
		public MibTcpState mibTcpState_0;

		public uint uint_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] byte_0;

		public uint uint_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] byte_1;

		public int int_0;
	}

	private struct Struct21
	{
		public uint uint_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
		public Struct20[] struct20_0;
	}

	private const int int_0 = 2;

	[DllImport("iphlpapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern uint GetExtendedTcpTable(IntPtr intptr_0, ref int int_1, bool bool_0, int int_2, Enum0 enum0_0, uint uint_0 = 0u);

	public static GStruct24[] smethod_0(int[] int_1 = null)
	{
		GStruct24[] array = null;
		try
		{
			int int_2 = 0;
			uint extendedTcpTable = GetExtendedTcpTable(IntPtr.Zero, ref int_2, bool_0: true, 2, Enum0.TCP_TABLE_OWNER_PID_ALL);
			IntPtr intPtr = Marshal.AllocHGlobal(int_2);
			if (GetExtendedTcpTable(intPtr, ref int_2, bool_0: true, 2, Enum0.TCP_TABLE_OWNER_PID_ALL) != 0)
			{
				return null;
			}
			Struct21 @struct = (Struct21)Marshal.PtrToStructure(intPtr, typeof(Struct21));
			if (@struct.uint_0 == 0)
			{
				return null;
			}
			IntPtr intPtr2 = (IntPtr)((long)intPtr + Marshal.SizeOf((object)@struct.uint_0));
			array = ((int_1 == null) ? new GStruct24[@struct.uint_0] : new GStruct24[int_1.Length]);
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < @struct.uint_0; i++)
			{
				Struct20 struct2 = (Struct20)Marshal.PtrToStructure(intPtr2, typeof(Struct20));
				intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf((object)struct2));
				if (int_1 != null)
				{
					num = -1;
					for (int j = 0; j < int_1.Length; j++)
					{
						if (int_1[j] == struct2.int_0)
						{
							num = j;
							break;
						}
					}
					if (num < 0)
					{
						continue;
					}
				}
				if (array.Length <= num2)
				{
					Array.Resize(ref array, num2 + 1);
				}
				array[num2].int_0 = struct2.int_0;
				array[num2].string_1 = new IPAddress(struct2.uint_0).ToString();
				array[num2].int_1 = BitConverter.ToUInt16(new byte[2]
				{
					struct2.byte_0[1],
					struct2.byte_0[0]
				}, 0);
				string text = new IPAddress(struct2.uint_1).ToString();
				array[num2].string_2 = text;
				array[num2].int_2 = BitConverter.ToUInt16(new byte[2]
				{
					struct2.byte_1[1],
					struct2.byte_1[0]
				}, 0);
				array[num2].string_0 = struct2.mibTcpState_0.ToString();
				array[num2].uint_0 = Class11.smethod_7(text);
				num2++;
			}
		}
		catch
		{
		}
		return array;
	}
}
