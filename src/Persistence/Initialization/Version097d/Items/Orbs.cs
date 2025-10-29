// <copyright file="Orbs.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d.Items;

using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.CharacterClasses;
using MUnique.OpenMU.Persistence.Initialization.Skills;

/// <summary>
/// Orbs for 0.97d. Based on 0.75 base, Twisting Slash orb added for Dark Knight only (no Magic Gladiator).
/// </summary>
internal class Orbs : Version075.Items.Orbs
{
    public Orbs(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }

    public override void Initialize()
    {
        // base creates the standard orbs from 0.75 baseline
        base.Initialize();

        // 0.97d: TwistingSlash for Dark Knight only (Magic Gladiator not present in this version)
        this.CreateOrb(7, SkillNumber.TwistingSlash, 1, "Orb of Twisting Slash", 47, 80, 0, 0, 0, 29000, CharacterClasses.DarkKnight);
    }
}