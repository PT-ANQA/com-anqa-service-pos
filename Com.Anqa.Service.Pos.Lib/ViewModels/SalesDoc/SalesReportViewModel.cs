using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Anqa.Service.Pos.Lib.ViewModels.SalesDoc
{
    public class SalesReportViewModel
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemArticleRealizationOrder { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double Discount1 { get; set; }
        public double Discount2 { get; set; }
        public double Discount { get; set; }
        public double DiscountNominal { get; set; }
        public double SpecialDiscount { get; set; }
        public double Total { get; set; }
        public string IsReturn { get; set; }
        public string Remark { get; set; }
        public string PaymentType { get; set; }
        public string BankName { get; set; }
        public string Card { get; set; }
        public double Margin { get; set; }
        public double GrandTotal { get; set; }
        public double SubTotal { get; set; }
        public string Date { get; set; }
        public string StoreCode { get; set; }
        public string StoreName { get; set; }
       
        public string Code { get; set; }
        public string _CreatedUtc { get; set; }
        public string Style { get; set; }
        public string Group { get; set; }
    }
}
