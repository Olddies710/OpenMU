// <copyright file="DataInitialization.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Version097d;

using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Extensions.Logging;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Network.PlugIns;
using MUnique.OpenMU.Persistence.Initialization.Version075.TestAccounts;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Data initialization plugin for Version 0.97d.
/// </summary>
[Guid("5B6F49E7-1C2D-4A6B-9C11-5E4D3F2A0B8C")]
[PlugIn("Version 0.97d Initialization", "Provides initial data for Version 0.97d")]
public class DataInitialization : DataInitializationBase
{
    public DataInitialization(IPersistenceContextProvider persistenceContextProvider, ILoggerFactory loggerFactory)
        : base(persistenceContextProvider, loggerFactory)
    {
    }

    public static string Id => "0.97d";

    public override string Key => Id;

    public override string Caption => "0.97d";

    protected override IInitializer GameConfigurationInitializer => new GameConfigurationInitializer(this.Context, this.GameConfiguration);

    protected override IGameMapsInitializer GameMapsInitializer => new GameMapsInitializer(this.Context, this.GameConfiguration);

    protected override IInitializer? TestAccountsInitializer => new TestAccountsInitialization(this.Context, this.GameConfiguration);

    protected override void CreateGameClientDefinition()
    {
        var version097Definition = this.Context.CreateNew<GameClientDefinition>();
        version097Definition.SetGuid(97);
        version097Definition.Season = 0;
        version097Definition.Episode = 97;
        version097Definition.Language = ClientLanguage.English;

        // Placeholder bytes for the client version — replace with official bytes for 0.97d if available.
        version097Definition.Version = new byte[] { 0x30, 0x39, 0x37, 0x30, 0x34 };

        // Placeholder serial — replace with the official 0.97d serial if you have it.
        version097Definition.Serial = Encoding.ASCII.GetBytes("TbYehR2hFUPBKgZj");
        version097Definition.Description = "Version 0.97d Client";
    }
}