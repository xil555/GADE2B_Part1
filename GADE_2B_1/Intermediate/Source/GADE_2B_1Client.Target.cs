using UnrealBuildTool;

public class GADE_2B_1ClientTarget : TargetRules
{
	public GADE_2B_1ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("GADE_2B_1");
	}
}
