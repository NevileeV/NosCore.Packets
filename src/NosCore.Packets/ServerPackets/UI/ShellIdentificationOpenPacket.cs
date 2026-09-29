using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI;

[PacketHeader("guri", Scope.InGame)]
public sealed class ShellIdentificationOpenPacket : PacketBase
{
    [PacketIndex(0)]
    public GuriPacketType Type => GuriPacketType.PerfumAndIdentification;

    [PacketIndex(1)]
    public uint Argument => 0;
}
