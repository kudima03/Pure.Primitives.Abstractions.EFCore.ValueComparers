using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pure.Primitives.Abstractions.Guid;

namespace Pure.Primitives.Abstractions.EFCore.ValueComparers;

public sealed class GuidValueComparer : ValueComparer<IGuid>
{
    public GuidValueComparer()
        : base(
            (a, b) =>
                ReferenceEquals(a, b)
                || (a != null && b != null && a.GuidValue == b.GuidValue),
            v => v == null ? 0 : v.GuidValue.GetHashCode()
        )
    { }
}
