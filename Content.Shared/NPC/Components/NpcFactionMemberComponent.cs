using Content.Shared.NPC.Prototypes;
using Content.Shared.NPC.Systems;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Content.Shared.Mech.EntitySystems; // Frontier

namespace Content.Shared.NPC.Components;

[RegisterComponent, NetworkedComponent, Access(typeof(NpcFactionSystem), typeof(SharedMechSystem))] // Frontier - Added MechSystem
public sealed partial class NpcFactionMemberComponent : Component
{
    /// <summary>
    /// Factions this entity is a part of.
    /// </summary>
    [DataField]
    public HashSet<ProtoId<NpcFactionPrototype>> Factions = new();

    /// <summary>
    /// Cached friendly factions.
    /// </summary>
    [ViewVariables]
    public readonly HashSet<ProtoId<NpcFactionPrototype>> FriendlyFactions = new();

    /// <summary>
    /// Cached hostile factions.
    /// </summary>
    [ViewVariables]
    public readonly HashSet<ProtoId<NpcFactionPrototype>> HostileFactions = new();
}
