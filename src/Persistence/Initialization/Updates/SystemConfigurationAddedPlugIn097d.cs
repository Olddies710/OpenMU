// <copyright file="SystemConfigurationAddedPlugIn097d.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// This update adds the new <see cref="SystemConfiguration"/> with default settings
/// for version 0.97d.
/// </summary>
[PlugIn(PlugInName, PlugInDescription)]
[Guid("B7C3D2E9-23A4-4B5C-92E1-17B9F4C6E7A3")]
public class SystemConfigurationAddedPlugIn097d : SystemConfigurationAddedPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => Version097d.DataInitialization.Id;

    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.SystemConfigurationAdded097d;
}
