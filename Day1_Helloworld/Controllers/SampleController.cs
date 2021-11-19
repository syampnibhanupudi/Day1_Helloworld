using Day1_Helloworld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1_Helloworld.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            SampleModel sampleModel = new SampleModel();
            List<SampleModel> sampleModels = sampleModel.GetSampleModels();
            return View(sampleModels);
        }

        public ActionResult NewIndex()
        {
            SampleModel sampleModel = new SampleModel();
            List<SampleModel> sampleModels = sampleModel.GetSampleModels();
            sampleModel = sampleModels[1];
            return View(sampleModel);
        }

        public ActionResult DeleteSample(int id)
        {
            SampleModel sampleModel = new SampleModel();
            List<SampleModel> sampleModels = sampleModel.GetSampleModels();
            List<SampleModel> sampleModels1 = sampleModel.GetSampleModels();
            foreach (var item in sampleModels)
            {
                if(item.SampleId == id)
                {
                    sampleModels1.Remove(item);
                    //write db query for delete
                }
            } //LINQ 
            //var myitem = sampleModels.Where(t => t.SampleId == id);
            //sampleModels.Remove(myitem);
            return View("Index", sampleModels1);
        }
    }
}