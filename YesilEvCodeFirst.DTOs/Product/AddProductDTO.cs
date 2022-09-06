﻿namespace YesilEvCodeFirst.DTOs.Product
{
    public class AddProductDTO
    {
        // todo: dto'larda da attribute olmali
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public int? CategoryID { get; set; }
        public int? SupplierID { get; set; }
        public string ProductContent { get; set; }
        public string PictureFronthPath { get; set; }
        public string PictureBackPath { get; set; }
        public string PictureContentPath { get; set; }
        public int AddedBy { get; set; }

    }
}
