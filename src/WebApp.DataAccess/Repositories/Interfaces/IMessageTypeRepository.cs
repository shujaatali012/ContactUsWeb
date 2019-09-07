
/// <summary>
/// MessageType repository decleration
/// </summary>

namespace WebApp.DataAccess.Repositories.Interfaces
{
    #region import namepsaces

    using System.Collections.Generic;
    using WebApp.DataAccess.Entities;

    #endregion

    public interface IMessageTypeRepository
    {
        List<MessageType> GetAll();
    }
}
