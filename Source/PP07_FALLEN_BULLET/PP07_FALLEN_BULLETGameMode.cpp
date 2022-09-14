// Copyright Epic Games, Inc. All Rights Reserved.

#include "PP07_FALLEN_BULLETGameMode.h"
#include "PP07_FALLEN_BULLETCharacter.h"
#include "UObject/ConstructorHelpers.h"

APP07_FALLEN_BULLETGameMode::APP07_FALLEN_BULLETGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
