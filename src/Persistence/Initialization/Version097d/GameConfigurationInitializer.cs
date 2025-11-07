// <copyright file="GameConfigurationInitializer.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d;

using System.Reflection;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.DataModel.Configuration.Items;
using MUnique.OpenMU.GameLogic.Attributes;
using MUnique.OpenMU.Persistence.Initialization.CharacterClasses;
using MUnique.OpenMU.Persistence.Initialization.Items;
using MUnique.OpenMU.Persistence.Initialization.Version097d.Events;
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
        base.Initialize();

        new CharacterClassInitialization(this.Context, this.GameConfiguration).Initialize();
        new SkillsInitializer(this.Context, this.GameConfiguration).Initialize();
        new Orbs(this.Context, this.GameConfiguration).Initialize();
        new Scrolls(this.Context, this.GameConfiguration).Initialize();
        new EventTicketItems(this.Context, this.GameConfiguration).Initialize();
        new Wings(this.Context, this.GameConfiguration).Initialize();
        new Pets(this.Context, this.GameConfiguration).Initialize();
        new ExcellentOptions(this.Context, this.GameConfiguration).Initialize();
        new Armors(this.Context, this.GameConfiguration).Initialize();
        new Weapons(this.Context, this.GameConfiguration).Initialize();
        new Potions(this.Context, this.GameConfiguration).Initialize();
        new Jewels(this.Context, this.GameConfiguration).Initialize();
        new Jewelery(this.Context, this.GameConfiguration).Initialize();
        new BoxOfLuck(this.Context, this.GameConfiguration).Initialize();
        new NpcInitialization(this.Context, this.GameConfiguration).Initialize();
        new InvasionMobsInitialization(this.Context, this.GameConfiguration).Initialize();
        new GameMapsInitializer(this.Context, this.GameConfiguration).Initialize();
        this.AssignCharacterClassHomeMaps();
        new ChaosMixes(this.Context, this.GameConfiguration).Initialize();
        new Gates(this.Context, this.GameConfiguration).Initialize();
        new DevilSquareInitializer(this.Context, this.GameConfiguration).Initialize();
        new BloodCastleInitializer(this.Context, this.GameConfiguration).Initialize();
        new ChaosCastleInitializer(this.Context, this.GameConfiguration).Initialize();
    }
}