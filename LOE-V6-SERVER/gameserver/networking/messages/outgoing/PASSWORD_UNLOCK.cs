﻿#region

using core;

#endregion

namespace gameserver.networking.outgoing
{
    public class PASSWORD_UNLOCK : OutgoingMessage
    {
        public const int SIGN_IN = 2;
        public const int SEND_EMAIL_AND_SIGN_IN = 3;
        public const int REGISTER = 4;

        public int CleanPasswordStatus { get; set; }

        public override MessageID ID => MessageID.PASSWORD_UNLOCK;

        public override Message CreateInstance() => new PASSWORD_UNLOCK();

        protected override void Read(NReader rdr)
        {
            CleanPasswordStatus = rdr.ReadInt32();
        }

        protected override void Write(NWriter wtr)
        {
            wtr.Write(CleanPasswordStatus);
        }
    }
}
