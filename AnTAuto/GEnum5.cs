using System;

[Flags]
public enum GEnum5 : uint
{
	Delete = 0x10000,
	ReadControl = 0x20000,
	WriteDAC = 0x40000,
	WriteOwner = 0x80000,
	Synchronize = 0x100000,
	AccessSystemSecurity = 0x1000000,
	MaximumAllowed = 0x2000000,
	GenericAll = 0x10000000,
	GenericExecute = 0x20000000,
	GenericWrite = 0x40000000,
	GenericRead = 0x80000000
}
