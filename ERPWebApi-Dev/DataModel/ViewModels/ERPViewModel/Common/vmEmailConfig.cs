namespace DataModel.ViewModels
{
    public class vmEmailConfig
    {
        public string EmailSenderId { get; set; }
        public string EmailSenderPassword { get; set; }
        public bool EmailSenderEnableSsl { get; set; }
        public string EmailSenderHost { get; set; }
        public int EmailSenderPort { get; set; }
        public string SenderTitle { get; set; }
        public string RootPath { get; set; }
    }
}
