#nullable disable

using System;

namespace BlazorWerks.WebStorage
{
    public class StorageEventArgs : EventArgs
    {
        // Event Properties
        public bool? IsTrusted { get; set; }
        public string EventType { get; set; }
        public double TimeStamp { get; set; }
        // Storage Properties
        public string Key { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string Url { get; set; }
        public string StorageArea { get; set; }
    }
}
