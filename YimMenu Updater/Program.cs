﻿namespace YimUpdater
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainGUI());
            //Application.Run(new Download_Error());
        }
    }
}