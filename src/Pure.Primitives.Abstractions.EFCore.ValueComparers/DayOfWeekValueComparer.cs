using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pure.Primitives.Abstractions.DayOfWeek;

namespace Pure.Primitives.Abstractions.EFCore.ValueComparers;

public sealed class DayOfWeekValueComparer : ValueComparer<IDayOfWeek>
{
    public DayOfWeekValueComparer()
        : base(
            (a, b) =>
                ReferenceEquals(a, b)
                || (
                    a != null
                    && b != null
                    && a.DayNumberValue.NumberValue == b.DayNumberValue.NumberValue
                ),
            v => v == null ? 0 : v.DayNumberValue.NumberValue.GetHashCode()
        )
    { }
}
