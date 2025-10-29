// <copyright file="Armors.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d.Items;

using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.Items;

/// <summary>
/// Initializer for armor data.
/// </summary>
public class Armors : ArmorInitializerBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Armors"/> class.
    /// </summary>
    /// <param name="context">The persistence context.</param>
    /// <param name="gameConfiguration">The game configuration.</param>
    public Armors(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }

    /// <inheritdoc />
    protected override byte MaximumArmorLevel => Constants.MaximumItemLevel;

    /// <summary>
    /// Initializes armor data.
    /// </summary>
    public override void Initialize()
    {
        base.Initialize();

        // Shields:
        this.CreateShield(0, 1, 0, 2, 2, "Small Shield", 3, 1, 3, 22, 70, 0, 1, 1, 1);
        this.CreateShield(1, 1, 0, 2, 2, "Horn Shield", 9, 3, 9, 28, 100, 0, 0, 1, 0);
        this.CreateShield(2, 1, 0, 2, 2, "Kite Shield", 12, 4, 12, 32, 110, 0, 0, 1, 0);
        this.CreateShield(3, 1, 0, 2, 2, "Elven Shield", 21, 8, 21, 36, 30, 100, 0, 0, 1);
        this.CreateShield(4, 1, 18, 2, 2, "Buckler", 6, 2, 6, 24, 80, 0, 1, 1, 1);
        this.CreateShield(5, 1, 18, 2, 2, "Dragon Slayer Shield", 35, 10, 36, 44, 100, 40, 0, 1, 0);
        this.CreateShield(6, 1, 18, 2, 2, "Skull Shield", 15, 5, 15, 34, 110, 0, 1, 1, 1);
        this.CreateShield(7, 1, 18, 2, 2, "Spiked Shield", 30, 9, 30, 40, 130, 0, 0, 1, 0);
        this.CreateShield(8, 1, 18, 2, 2, "Tower Shield", 40, 11, 40, 46, 130, 0, 0, 1, 1);
        this.CreateShield(9, 1, 18, 2, 2, "Plate Shield", 25, 8, 25, 38, 120, 0, 0, 1, 0);
        this.CreateShield(10, 1, 18, 2, 2, "Big Round Shield", 18, 6, 18, 35, 120, 0, 0, 1, 0);
        this.CreateShield(11, 1, 18, 2, 2, "Serpent Shield", 45, 12, 45, 48, 130, 0, 0, 1, 1);
        this.CreateShield(12, 1, 18, 2, 2, "Bronze Shield", 54, 13, 54, 52, 140, 0, 0, 1, 0);
        this.CreateShield(13, 1, 18, 2, 2, "Dragon Shield", 60, 14, 60, 60, 120, 40, 0, 1, 0);
        this.CreateShield(14, 1, 0, 2, 3, "Legendary Shield", 48, 7, 48, 50, 90, 25, 1, 0, 1);
        this.CreateShield(15, 1, 0, 2, 3, "Grand Soul Shield", 74, 12, 55, 55, 0, 70, 23, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0);
        this.CreateShield(16, 1, 0, 2, 2, "Elemental Shield", 66, 11, 28, 51, 0, 30, 60, 30, 0, 0, 0, 0, 2, 0, 0, 0, 0);

        // Helmets:
        this.CreateArmor(0, 2, 2, 2, "Bronze Helm", 16, 9, 34, 80, 20, 0, 1, 0);
        this.CreateArmor(1, 2, 2, 2, "Dragon Helm", 57, 24, 68, 120, 30, 0, 1, 0);
        this.CreateArmor(2, 2, 2, 2, "Pad Helm", 5, 4, 28, 20, 0, 1, 0, 0);
        this.CreateArmor(3, 2, 2, 2, "Legendary Helm", 50, 18, 42, 30, 0, 1, 0, 0);
        this.CreateArmor(4, 2, 2, 2, "Bone Helm", 18, 9, 30, 30, 0, 1, 0, 0);
        this.CreateArmor(5, 2, 2, 2, "Leather Helm", 6, 5, 30, 80, 0, 0, 1, 0);
        this.CreateArmor(6, 2, 2, 2, "Scale Helm", 26, 12, 40, 110, 0, 0, 1, 0);
        this.CreateArmor(7, 2, 2, 2, "Sphinx Mask", 32, 13, 36, 30, 0, 1, 0, 0);
        this.CreateArmor(8, 2, 2, 2, "Brass Helm", 36, 17, 44, 100, 30, 0, 1, 0);
        this.CreateArmor(9, 2, 2, 2, "Plate Helm", 46, 20, 50, 130, 0, 0, 1, 0);
        this.CreateArmor(10, 2, 2, 2, "Vine Helm", 6, 4, 22, 30, 60, 0, 0, 1);
        this.CreateArmor(11, 2, 2, 2, "Silk Helm", 16, 8, 26, 30, 70, 0, 0, 1);
        this.CreateArmor(12, 2, 2, 2, "Wind Helm", 28, 12, 32, 30, 80, 0, 0, 1);
        this.CreateArmor(13, 2, 2, 2, "Spirit Helm", 40, 16, 38, 40, 80, 0, 0, 1);
        this.CreateArmor(14, 2, 2, 2, "Guardian Helm", 53, 23, 45, 40, 80, 0, 0, 1);
        this.CreateArmor(16, 2, 2, 2, "Black Dragon Helm", 82, 30, 74, 0, 170, 60, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0);
        this.CreateArmor(17, 2, 2, 2, "Dark Phoenix Helm", 92, 43, 80, 0, 205, 62, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0);
        this.CreateArmor(18, 2, 2, 2, "Grand Soul Helm", 81, 27, 67, 0, 59, 20, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0);
        this.CreateArmor(19, 2, 2, 2, "Divine Helm", 85, 37, 74, 0, 50, 110, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0);
        this.CreateArmor(21, 2, 2, 2, "Great Dragon Helm", 104, 53, 86, 0, 200, 58, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0);

        // Armors:
        this.CreateArmor(0, 3, 2, 2, "Bronze Armor", 18, 14, 34, 80, 20, 0, 1, 0);
        this.CreateArmor(1, 3, 2, 3, "Dragon Armor", 59, 37, 68, 120, 30, 0, 1, 0);
        this.CreateArmor(2, 3, 2, 2, "Pad Armor", 10, 7, 28, 30, 0, 1, 0, 0);
        this.CreateArmor(3, 3, 2, 2, "Legendary Armor", 56, 22, 42, 40, 0, 1, 0, 0);
        this.CreateArmor(4, 3, 2, 2, "Bone Armor", 22, 13, 30, 40, 0, 1, 0, 0);
        this.CreateArmor(5, 3, 2, 3, "Leather Armor", 10, 10, 30, 80, 0, 0, 1, 0);
        this.CreateArmor(6, 3, 2, 2, "Scale Armor", 28, 18, 40, 110, 0, 0, 1, 0);
        this.CreateArmor(7, 3, 2, 3, "Sphinx Armor", 38, 17, 36, 40, 0, 1, 0, 0);
        this.CreateArmor(8, 3, 2, 2, "Brass Armor", 38, 22, 44, 100, 30, 0, 1, 0);
        this.CreateArmor(9, 3, 2, 2, "Plate Armor", 48, 30, 50, 130, 0, 0, 1, 0);
        this.CreateArmor(10, 3, 2, 2, "Vine Armor", 10, 8, 22, 30, 60, 0, 0, 1);
        this.CreateArmor(11, 3, 2, 2, "Silk Armor", 20, 12, 26, 30, 70, 0, 0, 1);
        this.CreateArmor(12, 3, 2, 2, "Wind Armor", 32, 16, 32, 30, 80, 0, 0, 1);
        this.CreateArmor(13, 3, 2, 2, "Spirit Armor", 44, 21, 38, 40, 80, 0, 0, 1);
        this.CreateArmor(14, 3, 2, 2, "Guardian Armor", 57, 29, 45, 40, 80, 0, 0, 1);
        this.CreateArmor(15, 3, 2, 3, "Storm Crow Armor", 80, 44, 80, 0, 150, 70, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0);
        this.CreateArmor(16, 3, 2, 3, "Black Dragon Armor", 90, 48, 74, 0, 170, 60, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0);
        this.CreateArmor(17, 3, 2, 3, "Dark Phoenix Armor", 100, 63, 80, 0, 214, 65, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0);
        this.CreateArmor(18, 3, 2, 3, "Grand Soul Armor", 91, 33, 67, 0, 59, 20, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0);
        this.CreateArmor(19, 3, 2, 2, "Divine Armor", 92, 44, 74, 0, 50, 110, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0);
        this.CreateArmor(20, 3, 2, 3, "Thunder Hawk Armor", 107, 60, 82, 0, 170, 70, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0);
        this.CreateArmor(21, 3, 2, 3, "Great Dragon Armor", 126, 75, 86, 0, 200, 58, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0);

        // Pants:
        this.CreateArmor(0, 4, 2, 2, "Bronze Pants", 15, 10, 34, 80, 20, 0, 1, 0);
        this.CreateArmor(1, 4, 2, 2, "Dragon Pants", 55, 26, 68, 120, 30, 0, 1, 0);
        this.CreateArmor(2, 4, 2, 2, "Pad Pants", 8, 5, 28, 30, 0, 1, 0, 0);
        this.CreateArmor(3, 4, 2, 2, "Legendary Pants", 53, 20, 42, 40, 0, 1, 0, 0);
        this.CreateArmor(4, 4, 2, 2, "Bone Pants", 20, 10, 30, 40, 0, 1, 0, 0);
        this.CreateArmor(5, 4, 2, 2, "Leather Pants", 8, 7, 30, 80, 0, 0, 1, 0);
        this.CreateArmor(6, 4, 2, 2, "Scale Pants", 25, 14, 40, 110, 0, 0, 1, 0);
        this.CreateArmor(7, 4, 2, 2, "Sphinx Pants", 34, 15, 36, 40, 0, 1, 0, 0);
        this.CreateArmor(8, 4, 2, 2, "Brass Pants", 35, 18, 44, 100, 30, 0, 1, 0);
        this.CreateArmor(9, 4, 2, 2, "Plate Pants", 45, 22, 50, 130, 0, 0, 1, 0);
        this.CreateArmor(10, 4, 2, 2, "Vine Pants", 8, 6, 22, 30, 60, 0, 0, 1);
        this.CreateArmor(11, 4, 2, 2, "Silk Pants", 18, 10, 26, 30, 70, 0, 0, 1);
        this.CreateArmor(12, 4, 2, 2, "Wind Pants", 30, 14, 32, 30, 80, 0, 0, 1);
        this.CreateArmor(13, 4, 2, 2, "Spirit Pants", 42, 18, 38, 40, 80, 0, 0, 1);
        this.CreateArmor(14, 4, 2, 2, "Guardian Pants", 54, 25, 45, 40, 80, 0, 0, 1);
        this.CreateArmor(15, 4, 2, 2, "Storm Crow Pants", 74, 34, 80, 0, 150, 70, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0);
        this.CreateArmor(16, 4, 2, 2, "Black Dragon Pants", 84, 40, 74, 0, 170, 60, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0);
        this.CreateArmor(17, 4, 2, 2, "Dark Phoenix Pants", 96, 54, 80, 0, 207, 63, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0);
        this.CreateArmor(18, 4, 2, 2, "Grand Soul Pants", 86, 30, 67, 0, 59, 20, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0);
        this.CreateArmor(19, 4, 2, 2, "Divine Pants", 88, 39, 74, 0, 50, 110, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0);
        this.CreateArmor(20, 4, 2, 2, "Thunder Hawk Pants", 99, 49, 82, 0, 150, 70, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0);
        this.CreateArmor(21, 4, 2, 2, "Great Dragon Pants", 113, 65, 86, 0, 200, 58, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0);

        // Gloves:
        this.CreateGloves(0, "Bronze Gloves", 13, 4, 4, 34, 80, 20, 0, 1, 0);
        this.CreateGloves(1, "Dragon Gloves", 52, 14, 6, 68, 120, 30, 0, 1, 0);
        this.CreateGloves(2, "Pad Gloves", 3, 2, 0, 28, 20, 0, 1, 0, 0);
        this.CreateGloves(3, "Legendary Gloves", 44, 11, 0, 42, 20, 0, 1, 0, 0);
        this.CreateGloves(4, "Bone Gloves", 14, 5, 0, 30, 20, 0, 1, 0, 0);
        this.CreateGloves(5, "Leather Gloves", 4, 2, 8, 30, 80, 0, 0, 1, 0);
        this.CreateGloves(6, "Scale Gloves", 22, 7, 10, 40, 110, 0, 0, 1, 0);
        this.CreateGloves(7, "Sphinx Gloves", 28, 8, 0, 36, 20, 0, 1, 0, 0);
        this.CreateGloves(8, "Brass Gloves", 32, 9, 8, 44, 100, 30, 0, 1, 0);
        this.CreateGloves(9, "Plate Gloves", 42, 12, 4, 50, 130, 0, 0, 1, 0);
        this.CreateGloves(10, "Vine Gloves", 4, 2, 4, 22, 30, 60, 0, 0, 1);
        this.CreateGloves(11, "Silk Gloves", 14, 4, 8, 26, 30, 70, 0, 0, 1);
        this.CreateGloves(12, "Wind Gloves", 26, 6, 10, 32, 30, 80, 0, 0, 1);
        this.CreateGloves(13, "Spirit Gloves", 38, 9, 4, 38, 40, 80, 0, 0, 1);
        this.CreateGloves(14, "Guardian Gloves", 50, 15, 6, 45, 40, 80, 0, 0, 1);
        this.CreateGloves(15, "Storm Crow Gloves", 70, 20, 6, 80, 0, 150, 70, 0, 0, 0, 1, 0, 0);
        this.CreateGloves(16, "Black Dragon Gloves", 76, 22, 6, 74, 0, 170, 60, 0, 1, 0, 0, 0, 0);
        this.CreateGloves(17, "Dark Phoenix Gloves", 86, 37, 6, 80, 0, 205, 63, 0, 2, 0, 0, 0, 0);
        this.CreateGloves(18, "Grand Soul Gloves", 70, 20, 5, 67, 0, 49, 10, 2, 0, 0, 0, 0, 0);
        this.CreateGloves(19, "Divine Gloves", 72, 29, 6, 74, 0, 50, 110, 0, 0, 2, 0, 0, 0);
        this.CreateGloves(20, "Thunder Hawk Gloves", 88, 34, 7, 82, 0, 150, 70, 0, 0, 0, 1, 0, 0);
        this.CreateGloves(21, "Great Dragon Gloves", 94, 48, 6, 86, 0, 200, 58, 0, 2, 0, 0, 0, 0);

        // Boots:
        this.CreateBoots(0, 6, 2, 2, "Bronze Boots", 12, 4, 10, 34, 80, 20, 0, 1, 0);
        this.CreateBoots(1, 6, 2, 2, "Dragon Boots", 54, 15, 2, 68, 120, 30, 0, 1, 0);
        this.CreateBoots(2, 6, 2, 2, "Pad Boots", 4, 3, 10, 28, 20, 0, 1, 0, 0);
        this.CreateBoots(3, 6, 2, 2, "Legendary Boots", 46, 12, 0, 42, 30, 0, 1, 0, 0);
        this.CreateBoots(4, 6, 2, 2, "Bone Boots", 16, 6, 6, 30, 30, 0, 1, 0, 0);
        this.CreateBoots(5, 6, 2, 2, "Leather Boots", 5, 2, 12, 30, 80, 0, 0, 1, 0);
        this.CreateBoots(6, 6, 2, 2, "Scale Boots", 22, 8, 8, 40, 110, 0, 0, 1, 0);
        this.CreateBoots(7, 6, 2, 2, "Sphinx Boots", 30, 9, 8, 36, 30, 0, 1, 0, 0);
        this.CreateBoots(8, 6, 2, 2, "Brass Boots", 32, 10, 6, 44, 100, 30, 0, 1, 0);
        this.CreateBoots(9, 6, 2, 2, "Plate Boots", 42, 12, 4, 50, 130, 0, 0, 1, 0);
        this.CreateBoots(10, 6, 2, 2, "Vine Boots", 5, 2, 0, 22, 30, 60, 0, 0, 1);
        this.CreateBoots(11, 6, 2, 2, "Silk Boots", 15, 4, 0, 26, 30, 70, 0, 0, 1);
        this.CreateBoots(12, 6, 2, 2, "Wind Boots", 27, 7, 0, 32, 30, 80, 0, 0, 1);
        this.CreateBoots(13, 6, 2, 2, "Spirit Boots", 40, 10, 0, 38, 40, 80, 0, 0, 1);
        this.CreateBoots(14, 6, 2, 2, "Guardian Boots", 52, 16, 0, 45, 40, 80, 0, 0, 1);
        this.CreateBoots(15, 6, 2, 2, "Storm Crow Boots", 72, 22, 2, 80, 0, 150, 70, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0);
        this.CreateBoots(16, 6, 2, 2, "Black Dragon Boots", 78, 24, 2, 74, 0, 170, 60, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0);
        this.CreateBoots(17, 6, 2, 2, "Dark Phoenix Boots", 93, 40, 2, 80, 0, 198, 60, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0);
        this.CreateBoots(18, 6, 2, 2, "Grand Soul Boots", 76, 22, 0, 67, 0, 59, 10, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0);
        this.CreateBoots(19, 6, 2, 2, "Divine Boots", 81, 30, 0, 74, 0, 50, 110, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0);
        this.CreateBoots(20, 6, 2, 2, "Thunder Hawk Boots", 92, 37, 2, 82, 0, 150, 70, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0);
        this.CreateBoots(21, 6, 2, 2, "Great Dragon Boots", 98, 50, 0, 86, 0, 200, 58, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0);

        this.BuildSets();
    }
}