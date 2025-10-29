csharp Persistence/Initialization/Version097d/CharacterClassInitialization.cs
namespace MUnique.OpenMU.Persistence.Initialization.Version097d;

using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.CharacterClasses;

/// <summary>
/// Character class initialization for 0.97d (includes 2nd evolution classes).
/// </summary>
internal class CharacterClassInitialization : Initialization.CharacterClasses.CharacterClassInitialization
{
    public CharacterClassInitialization(IContext context, GameConfiguration gameConfiguration)
        : base(context, gameConfiguration)
    {
    }

    /// <inheritdoc />
    protected override bool UseClassicPvp => true;

    /// <inheritdoc />
    public override void Initialize()
    {
        // Create second-evolution classes (no master classes)
        var bladeKnight = this.CreateDarkKnight(CharacterClassNumber.BladeKnight, "Blade Knight", false, null, false);
        var soulMaster = this.CreateDarkWizard(CharacterClassNumber.SoulMaster, "Soul Master", false, null, false);
        var museElf = this.CreateFairyElf(CharacterClassNumber.MuseElf, "Muse Elf", false, null, false);

        // Create first-evolution classes and link to their 2nd evolutions
        this.CreateDarkKnight(CharacterClassNumber.DarkKnight, "Dark Knight", false, bladeKnight, true);
        this.CreateDarkWizard(CharacterClassNumber.DarkWizard, "Dark Wizard", false, soulMaster, true);
        this.CreateFairyElf(CharacterClassNumber.FairyElf, "Fairy Elf", false, museElf, true);
    }
}