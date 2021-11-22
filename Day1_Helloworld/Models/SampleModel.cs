using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day1_Helloworld.Models
{
    public class SampleModel
    {
        
        public int SampleId { get; set; }
        [Required(ErrorMessage = "Test Name is always mandatory")]
        public string TestName { get; set; }
        
        public  string  SampleResult { get; set; }
        public int RequestId { get; set; }

        [RegularExpression("[0-9a-zA-Z]+",ErrorMessage ="Allowed Only Non-Special Characters")]
        public string PlainText { get; set; }
        /// <summary>
        /// retrieve the samples from DB
        /// </summary>
        /// <returns></returns>
        public List<SampleModel> GetSampleModels()
        {
            List<SampleModel> sampleModels = new List<SampleModel>();

            //cooking some logic
            SampleModel sampleModel = new SampleModel();
            sampleModel.RequestId = 101;
            sampleModel.SampleId = 501;
            sampleModel.SampleResult = "Positive";
            sampleModel.TestName = "Covid";

            SampleModel sampleModel2 = new SampleModel();
            sampleModel2.RequestId = 102;
            sampleModel2.SampleId = 502;
            sampleModel2.SampleResult = "Negative";
            sampleModel2.TestName = "Malaria";

            sampleModels.Add(sampleModel);
            sampleModels.Add(sampleModel2);

            return sampleModels;
        }
    }
}