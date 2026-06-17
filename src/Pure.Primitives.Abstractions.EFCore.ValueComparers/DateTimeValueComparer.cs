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
                    && a.Microsecond.NumberValue == b.Microsecond.NumberValue
                    && a.Nanosecond.NumberValue == b.Nanosecond.NumberValue
                ),
            v => v == null ? 0 : ComputeHash(v)
        )
    { }

    private static int ComputeHash(IDateTime v)
    {
        HashCode hash = new();
        hash.Add(v.Year.NumberValue);
        hash.Add(v.Month.NumberValue);
        hash.Add(v.Day.NumberValue);
        hash.Add(v.Hour.NumberValue);
        hash.Add(v.Minute.NumberValue);
        hash.Add(v.Second.NumberValue);
        hash.Add(v.Millisecond.NumberValue);
        hash.Add(v.Microsecond.NumberValue);
        hash.Add(v.Nanosecond.NumberValue);
        return hash.ToHashCode();
    }
}
