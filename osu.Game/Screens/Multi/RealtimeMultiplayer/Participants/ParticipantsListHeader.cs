// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Game.Online.RealtimeMultiplayer;
using osu.Game.Screens.Multi.Components;

namespace osu.Game.Screens.Multi.RealtimeMultiplayer.Participants
{
    public class ParticipantsListHeader : OverlinedHeader
    {
        [Resolved]
        private StatefulMultiplayerClient client { get; set; }

        public ParticipantsListHeader()
            : base("Participants")
        {
        }

        protected override void Update()
        {
            base.Update();

            var room = client.Room;
            if (room == null)
                return;

            Details.Value = room.Users.Count.ToString();
        }
    }
}
