// <copyright file="EventTicketItems.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d.Items;

using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.DataModel.Configuration.Items;
using MUnique.OpenMU.Persistence.Initialization;
using MUnique.OpenMU.Persistence.Initialization.Maps;

/// <summary>
/// Initializer for event related items.
/// </summary>
internal class EventTicketItems : InitializerBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EventTicketItems"/> class.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="gameConfiguration">The game configuration.</param>
    public EventTicketItems(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }

    /// <inheritdoc />
    public override void Initialize()
    {
        // Blood Castle (6 stages in 0.97d)
        this.CreateEventItem(16, 13, 1, 2, "Scroll of Archangel", false, 6, 2, 32, 45, 57, 68, 76);
        this.CreateEventItem(17, 13, 1, 2, "Blood Bone", false, 6, 2, 32, 45, 57, 68, 76);
        this.CreateEventItem(18, 13, 2, 2, "Cloak of Invisibility", false, 0, 8);
        this.CreateEventItem(19, 13, 1, 2, "Divine Weapon of Archangel", false);

        // Chaos Castle
        this.CreateEventItem(29, 13, 2, 2, "Armor of Guardsman", false);

        // Devil Square (4 invitations as in 0.95d)
        this.CreateEventItem(17, 14, 1, 1, "Devil's Eye", false, 4, 2, 36, 47, 60);
        this.CreateEventItem(18, 14, 1, 1, "Devil's Key", false, 4, 2, 36, 47, 60);
        this.CreateEventItem(19, 14, 1, 1, "Devil's Invitation", false, 4);
    }

    private ItemDefinition CreateEventItem(byte number, byte group, byte width, byte height, string name, bool dropsFromMonsters, byte maxItemLevel = 0, params byte[] dropLevels)
    {
        var item = this.Context.CreateNew<ItemDefinition>();
        this.GameConfiguration.Items.Add(item);
        item.Group = group;
        item.Number = number;
        item.Name = name;
        item.Width = width;
        item.Height = height;
        item.Durability = 1;
        item.DropsFromMonsters = dropsFromMonsters;
        item.MaximumItemLevel = maxItemLevel;
        item.SetGuid(item.Group, item.Number);

        if (dropLevels.Length == 0)
        {
            return item;
        }

        if (dropLevels.Length == 1)
        {
            item.DropLevel = dropLevels[0];
            return item;
        }

        byte itemLevel = 1;
        DropItemGroup? previousGroup = null;
        foreach (var dropLevel in dropLevels)
        {
            if (previousGroup is { })
            {
                previousGroup.MaximumMonsterLevel = (byte)(dropLevel - 1);
            }

            var dropItemGroup = this.Context.CreateNew<DropItemGroup>();
            dropItemGroup.ItemLevel = itemLevel;
            dropItemGroup.Chance = 0.01;
            dropItemGroup.Description = $"{name}+{itemLevel}";
            dropItemGroup.PossibleItems.Add(item);
            dropItemGroup.MinimumMonsterLevel = dropLevel;
            this.GameConfiguration.DropItemGroups.Add(dropItemGroup);
            BaseMapInitializer.RegisterDefaultDropItemGroup(dropItemGroup);

            previousGroup = dropItemGroup;
            itemLevel++;
        }

        return item;
    }
}
