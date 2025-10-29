// <copyright file="GameConfigurationInitializer.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d;

using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.DataModel.Configuration.Items;
using MUnique.OpenMU.Persistence.Initialization.Version095d.Items;
using MUnique.OpenMU.Persistence.Initialization.Version075.Items;
using MUnique.OpenMU.Persistence.Initialization.Version097d.Items;

/// <summary>
/// Initializes the <see cref="GameConfiguration"/> for Version 0.97d.
/// Uses 0.95d baseline and selectively adapts to 0.97d rules (no Harmony/Guardian/Socket options).
/// </summary>
public class GameConfigurationInitializer : GameConfigurationInitializerBase
{
    public GameConfigurationInitializer(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }

    protected override IEnumerable<ItemOptionType> OptionTypes
    {
        get
        {
            // 0.97d: standard options only (Option, Luck, Excellent). No Harmony/Guardian/Socket.
            yield return ItemOptionTypes.Option;
            yield return ItemOptionTypes.Luck;
            yield return ItemOptionTypes.Excellent;
        }
    }

    public override void Initialize()
    {
        // base sets system defaults, attributes, slot types and item option types
        base.Initialize();

        // Version-specific initializers
        new CharacterClassInitialization(this.Context, this.GameConfiguration).Initialize();

        // Skills adapted to 0.97d (no Magic Gladiator / Dark Lord specific mappings)
        new SkillsInitializer(this.Context, this.GameConfiguration).Initialize();

        // Orbs (adds Twisting Slash for Dark Knight only)
        new Orbs(this.Context, this.GameConfiguration).Initialize();

        // Reuse proven initializers from 0.95d / 0.75 where compatible
        new Version095d.Items.Scrolls(this.Context, this.GameConfiguration).Initialize();
        new Version095d.Items.EventTicketItems(this.Context, this.GameConfiguration).Initialize();
        new Version097d.Items.Jewels(this.Context, this.GameConfiguration).Initialize();
        new MUnique.OpenMU.Persistence.Initialization.Items.ExcellentOptions(this.Context, this.GameConfiguration).Initialize();
        new Version095d.Items.Armors(this.Context, this.GameConfiguration).Initialize();
        new Version095d.Items.Wings(this.Context, this.GameConfiguration).Initialize(); // 0.95d wings compatible with 0.97d class set
        new Version095d.Items.Pets(this.Context, this.GameConfiguration).Initialize();
        new Version095d.Items.Weapons(this.Context, this.GameConfiguration).Initialize();
        new Version075.Items.Potions(this.Context, this.GameConfiguration).Initialize();
        new Version095d.Items.Jewelery(this.Context, this.GameConfiguration).Initialize();
        new Version095d.Items.BoxOfLuck(this.Context, this.GameConfiguration).Initialize();
        new Version095d.Maps.NpcInitialization(this.Context, this.GameConfiguration).Initialize();
        new Version095d.Maps.InvasionMobsInitialization(this.Context, this.GameConfiguration).Initialize();

        new GameMapsInitializer(this.Context, this.GameConfiguration).Initialize();
        this.AssignCharacterClassHomeMaps();

        new Version095d.Items.ChaosMixes(this.Context, this.GameConfiguration).Initialize();
        new Version095d.Gates(this.Context, this.GameConfiguration).Initialize();
        new Version095d.DevilSquareInitializer(this.Context, this.GameConfiguration).Initialize();
    }
}