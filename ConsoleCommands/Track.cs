﻿using EFT.Trainer.Properties;
using JetBrains.Annotations;

#nullable enable

namespace EFT.Trainer.ConsoleCommands;

[UsedImplicitly]
internal class Track : BaseTrackCommand
{
	public override string Name => Strings.CommandTrack;
}
