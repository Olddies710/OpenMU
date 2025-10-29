// <copyright file="DevilSquareInitializer.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d.Events;

using MUnique.OpenMU.DataModel.Configuration;

/// <summary>
/// Initializes the Devil Square event for version 0.97d.
/// Keeps the classic four game brackets of the 0.97d client while wiring the
/// event into the local map definitions.
/// </summary>
internal class DevilSquareInitializer : Version095d.Events.DevilSquareInitializer
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DevilSquareInitializer"/> class.
    /// </summary>
    /// <param name="context">The persistence context.</param>
    /// <param name="gameConfiguration">The target game configuration.</param>
    public DevilSquareInitializer(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }
}
