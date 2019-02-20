namespace KibanaPdfConverter
{
    public class Actions
    {
        public Send_Email send_email = new Send_Email();
        public class Send_Email
        {
            public Email email = new Email();
        }
    }
}