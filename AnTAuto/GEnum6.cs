using System;

[Flags]
public enum GEnum6 : uint
{
	None = 0x0,
	Read = 0x1,
	Write = 0x2,
	Delete = 0x4
}
