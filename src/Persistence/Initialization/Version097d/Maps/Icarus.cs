// <copyright file="Icarus.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d.Maps;

using MUnique.OpenMU.DataModel.Configuration;

/// <summary>
/// Initialization for the Icarus map of version 0.97d.
/// </summary>
internal class Icarus : Version095d.Maps.Icarus
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Icarus"/> class.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="gameConfiguration">The game configuration.</param>
    public Icarus(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }
}
