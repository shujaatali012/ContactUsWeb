/// <summary>
/// Message Type Entity
/// </summary>

namespace WebApp.DataAccess.Entities
{
    #region namespace
    
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    #endregion

    public class MessageType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Type is required")]
        [StringLength(20, ErrorMessage = "Type must be maximum 20 characters")]
        public string Type { get; set; }
        
        [Required]
        public DateTime CreateDate { get; set; }
    }
}
