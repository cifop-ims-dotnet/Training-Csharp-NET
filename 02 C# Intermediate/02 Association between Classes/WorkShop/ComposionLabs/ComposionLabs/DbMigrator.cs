using System;

namespace ComposionLabs
{
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log($"Migrate starts {DateTime.Now}");
            //......
            Console.WriteLine("Setup Done");
            _logger.Log($"Migrate ends {DateTime.Now}");
        }
    }
}
