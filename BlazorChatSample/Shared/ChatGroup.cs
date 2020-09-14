using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorChatSample.Shared
{
    public class ChatGroup
    {
        public string GroupName { get; set; }
        public string LastMessage { get; set; }
        public List<ChatModel> Messages { get; set; } = new List<ChatModel>();
    }
}
