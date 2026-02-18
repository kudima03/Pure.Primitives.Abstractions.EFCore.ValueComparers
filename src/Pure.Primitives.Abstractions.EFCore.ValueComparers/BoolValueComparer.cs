using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Abstractions.EFCore.ValueComparers;

public sealed class BoolValueComparer : ValueComparer<IBool>
{
    public BoolValueComparer()
        : base(
            (a, b) =>
                ReferenceEquals(a, b)
                || (a != null && b != null && a.BoolValue == b.BoolValue),
            v => v == null ? 0 : v.BoolValue.GetHashCode()
        )
    { }
}
