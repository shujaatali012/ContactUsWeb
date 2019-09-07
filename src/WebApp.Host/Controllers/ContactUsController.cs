/// <summary>
/// ContactUsController Implementation
/// </summary>

namespace WebApp.Host.Controllers
{
    #region namespaces

    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using WebApp.DataAccess.Entities;
    using WebApp.DataAccess.Repositories.Interfaces;
    using WebApp.Host.Helper;
    using WebApp.Host.Helper.Enums;
    using WebApp.Host.Models;

    #endregion

    public class ContactUsController : Controller
    {
        #region properties

        private readonly IContactUsRepository _contactUsRepository;
        private readonly IMessageTypeRepository _messageTypeRepository;

        #endregion

        #region constructor(s)

        public ContactUsController(IContactUsRepository contactUsRepository,
            IMessageTypeRepository messageTypeRepository)
        {
            _contactUsRepository = contactUsRepository;
            _messageTypeRepository = messageTypeRepository;
        }

        #endregion

        #region methods

        public ActionResult Index()
        {
            ViewBag.Title = "Contact Us - WebApp";

            return View();
        }

        [HttpGet]
        public ActionResult GetMessageTypes()
        {
            try
            {
                var result = _messageTypeRepository.GetAll();

                var messageTypes = new List<KeyValuePair<int, string>>();

                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        messageTypes.Add(new KeyValuePair<int, string>(item.Id, item.Type));
                    }
                }

                return Json(new { success = true, data = messageTypes }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { success = false, data = "Unable to get message types, please try again later." }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult SaveContact([System.Web.Http.FromBody] ContactUsModel model)
        {
            if (model == null)
                throw new ArgumentNullException();

            if (Validator.validate(model))
            {

                try
                {
                    // model mapping (TODO: use automapper here)
                    ContactUs mappedModel = new ContactUs
                    {
                        Id = Guid.NewGuid(),
                        Name = model.Name,
                        Email = model.Email,
                        Mobile = model.Mobile,
                        MessageTypeId = model.MessageTypeId,
                        Message = model.Message,
                        FilePath = model.FilePath,
                        CreateDate = DateTime.Now
                    };

                    _contactUsRepository.Add(mappedModel);

                    return Json(new { success = true }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception)
                {
                    return Json(new { success = false, message = "Unable to save, please try again later." }, JsonRequestBehavior.AllowGet);
                }

            }

            return Json(new { success = false, message = "Unable to save, please try again later." }, JsonRequestBehavior.AllowGet);
        }

        #endregion
    }
}
