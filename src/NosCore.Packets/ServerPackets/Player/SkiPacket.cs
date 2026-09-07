//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    // The leading zero is part of the current client wire format. Omitting it shifts both
    // basic-skill fields and makes the client hide them from the skill window.
    [PacketHeader("ski", Scope.InGame)]
    public class SkiPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Unknown { get; set; }

        [PacketIndex(1)]
        public short PrimarySkillVnum { get; set; }

        [PacketIndex(2)]
        public short SecondarySkillVnum { get; set; }

        [PacketListIndex(3, ListSeparator = " ", IsOptional = true)]
        public List<short>? SkillVnums { get; set; }
    }
}
