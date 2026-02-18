using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pure.Primitives.Abstractions.Char;

namespace Pure.Primitives.Abstractions.EFCore.ValueComparers;

public sealed class CharValueComparer : ValueComparer<IChar>
{
    public CharValueComparer()
        : base(
            (a, b) =>
                ReferenceEquals(a, b)
                || (a != null && b != null && a.CharValue == b.CharValue),
            v => v == null ? 0 : v.CharValue.GetHashCode()
        )
    { }
}
