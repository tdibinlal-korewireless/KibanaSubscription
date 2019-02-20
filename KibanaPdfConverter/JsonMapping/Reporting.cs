namespace KibanaPdfConverter
{
    public class Reporting
    {
        public string url { get; set; }
        public int retries { get; set; }
        public string interval { get; set; }
        public Auth auth = new Auth();

    }
}