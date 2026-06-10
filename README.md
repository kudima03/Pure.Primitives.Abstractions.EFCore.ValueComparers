# Pure.Primitives.Abstractions.EFCore.ValueComparers

EF Core `ValueComparer` implementations for **Pure.Primitives** types — correct change-tracking for Pure primitive types stored via EF Core.

[![.NET build & test](https://github.com/kudima03/Pure.Primitives.Abstractions.EFCore.ValueComparers/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Primitives.Abstractions.EFCore.ValueComparers/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Primitives.Abstractions.EFCore.ValueComparers/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Primitives.Abstractions.EFCore.ValueComparers/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Primitives.Abstractions.EFCore.ValueComparers)](https://www.nuget.org/packages/Pure.Primitives.Abstractions.EFCore.ValueComparers)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE.txt)

## Overview

`Pure.Primitives.Abstractions.EFCore.ValueComparers` provides `ValueComparer<T>` implementations for every type in the [`Pure.Primitives`](https://github.com/kudima03/Pure.Primitives) ecosystem. EF Core uses value comparers to detect whether a tracked property has changed. Because Pure primitives use interface-based equality rather than `object.Equals`, a custom comparer is required for each type to ensure correct snapshot comparison and change detection.

Pair these comparers with the converters from [`Pure.Primitives.Abstractions.EFCore.Converters`](https://github.com/kudima03/Pure.Primitives.Abstractions.EFCore.Converters) when configuring entity properties.

## Comparers

| Comparer | Compares |
|----------|---------|
| `BoolValueComparer` | `IBool` |
| `CharValueComparer` | `IChar` |
| `StringValueComparer` | `IString` |
| `NumberValueComparer<T>` | `INumber<T>` |
| `GuidValueComparer` | `IGuid` |
| `DateValueComparer` | `IDate` |
| `TimeValueComparer` | `ITime` |
| `DateTimeValueComparer` | `IDateTime` |
| `DayOfWeekValueComparer` | `IDayOfWeek` |

## Dependencies

- [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions) — Pure primitive interfaces
