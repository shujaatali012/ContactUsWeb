/// <summary>
/// Contact Us Entity
/// </summary>

namespace WebApp.DataAccess.Entities
{
    #region namespace
    
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    #endregion

    public class ContactUs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name must be maximum 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Please enter valid email address")]
        [StringLength(50, ErrorMessage = "Email must be maximum 50 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile is required")]
        [StringLength(11, ErrorMessage = "Mobile must be maximum 11 degits")]
        public string Mobile { get; set; }
                 
        [Required(ErrorMessage = "Message is required")]
        [StringLength(500, ErrorMessage = "Message must be maximum 500 characters")]
        public string Message { get; set; }

        [StringLength(200, ErrorMessage = "File path must be maximum 200 characters")]
        public string FilePath { get; set; }

        [ForeignKey("MessageType")]
        public int MessageTypeId { get; set; }

        public MessageType MessageType { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }
    }
}
