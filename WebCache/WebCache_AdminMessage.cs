namespace Shoko.Models.WebCache
{
    public class WebCache_AdminMessage
    {
        public int AdminMessageId { get; set; }
        public long MessageDate { get; set; }
        public int MessageType { get; set; }
        public string Message { get; set; }
        public string MessageURL { get; set; }
        public string Self { get; set; }
    }
}