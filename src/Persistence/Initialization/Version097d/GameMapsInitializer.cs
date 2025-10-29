// <copyright file="GameMapsInitializer.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d;

using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.Version095d.Maps;

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
            yield return typeof(Version075.Maps.Arena); // Stadium / Arena
            yield return typeof(Atlans);
            yield return typeof(Version095d.Maps.Tarkan);
            yield return typeof(Icarus);
            yield return typeof(Version095d.Maps.DevilSquare1);
            yield return typeof(Version095d.Maps.DevilSquare2);
            yield return typeof(Version095d.Maps.DevilSquare3);
            yield return typeof(Version095d.Maps.DevilSquare4);
        }
    }
}