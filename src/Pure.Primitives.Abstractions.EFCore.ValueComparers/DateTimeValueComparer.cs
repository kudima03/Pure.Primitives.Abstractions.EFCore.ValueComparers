using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pure.Primitives.Abstractions.DateTime;

namespace Pure.Primitives.Abstractions.EFCore.ValueComparers;

public sealed class DateTimeValueComparer : ValueComparer<IDateTime>
{
    public DateTimeValueComparer()
        : base(
            (a, b) =>
                ReferenceEquals(a, b)
                || (
                    a != null
                    && b != null
                    && a.Year.NumberValue == b.Year.NumberValue
                    && a.Month.NumberValue == b.Month.NumberValue
                    && a.Day.NumberValue == b.Day.NumberValue
                    && a.Hour.NumberValue == b.Hour.NumberValue
                    && a.Minute.NumberValue == b.Minute.NumberValue
                    && a.Second.NumberValue == b.Second.NumberValue
                    && a.Millisecond.NumberValue == b.Millisecond.NumberValue
                ),
            v =>
                v == null
                    ? 0
                    : HashCode.Combine(
                        v.Year.NumberValue,
                        v.Month.NumberValue,
                        v.Day.NumberValue,
                        v.Hour.NumberValue,
                        v.Minute.NumberValue,
                        v.Second.NumberValue,
                        v.Millisecond.NumberValue
                    )
        )
    { }
}
