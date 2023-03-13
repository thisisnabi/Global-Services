namespace Hrg.Svr.CleanArchitecture.SharedKernel;

public abstract class ValueObject : IEquatable<ValueObject>
{
    protected abstract IEnumerable<object> GetEqualityComponents();

    protected static bool EqualOperator(ValueObject left, ValueObject right)
    {

        if (ReferenceEquals(left, null) ^ ReferenceEquals(right, null))
        {
            return false;
        }

        return ReferenceEquals(left, null) || left.Equals(right);
    }

    protected static bool NotEqualOperator(ValueObject left, ValueObject right)
    {
        return !EqualOperator(left, right);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType())
        {
            return false;
        }

        ValueObject other = (ValueObject)obj;

        return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    public bool Equals(ValueObject? other)
    {
        // First, convert to nullable objects
        return Equals((object?)other);
    }

    public override int GetHashCode()
    {
        return GetEqualityComponents()
                .Select(x => (x is not null) ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
    }

    public virtual ValueObject? Clone()
    {
        return MemberwiseClone() as ValueObject;
    }
}
