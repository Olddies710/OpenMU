// <copyright file="ChaosCastle6.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d.Maps;

using MUnique.OpenMU.DataModel.Configuration;
using SeasonSixMaps = MUnique.OpenMU.Persistence.Initialization.VersionSeasonSix.Maps;

/// <summary>
/// Initialization for the Chaos Castle 6 map of version 0.97d.
/// </summary>
internal class ChaosCastle6 : SeasonSixMaps.ChaosCastle6
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ChaosCastle6"/> class.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="gameConfiguration">The game configuration.</param>
    public ChaosCastle6(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }
}
