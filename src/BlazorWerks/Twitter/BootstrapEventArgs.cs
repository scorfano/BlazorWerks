#nullable disable

using System;

namespace BlazorWerks.Twitter
{
    public class BootstrapEventArgs : EventArgs
    {
        // Original Event
        public bool? IsTrusted { get; set; }
        public string EventType { get; set; }
        public double TimeStamp { get; set; }

        // Target
        public string Id { get; set; }
        public string ClassName { get; set; }
        public string TagName { get; set; }

        // carousel events only
        public string Direction { get; set; }
        public int? From { get; set; }
        public int? To { get; set; }
    }
}
