using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorChatSample.Shared
{
    public class ChatModel
    {
        public string GroupName { get; set; }
        public string Nickname { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
    }
}
