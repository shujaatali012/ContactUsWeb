/// <summary>
/// Contact Us Model
/// </summary>

namespace WebApp.Host.Models
{
    #region namespace
    
    using System;

    #endregion

    public class ContactUsModel
    {
        public Guid Id { get; set; }

        //[Required]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public int MessageTypeId { get; set; }

        public string Message { get; set; }

        public string FilePath { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
