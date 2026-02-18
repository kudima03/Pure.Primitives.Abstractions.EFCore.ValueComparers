using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pure.Primitives.Abstractions.Date;

namespace Pure.Primitives.Abstractions.EFCore.ValueComparers;

public sealed class DateValueComparer : ValueComparer<IDate>
{
    public DateValueComparer()
        : base(
            (a, b) =>
                ReferenceEquals(a, b)
                || (
                    a != null
                    && b != null
                    && a.Year.NumberValue == b.Year.NumberValue
                    && a.Month.NumberValue == b.Month.NumberValue
                    && a.Day.NumberValue == b.Day.NumberValue
                ),
            v =>
                v == null
                    ? 0
                    : HashCode.Combine(
                        v.Year.NumberValue,
                        v.Month.NumberValue,
                        v.Day.NumberValue
                    )
        )
    { }
}
