using System.ComponentModel;

namespace Printform.Models
{
    public class AnalysisFormModel
    {

        [DisplayName("وزن اولیه")]
        public string SeedPureWeight { get; set; }

        [DisplayName("وزن مجموع اجزاء خلوص فیزیکی")]
        public string WeightOfTotalImpurityComponents { get; set; }

        [DisplayName("درصد کاهش افزایش")]
        public string SeedPurityPercentageReduction { get; set; }
        [DisplayName("درصد وزنی اجرا")]
        public string WidthPercentageReduction { get; set; }

        [DisplayName("آرمون شمارش بذور")]
        public string ArmonSeedCount { get; set; }

        [DisplayName("آزمون خلوص فیزیکی ")]
        public string SeedTestType { get; set; }

        [DisplayName("وزن")]
        public string Weight { get; set; }

        [DisplayName("درصد خلوص فیزیکی")]
        public string PercentageWeightOfComponents { get; set; }

        [DisplayName("سایر بذور در آرمون خلوص")]
        public string OtherProductAndVarietySeedType { get; set; }

        [DisplayName("نوع بذر سایر محصولات و ارقام")]
        public string OtherProductAndVarietySeedTypeCount { get; set; }

        [DisplayName("نوع بذر علف هرز")]
        public string WeedSeedType { get; set; }

        [DisplayName("تعداد")]
        public string WeedSeedTypeCount { get; set; }

        [DisplayName("نوع بذر سایر محصولات و ارقام")]
        public string SolidMaterialsType { get; set; }

        [DisplayName("تعداد")]
        public string SolidMaterialsTypeCount { get; set; }

        [DisplayName("مجموع")]
        public string Total { get; set; }

        [DisplayName("مواد جامد ")]
        public string SolidMaterialType { get; set; }

        [DisplayName("تعداد مواد جامد")]
        public string SolidMaterialTypeCount { get; set; }
    }
}
