using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pure.Primitives.Abstractions.String;

namespace Pure.Primitives.Abstractions.EFCore.ValueComparers;

public sealed class StringValueComparer : ValueComparer<IString>
{
    public StringValueComparer()
        : base(
            (a, b) =>
                ReferenceEquals(a, b)
                || (a != null && b != null && a.TextValue == b.TextValue),
            v => v == null ? 0 : v.TextValue.GetHashCode()
        )
    { }
}
