using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Anqa.Service.Pos.Lib.ViewModels.SalesDoc
{
    public class SalesReportViewModel
    {
        public string ItemCode { get; set; }
        public string Brand { get; set; }
        public string Date { get; set; }
        public string Category { get; set; }
        public string Collection { get; set; }
        public string SeasonCode { get; set; }
        public string SeasonYear { get; set; }
        public string ItemArticleRealizationOrder { get; set; }
        public string ItemName { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double Quantity { get; set; }
        public string Location { get; set; }
        public double OriginalCost { get; set; }
        public double Gross { get; set; }
        public double Nett { get; set; }
        public double Discount1 { get; set; }
        public double Discount2 { get; set; }
        public double DiscountNominal { get; set; }
        public double SpecialDiscount { get; set; }
        public double TotalOriCost { get; set; }
        public double TotalGross { get; set; }
        public double TotalNett { get; set; }
        public double Margin { get; set; }
    }
}
