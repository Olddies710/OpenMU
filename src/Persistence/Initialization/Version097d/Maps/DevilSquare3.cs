// <copyright file="DevilSquare3.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d.Maps;

using MUnique.OpenMU.DataModel.Configuration;

/// <summary>
/// Initialization for the Devil Square 3 map of version 0.97d.
/// </summary>
internal class DevilSquare3 : Version095d.Maps.DevilSquare3
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DevilSquare3"/> class.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="gameConfiguration">The game configuration.</param>
    public DevilSquare3(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }
}
