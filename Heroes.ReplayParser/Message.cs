using System;

namespace Heroes.ReplayParser
{
    public class Message
    {
        public Player MessageSender { get; set; }
        public int PlayerIndex { get; set; }
        public TimeSpan Timestamp { get; set; }
        public ReplayMessageEvents.MessageEventType MessageEventType { get; set; }
        public ReplayMessageEvents.ChatMessage ChatMessage { get; set; }
        public ReplayMessageEvents.PingMessage PingMessage { get; set; }
        public ReplayMessageEvents.PlayerAnnounceMessage PlayerAnnounceMessage { get; set; }

        public override string ToString()
        {
            if (ChatMessage != null)
            {
                if (MessageSender == null)
                    // I've seen this in at least one replay, and I think it happens right before or after a player is disconnecting or reconnecting
                    return string.Format("({0}) [{1}] ((Unknown)): {2}", Timestamp, ChatMessage.MessageTarget,
                        ChatMessage.Message);
                else if (!string.IsNullOrEmpty(MessageSender.Character))
                    return string.Format("({0}) [{1}] {2} ({3}): {4}", Timestamp, ChatMessage.MessageTarget,
                        MessageSender.Name, MessageSender.Character, ChatMessage.Message);
                else
                    return string.Format("({0}) [{1}] {2}: {3}", Timestamp, ChatMessage.MessageTarget,
                        MessageSender.Name, ChatMessage.Message);
            }
            else if (PingMessage != null)
            {
                if (MessageSender == null)
                    // I've seen this in at least one replay, and I think it happens right before or after a player is disconnecting or reconnecting
                    return string.Format("({0}) [{1}] ((Unknown)) used a ping", Timestamp, PingMessage.MessageTarget);
                else if (!string.IsNullOrEmpty(MessageSender.Character))
                    return string.Format("({0}) [{1}] {2} ({3}) used a ping", Timestamp, PingMessage.MessageTarget,
                        MessageSender.Name, MessageSender.Character);
                else
                    return string.Format("({0}) [{1}] {2} used a ping", Timestamp, PingMessage.MessageTarget,
                        MessageSender.Name);
            }
            else if (PlayerAnnounceMessage != null)
            {
                if (MessageSender == null)
                    // I've seen this in at least one replay, and I think it happens right before or after a player is disconnecting or reconnecting
                    return string.Format("({0}) ((Unknown)) announced {1}", Timestamp,
                        PlayerAnnounceMessage.AnnouncementType);
                else if (!string.IsNullOrEmpty(MessageSender.Character))
                    return string.Format("({0}) {1} ({2}) announced {3}", Timestamp, MessageSender.Name,
                        MessageSender.Character, PlayerAnnounceMessage.AnnouncementType);
                else
                    return string.Format("({0}) {1} announced {2}", Timestamp, MessageSender.Name,
                        PlayerAnnounceMessage.AnnouncementType);
            }
            else
                return base.ToString();
        }
    }
}