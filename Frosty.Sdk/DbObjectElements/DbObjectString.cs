using Frosty.Sdk.IO;

namespace Frosty.Sdk.DbObjectElements;

public class DbObjectString : DbObject
{
    private string _value;

    protected internal DbObjectString(Type inType)
        : base(inType)
    {
        _value = string.Empty;
    }

    public DbObjectString(string inValue)
        : base(Type.String | Type.Anonymous)
    {
        _value = inValue;
    }

    public DbObjectString(string inName, string inValue)
        : base(Type.String, inName)
    {
        _value = inValue;
    }

    public override string AsString()
    {
        return _value;
    }

    protected override void InternalSerialize(DataStream? stream)
    {
        // TODO: Null check decision pending on throw or ignore.
        if (stream is null)
        {
            throw new NotImplementedException("TODO: Null check decision pending on throw or ignore.");
        }

        stream.WriteSizedString(_value);
    }

    protected override void InternalDeserialize(DataStream? stream)
    {
        // TODO: Null check decision pending on throw or ignore.
        if (stream is null)
        {
            throw new NotImplementedException("TODO: Null check decision pending on throw or ignore.");
        }

        _value = stream.ReadSizedString();
    }

    public override string ToString()
    {
        return _value;
    }
}