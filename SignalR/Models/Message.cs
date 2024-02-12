namespace SignalR.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageText { get; set; }
        public string UserName { get; set; }
        public DateTime MessageDate { get; set; } = DateTime.Now;
    }
}
