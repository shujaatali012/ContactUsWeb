/// <summary>
/// Contact us repository implementation
/// </summary>

namespace WebApp.DataAccess.Repositories
{
    #region import namepsaces
    
    using WebApp.DataAccess.Entities;
    using WebApp.DataAccess.Repositories.Interfaces;
    using WebApp.DataAccess.Database;

    #endregion

    public class ContactUsRepository : IContactUsRepository
    {
        #region properties
        
        private WebAppDataContext _context;

        #endregion

        #region constructor(s)

        public ContactUsRepository()
        {
            _context = new WebAppDataContext();
        }
        
        #endregion

        #region methods

        public void Add(ContactUs contactUs)
        {
            _context.ContactUs.Add(contactUs);
            _context.SaveChanges();
        }

        #endregion
    }
}
