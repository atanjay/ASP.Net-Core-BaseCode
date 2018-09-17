﻿namespace Data.Configurations
{
    public class EmailConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FromAddress { get; set; }
        public string FromDisplayName { get; set; }
        public string AdminMl { get; set; }
    }
}