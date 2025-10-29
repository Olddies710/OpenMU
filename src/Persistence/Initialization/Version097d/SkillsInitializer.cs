// <copyright file="SkillsInitializer.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d;

using System;
using System.Collections.Generic;
using System.Linq;
using MUnique.OpenMU.AttributeSystem;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.GameLogic.Attributes;
using MUnique.OpenMU.Persistence.Initialization.CharacterClasses;
using MUnique.OpenMU.Persistence.Initialization.Skills;

/// <summary>
/// Skills initializer reduced/adapted for 0.97d (no Magic Gladiator / Dark Lord specific skills).
/// This contains the core skills for Dark Wizard, Dark Knight and Fairy Elf.
/// </summary>
public class SkillsInitializer : SkillsInitializerBase
{
    private static readonly IDictionary<SkillNumber, MagicEffectNumber> EffectsOfSkills = new Dictionary<SkillNumber, MagicEffectNumber>
    {
        { SkillNumber.Defense, MagicEffectNumber.ShieldSkill },
        { SkillNumber.GreaterDefense, MagicEffectNumber.GreaterDefense },
        { SkillNumber.GreaterDamage, MagicEffectNumber.GreaterDamage },
        { SkillNumber.Heal, MagicEffectNumber.Heal },
    };

    public SkillsInitializer(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }

    public override void Initialize()
    {
        // Dark Wizard spells
        this.CreateSkill(SkillNumber.Poison, "Poison", CharacterClasses.DarkWizard, DamageType.Wizardry, 12, 6, manaConsumption: 42, energyRequirement: 140, elementalModifier: ElementalType.Poison);
        this.CreateSkill(SkillNumber.Meteorite, "Meteorite", CharacterClasses.DarkWizard, DamageType.Wizardry, 21, 6, manaConsumption: 12, energyRequirement: 104, elementalModifier: ElementalType.Earth);
        this.CreateSkill(SkillNumber.Lightning, "Lightning", CharacterClasses.DarkWizard, DamageType.Wizardry, 17, 6, manaConsumption: 15, energyRequirement: 72, elementalModifier: ElementalType.Lightning);
        this.CreateSkill(SkillNumber.FireBall, "Fire Ball", CharacterClasses.DarkWizard, DamageType.Wizardry, 8, 6, manaConsumption: 3, energyRequirement: 40, elementalModifier: ElementalType.Fire);
        this.CreateSkill(SkillNumber.Flame, "Flame", CharacterClasses.DarkWizard, DamageType.Wizardry, 25, 6, manaConsumption: 50, energyRequirement: 160, elementalModifier: ElementalType.Fire, skillType: SkillType.AreaSkillAutomaticHits);
        this.AddAreaSkillSettings(SkillNumber.Flame, false, default, default, default, true, TimeSpan.Zero, TimeSpan.FromMilliseconds(500), 0, 2, default, 0.5f, useTargetAreaFilter: true);

        // Dark Knight skills
        this.CreateSkill(SkillNumber.Defense, "Defense", CharacterClasses.DarkKnight, manaConsumption: 30, skillType: SkillType.Buff, skillTarget: SkillTarget.Explicit, implicitTargetRange: 0, targetRestriction: SkillTargetRestriction.Self);
        this.CreateSkill(SkillNumber.FallingSlash, "Falling Slash", CharacterClasses.DarkKnight, DamageType.Physical, distance: 3, manaConsumption: 9, movesToTarget: true, movesTarget: true);
        this.CreateSkill(SkillNumber.Lunge, "Lunge", CharacterClasses.DarkKnight, DamageType.Physical, distance: 2, manaConsumption: 9, movesToTarget: true, movesTarget: true);
        this.CreateSkill(SkillNumber.Uppercut, "Uppercut", CharacterClasses.DarkKnight, DamageType.Physical, distance: 2, manaConsumption: 8, movesToTarget: true, movesTarget: true);
        this.CreateSkill(SkillNumber.Cyclone, "Cyclone", CharacterClasses.DarkKnight, DamageType.Physical, distance: 2, manaConsumption: 9, movesToTarget: true, movesTarget: true);
        this.CreateSkill(SkillNumber.Slash, "Slash", CharacterClasses.DarkKnight, DamageType.Physical, distance: 2, manaConsumption: 10, movesToTarget: true, movesTarget: true);

        // Fairy Elf skills
        this.CreateSkill(SkillNumber.TripleShot, "Triple Shot", CharacterClasses.FairyElf, DamageType.Physical, distance: 6, manaConsumption: 5, skillType: SkillType.AreaSkillExplicitHits);
        this.CreateSkill(SkillNumber.Heal, "Heal", CharacterClasses.FairyElf, distance: 6, manaConsumption: 20, energyRequirement: 52, skillType: SkillType.Regeneration, targetRestriction: SkillTargetRestriction.Player);
        this.CreateSkill(SkillNumber.GreaterDefense, "Greater Defense", CharacterClasses.FairyElf, distance: 6, manaConsumption: 30, energyRequirement: 72, skillType: SkillType.Buff, targetRestriction: SkillTargetRestriction.Player);
        this.CreateSkill(SkillNumber.GreaterDamage, "Greater Damage", CharacterClasses.FairyElf, distance: 6, manaConsumption: 40, energyRequirement: 92, skillType: SkillType.Buff, targetRestriction: SkillTargetRestriction.Player);
        this.CreateSkill(SkillNumber.SummonGoblin, "Summon Goblin", CharacterClasses.FairyElf, manaConsumption: 40, energyRequirement: 30, skillType: SkillType.SummonMonster);

        // Map skills to basic effects (some references)
        // Keep mapping simple and essential for 0.97d - more complex mappings can be ported later if required.
        foreach (var effectOfSkill in EffectsOfSkills)
        {
            var skill = this.GameConfiguration.Skills.FirstOrDefault(s => s.Number == (short)effectOfSkill.Key);
            var effect = this.GameConfiguration.MagicEffects.FirstOrDefault(e => e.Number == (short)effectOfSkill.Value);
            if (skill is not null && effect is not null)
            {
                skill.MagicEffectDef = effect;
            }
        }
    }
}