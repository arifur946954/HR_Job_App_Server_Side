using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels.ERPViewModel.Business
{
    public class vmProduct
    {
        public int? ItemId { get; set; }
        public string ItemName { get; set; }
        public int? TypeId { get; set; }
        public int? SubCategoryId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }

    public class vmProductType
    {
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }

    public class vmProductCategory
    {
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }

    public class vmProductSubCategory
    {
        public int? SubCategoryId { get; set; }
        public int? CategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
    //for test purpose
    public class ApiResponse
    {
        public int ResponseCode { get; set; }
        public decimal docId { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        public List<decimal> Data { get; set; }

    }
}
