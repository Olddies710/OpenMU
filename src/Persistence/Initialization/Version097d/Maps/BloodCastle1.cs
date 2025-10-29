// <copyright file="BloodCastle1.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d.Maps;

using MUnique.OpenMU.DataModel.Configuration;
using SeasonSixMaps = MUnique.OpenMU.Persistence.Initialization.VersionSeasonSix.Maps;

/// <summary>
/// Initialization for the Blood Castle 1 map of version 0.97d.
/// </summary>
internal class BloodCastle1 : SeasonSixMaps.BloodCastle1
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BloodCastle1"/> class.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="gameConfiguration">The game configuration.</param>
    public BloodCastle1(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }
}
