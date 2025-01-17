﻿namespace YesilEvCodeFirst.DTOs.Product
{
    public class GetProductDetailDTO
    {
        public int ProductID { get; set; }
        public string Barcode { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public string SupplierName { get; set; }
        public int? CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string ProductContent { get; set; }
        public string PictureContentPath { get; set; }
        public string PictureFronthPath { get; set; }
        public string PictureBackPath { get; set; }
        public int AddedBy { get; set; }
    }
}
