# Using source generators to create the C# class to access .resx strings

The `main` branch contains my broken attempt to modify my .csproj to get it working.

The `feature/try` branch contains the [documented working version](https://www.cazzulino.com/resources.html).

Further information:

- [GitHub discussion in `dotnet/runtime`](https://github.com/dotnet/runtime/discussions/115115)
- [Link to internal build target used by `dotnet/runtime`](https://github.com/dotnet/arcade/blob/main/src/Microsoft.DotNet.Arcade.Sdk/tools/GenerateResxSource.targets)
- [Link to issue discussing build-time generation for `.resx` files](https://github.com/dotnet/sdk/issues/94)