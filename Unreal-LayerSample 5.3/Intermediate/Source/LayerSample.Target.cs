using UnrealBuildTool;

public class LayerSampleTarget : TargetRules
{
	public LayerSampleTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("LayerSample");
	}
}
