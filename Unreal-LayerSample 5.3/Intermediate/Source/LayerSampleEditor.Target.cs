using UnrealBuildTool;

public class LayerSampleEditorTarget : TargetRules
{
	public LayerSampleEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("LayerSample");
	}
}
