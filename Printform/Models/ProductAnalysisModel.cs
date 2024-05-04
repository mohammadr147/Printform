using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Printform.Models
{
    public class ProductAnalysisModel
    {
        [DisplayName("شماره ثبت آزمایشگاه:")]
        public string LabRegistrationNumber { get; set; }
        [DisplayName("شماره ثبت محصول:")]
        public string ProductRegistrationNumber { get; set; }
        [DisplayName("کد نمونه:")]
        public string SampleCode { get; set; }
        [DisplayName("شماره سند:")]
        public string DocumentNumber { get; set; }
        [DisplayName("تاریخ دریافت نمونه:")]
        public DateTime SampleReceiptDate { get; set; }
        [DisplayName("وزن نمونه:")]
        public double SampleWeight { get; set; }
        [DisplayName("تاریخ اتمام آزمون:")]
        public DateTime TestCompletionDate { get; set; }
        [DisplayName("محصول:")]
        public string ProductType { get; set; }
    }
}
