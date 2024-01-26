using UnrealBuildTool;

public class LayerSampleClientTarget : TargetRules
{
	public LayerSampleClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("LayerSample");
	}
}
