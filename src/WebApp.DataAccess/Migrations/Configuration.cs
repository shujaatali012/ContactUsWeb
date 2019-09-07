/// <summary>
/// Database Migration Configuration
/// </summary>

namespace WebApp.DataAccess.Migrations
{
    
    #region import namespaces
    
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using WebApp.DataAccess.Entities;

    #endregion

    internal sealed class Configuration : DbMigrationsConfiguration<Database.WebAppDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Database.WebAppDataContext context)
        {
            IList<MessageType> messageTypes = new List<MessageType>();

            messageTypes.Add(new MessageType() { Type = "Feedback", CreateDate = DateTime.Now });
            messageTypes.Add(new MessageType() { Type = "Question", CreateDate = DateTime.Now });

            context.MessageTypes.AddRange(messageTypes);

            base.Seed(context);
        }
    }
}
