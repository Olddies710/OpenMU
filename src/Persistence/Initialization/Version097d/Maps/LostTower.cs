// <copyright file="LostTower.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d.Maps;

using MUnique.OpenMU.DataModel.Configuration;

/// <summary>
/// Initialization for the LostTower map of version 0.97d.
/// </summary>
internal class LostTower : Version075.Maps.LostTower
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LostTower"/> class.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="gameConfiguration">The game configuration.</param>
    public LostTower(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }
}
