using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pure.Primitives.Abstractions.Time;

namespace Pure.Primitives.Abstractions.EFCore.ValueComparers;

public sealed class TimeValueComparer : ValueComparer<ITime>
{
    public TimeValueComparer()
        : base(
            (a, b) =>
                ReferenceEquals(a, b)
                || (
                    a != null
                    && b != null
                    && a.Hour.NumberValue == b.Hour.NumberValue
                    && a.Minute.NumberValue == b.Minute.NumberValue
                    && a.Second.NumberValue == b.Second.NumberValue
                    && a.Millisecond.NumberValue == b.Millisecond.NumberValue
                ),
            v =>
                v == null
                    ? 0
                    : HashCode.Combine(
                        v.Hour.NumberValue,
                        v.Minute.NumberValue,
                        v.Second.NumberValue,
                        v.Millisecond.NumberValue
                    )
        )
    { }
}
