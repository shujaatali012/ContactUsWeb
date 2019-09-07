/// <summary>
/// Message Type repository implementation
/// </summary>

namespace WebApp.DataAccess.Repositories
{
    #region import namepsaces
    
    using WebApp.DataAccess.Entities;
    using WebApp.DataAccess.Repositories.Interfaces;
    using WebApp.DataAccess.Database;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    public class MessageTypeRepository : IMessageTypeRepository
    {
        #region properties
        
        private WebAppDataContext _context;

        #endregion

        #region constructor(s)

        public MessageTypeRepository()
        {
            _context = new WebAppDataContext();
        }
        
        #endregion

        #region methods

        public List<MessageType> GetAll()
        {
            return _context.MessageTypes.ToList();
        }

        #endregion
    }
}
