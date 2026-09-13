namespace Frosty.Sdk.Ebx;

// CA1028: Enum storage should be Int32
// TODO: Is Int32 actual better on this (remove `: byte` and pragma to apply fix)
#pragma warning disable CA1028
public enum PointerRefType : byte
#pragma warning restore CA1028
{
    Null = 0,
    Internal = 1,
    External = 2
}