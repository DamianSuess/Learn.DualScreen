# .NET MAUI Dual Screen Sample

This repo provides a sample as to how to work with Dual-Screen mobile applications.

DualScreen for Surface Duo and Samsung foldables!

Currently this feature is undocumented in .NET MAUI, however, we can
take a sneak-peak at PR #5020 to reconstruct what's going on here.

[https://github.com/dotnet/maui/pull/5020]

## How to use

Initialize in your Host Builder via `.UseFoldable()` (`Startup.cs`)

Namespaces:

* Control - `Microsoft.Maui.Controls.Foldable.TwoPaneView`
* Class - `Microsoft.Maui.Foldable.DualScreenInfo`

## DualScreenInfo

* **SpanningBounds** – when spanned across two screens, return two rectangles indicating the bounds of each visible area. This property will return an empty array if the window isn't spanned.
* **HingeBounds** – the position of the hinge on the screen.
* **IsLandscape** – if the device is landscape. This property is useful because native orientation APIs don't report orientation correctly when an application is spanned.
* **SpanMode** – whether the layout is in tall, wide, or single pane mode.

## References

* [Dual-Screen Docs](https://docs.microsoft.com/en-us/dual-screen/introduction#dual-screen-app-patterns)
* [Suess Labs](https://suesslabs.com/)
* [Prism Library](https://prismlibrary.com/)
* [https://devblogs.microsoft.com/xamarin/xamarin-goes-dual-screen/]
* [Learn Module](https://docs.microsoft.com/en-us/learn/modules/xamarin-forms-dual-screen/2-display-two-screens)
