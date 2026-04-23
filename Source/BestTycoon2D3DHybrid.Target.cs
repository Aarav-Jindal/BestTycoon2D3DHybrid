// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class BestTycoon2D3DHybridTarget : TargetRules
{
	public BestTycoon2D3DHybridTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V6;

		ExtraModuleNames.AddRange( new string[] { "BestTycoon2D3DHybrid" } );
	}
}
