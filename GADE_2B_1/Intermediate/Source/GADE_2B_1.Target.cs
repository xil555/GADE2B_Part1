using UnrealBuildTool;

public class GADE_2B_1Target : TargetRules
{
	public GADE_2B_1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("GADE_2B_1");
	}
}
