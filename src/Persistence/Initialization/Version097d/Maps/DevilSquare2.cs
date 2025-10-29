// <copyright file="DevilSquare2.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d.Maps;

using MUnique.OpenMU.DataModel.Configuration;

/// <summary>
/// Initialization for the Devil Square 2 map of version 0.97d.
/// </summary>
internal class DevilSquare2 : Version095d.Maps.DevilSquare2
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DevilSquare2"/> class.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="gameConfiguration">The game configuration.</param>
    public DevilSquare2(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }
}
