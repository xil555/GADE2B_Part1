using UnrealBuildTool;

public class GADE_2B_1ServerTarget : TargetRules
{
	public GADE_2B_1ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("GADE_2B_1");
	}
}
