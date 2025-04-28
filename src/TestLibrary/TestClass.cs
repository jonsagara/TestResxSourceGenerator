namespace TestLibrary;

public class TestClass
{
    // Before: Does not compile: The type or namespace name 'SR' does not exist in the namespace 'TestLibrary' (are you missing an assembly reference?)
    // After: this workaround works as of 2025-04-28: https://www.cazzulino.com/resources.html
    /*
    1. Setting the Custom Tool property of the .resx file to MSBuild:Compile in the properties window.

    2. Add a Directory.Build.targets file to the root of my solution/repo with the following content:

<Project>
  <PropertyGroup>
    <!-- Required for intellisense -->
    <CoreCompileDependsOn>CoreResGen;$(CoreCompileDependsOn)</CoreCompileDependsOn>
  </PropertyGroup>

  <ItemGroup>
    <EmbeddedResource Update="@(EmbeddedResource -> WithMetadataValue('Generator', 'MSBuild:Compile'))" Type="Resx">
      <StronglyTypedFileName>$(IntermediateOutputPath)\$([MSBuild]::ValueOrDefault('%(RelativeDir)', '').Replace('\', '.').Replace('/', '.'))%(Filename).g$(DefaultLanguageSourceExtension)</StronglyTypedFileName>
      <StronglyTypedLanguage>$(Language)</StronglyTypedLanguage>
      <StronglyTypedNamespace Condition="'%(RelativeDir)' == ''">$(RootNamespace)</StronglyTypedNamespace>
      <StronglyTypedNamespace Condition="'%(RelativeDir)' != ''">$(RootNamespace).$([MSBuild]::ValueOrDefault('%(RelativeDir)', '').Replace('\', '.').Replace('/', '.').TrimEnd('.'))</StronglyTypedNamespace>
      <StronglyTypedClassName>%(Filename)</StronglyTypedClassName>
    </EmbeddedResource>
  </ItemGroup>
</Project>

    3. The embedded resource in the project should look something like this:

	<ItemGroup>
		<EmbeddedResource Update="Resources\Strings.resx">
		  <Generator>MSBuild:Compile</Generator>
		</EmbeddedResource>
	</ItemGroup>
    */
    public static string GetWelcomeMesssage()
        => TestLibrary.Resources.Strings.Welcome;
}
