// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Multiplayer_MenuSys : ModuleRules
{
	public Multiplayer_MenuSys(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "OnlineSubsystemSteam", "OnlineSubsystem" });
	}
}
 