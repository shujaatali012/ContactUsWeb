/// <summary>
/// input model validator (custom and generic) 
/// </summary>

namespace WebApp.Host.Helper
{
    #region import namespaces
    
    using WebApp.Host.Models;

    #endregion

    public static class Validator
    {
        public static bool validate(ContactUsModel model)
        {
            bool result = true;

            // required field validator
            if (string.IsNullOrEmpty(model.Name))
                result = false;
            if (string.IsNullOrEmpty(model.Email))
                result = false;
            if (string.IsNullOrEmpty(model.Mobile))
                result = false;
            if (string.IsNullOrEmpty(model.MessageTypeId.ToString()) || model.MessageTypeId.ToString() == "0")
                result = false;
            if (string.IsNullOrEmpty(model.Message))
                result = false;

            // TODO implement more server side validations here

            // email regular expression validator

            // mobile regular expression validator
            
            return result;
        }
    }
}