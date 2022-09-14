// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PP07_FALLEN_BULLET : ModuleRules
{
	public PP07_FALLEN_BULLET(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
