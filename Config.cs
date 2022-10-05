namespace MT_automation
{
    public static class Config
    {
        static Config()
        {
            Timeout = 30;
        }

        public static double Timeout { get; set; }
    }
}
