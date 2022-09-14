// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class PP07_FALLEN_BULLETEditorTarget : TargetRules
{
	public PP07_FALLEN_BULLETEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("PP07_FALLEN_BULLET");
	}
}
