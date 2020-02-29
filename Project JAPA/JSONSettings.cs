using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_JAPA
{
    class CompanionSettings
    {
        public int volume { get; set; }
        public int speed { get; set; }
        public int randomWaitToRespondMaxMs { get; set; }
    }
    class LogSettings
    {
        public string logDirectory { get; set; }
        public bool logConversations { get; set; }
    }
    class JSONSettings
    {
        public bool textMode { get; set; }
        public bool silentMode { get; set; }
        public bool disableChatBot { get; set; }
        public bool startAutomatically { get; set; }
        public bool hideWhenMinimized { get; set; }
        public string name { get; set; }
        public CompanionSettings companionSettings = new CompanionSettings
        {
            randomWaitToRespondMaxMs = 0,
            volume = 100,
            speed = 1
        };
        public LogSettings logSettings = new LogSettings 
        { 
            logConversations = true, 
            logDirectory = "" 
        };
    }
}
