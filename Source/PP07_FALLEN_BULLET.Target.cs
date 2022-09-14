// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class PP07_FALLEN_BULLETTarget : TargetRules
{
	public PP07_FALLEN_BULLETTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("PP07_FALLEN_BULLET");
	}
}
