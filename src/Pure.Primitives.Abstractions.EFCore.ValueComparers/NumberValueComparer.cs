using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Abstractions.EFCore.ValueComparers;

public sealed class NumberValueComparer<T> : ValueComparer<INumber<T>>
    where T : System.Numerics.INumber<T>
{
    public NumberValueComparer()
        : base(
            (a, b) =>
                ReferenceEquals(a, b)
                || (a != null && b != null && a.NumberValue.Equals(b.NumberValue)),
            v => v == null ? 0 : v.NumberValue.GetHashCode()
        )
    { }
}
