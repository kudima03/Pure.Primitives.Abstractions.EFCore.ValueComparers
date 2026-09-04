# Changelog

All notable changes to Pure.Primitives.Abstractions.EFCore.ValueComparers are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.0.1.1] — 2026-06-17

### Fixed
- `TimeValueComparer` and `DateTimeValueComparer` now include `Microsecond` and `Nanosecond` in their equality and hash-code computation; values that differed only in those components were previously treated as equal.

## [0.1.0-preview.0.1.0] — 2026-02-18

### Added
- Initial release, targeting `net7.0`, `net8.0`, `net9.0`, and `net10.0`.
- EF Core `ValueComparer` implementations for the primitive value types from `Pure.Primitives.Abstractions`: `BoolValueComparer`, `CharValueComparer`, `DateValueComparer`, `DateTimeValueComparer`, `DayOfWeekValueComparer`, `GuidValueComparer`, `NumberValueComparer`, `StringValueComparer`, `TimeValueComparer`.
