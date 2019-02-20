namespace KibanaPdfConverter
{
    public class Email
    {
        public string to { get; set; }
        public string subject { get; set; }

        public Attachments attachments = new Attachments();

    }

    public class Attachments
    {
        public Dashboard dashboard = new Dashboard();
    }
}