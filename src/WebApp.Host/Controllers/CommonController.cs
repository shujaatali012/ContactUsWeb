/// <summary>
/// CommonController Implementation
/// </summary>

namespace WebApp.Host.Controllers
{
    #region import namespaces

    using System;
    using System.IO;
    using System.Web;
    using System.Web.Mvc;

    #endregion

    public class CommonController : Controller
    {
        public ActionResult UploadFiles()
        {
            string FileName = String.Empty;

            try
            {
                HttpFileCollectionBase files = Request.Files;

                if (files.Count > 0)
                {
                    for (int i = 0; i < files.Count; i++)
                    {
                        HttpPostedFileBase file = files[i];

                        FileInfo fileInfo = new FileInfo(file.FileName);
                        string extension = fileInfo.Extension;

                        string fileName = Guid.NewGuid() + extension;
                        FileName = fileName;

                        fileName = Path.Combine(Server.MapPath("~/Uploads/"), fileName);
                        file.SaveAs(fileName);
                    }

                    return Json(new { success = true, message = FileName }, JsonRequestBehavior.AllowGet);
                }

                return Json(new { success = false, message = "No file attached" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
