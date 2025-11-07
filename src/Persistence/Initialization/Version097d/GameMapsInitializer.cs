// <copyright file="GameMapsInitializer.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d;

using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.Version097d.Maps;

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
            yield return typeof(Version075.Maps.Dungeon);
            yield return typeof(Devias);
            yield return typeof(Noria);
            yield return typeof(Version075.Maps.LostTower);
            yield return typeof(Version075.Maps.Exile);
            yield return typeof(Version075.Maps.Arena);
            yield return typeof(Version075.Maps.Atlans);
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
        }
    }
}
