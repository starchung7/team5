using UnrealBuildTool;

public class LayerSampleServerTarget : TargetRules
{
	public LayerSampleServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("LayerSample");
	}
}
