using UnrealBuildTool;

public class GADE_2B_1EditorTarget : TargetRules
{
	public GADE_2B_1EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("GADE_2B_1");
	}
}
