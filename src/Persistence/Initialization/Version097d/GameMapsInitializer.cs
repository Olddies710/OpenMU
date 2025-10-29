// <copyright file="GameMapsInitializer.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d;

using System;
using System.Collections.Generic;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.Version097d.Maps;
using MUnique.OpenMU.Persistence.Initialization.Version095d.Maps;
using SeasonSixMaps = MUnique.OpenMU.Persistence.Initialization.VersionSeasonSix.Maps;

/// <summary>
/// Initializes the <see cref="GameMapDefinition"/>s for 0.97d (based on 0.95d/0.75 maps suitable for 0.97d).
/// </summary>
public class GameMapsInitializer : GameMapsInitializerBase
{
    public GameMapsInitializer(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }

    protected override IEnumerable<Type> MapInitializerTypes
    {
        get
        {
            yield return typeof(Lorencia);
            yield return typeof(Dungeon);
            yield return typeof(Devias);
            yield return typeof(Noria);
            yield return typeof(LostTower);
            yield return typeof(Exile);
            yield return typeof(Arena); // Stadium / Arena
            yield return typeof(Atlans);
            yield return typeof(Tarkan);
            yield return typeof(Icarus);
            yield return typeof(DevilSquare1);
            yield return typeof(DevilSquare2);
            yield return typeof(DevilSquare3);
            yield return typeof(DevilSquare4);
            yield return typeof(BloodCastle1);
            yield return typeof(BloodCastle2);
            yield return typeof(BloodCastle3);
            yield return typeof(BloodCastle4);
            yield return typeof(BloodCastle5);
            yield return typeof(BloodCastle6);
            yield return typeof(ChaosCastle1);
            yield return typeof(ChaosCastle2);
            yield return typeof(ChaosCastle3);
            yield return typeof(ChaosCastle4);
            yield return typeof(ChaosCastle5);
            yield return typeof(ChaosCastle6);
            yield return typeof(Version075.Maps.LostTower);
            yield return typeof(Version075.Maps.Exile);
            yield return typeof(Version075.Maps.Arena); // Stadium / Arena
            yield return typeof(Version075.Maps.Atlans);
            yield return typeof(Version095d.Maps.Tarkan);
            yield return typeof(Icarus);
            yield return typeof(Version095d.Maps.DevilSquare1);
            yield return typeof(Version095d.Maps.DevilSquare2);
            yield return typeof(Version095d.Maps.DevilSquare3);
            yield return typeof(Version095d.Maps.DevilSquare4);
            yield return typeof(SeasonSixMaps.BloodCastle1);
            yield return typeof(SeasonSixMaps.BloodCastle2);
            yield return typeof(SeasonSixMaps.BloodCastle3);
            yield return typeof(SeasonSixMaps.BloodCastle4);
            yield return typeof(SeasonSixMaps.BloodCastle5);
            yield return typeof(SeasonSixMaps.BloodCastle6);
            yield return typeof(SeasonSixMaps.ChaosCastle1);
            yield return typeof(SeasonSixMaps.ChaosCastle2);
            yield return typeof(SeasonSixMaps.ChaosCastle3);
            yield return typeof(SeasonSixMaps.ChaosCastle4);
            yield return typeof(SeasonSixMaps.ChaosCastle5);
            yield return typeof(SeasonSixMaps.ChaosCastle6);
        }
    }
}
