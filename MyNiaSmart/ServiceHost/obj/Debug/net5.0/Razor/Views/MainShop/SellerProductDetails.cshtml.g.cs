#pragma checksum "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12007b526847173b616f2b099727384bcf22a32e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainShop_SellerProductDetails), @"mvc.1.0.view", @"/Views/MainShop/SellerProductDetails.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\_ViewImports.cshtml"
using ServiceHost.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
using _0_Framework.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12007b526847173b616f2b099727384bcf22a32e", @"/Views/MainShop/SellerProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c7b8880ea49463149f587326c9bcfc64cd7c9e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MainShop_SellerProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopManagement.Application.Contract.SellerProduct.SellerProductDetailsToShowViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
  
    ViewData["Title"] = "جرئیات محصول مربوط به فروشنده";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row page-titles mx-0"">
    <div class=""col-sm-6 p-md-0"">
        <div class=""welcome-text"">
            <h4>سلام، خوش آمدید</h4>
            <p class=""mb-0"">نمایش محصولات</p>
        </div>
    </div>
    <div class=""col-sm-6 p-md-0 justify-content-sm-end mt-2 mt-sm-0 d-flex"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""javascript:void(0)""> فروشگاه </a></li>
            <li class=""breadcrumb-item""><a href=""javascript:void(0)"">فروشگاه اصلی </a></li>
            <li class=""breadcrumb-item ""><a href=""javascript:void(0)"">جرئیات محصول</a></li>
            <li class=""breadcrumb-item active""><a href=""javascript:void(0)"">جرئیات محصول مربوط به فروشنده</a></li>
        </ol>
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-xl-3 "">
                        <!-- Tab panes -->
                        <d");
            WriteLiteral("iv class=\"tab-content\">\r\n");
#nullable restore
#line 32 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                             foreach (var item in Model.SelectedMedias.Where(x => x.IsMediaImage))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div role=\"tabpanel\" class=\"display tab-pane fade \"");
            BeginWriteAttribute("id", " id=\"", 1453, "\"", 1466, 1);
#nullable restore
#line 34 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
WriteAttributeValue("", 1458, item.Id, 1458, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1528, "\"", 1563, 2);
            WriteAttributeValue("", 1534, "/UploadedFiles/", 1534, 15, true);
#nullable restore
#line 35 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
WriteAttributeValue("", 1549, item.MediaURL, 1549, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1564, "\"", 1570, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n");
#nullable restore
#line 37 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"tab-slide-content new-arrival-product mb-4 mb-xl-0\">\r\n                            <!-- Nav tabs -->\r\n                            <ul class=\"nav slide-item-list mt-3\" role=\"tablist\">\r\n");
#nullable restore
#line 52 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                 foreach (var item in Model.SelectedMedias.Where(x => x.IsMediaImage))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li role=\"presentation\" class=\"show\">\r\n                                        <a href=\"#\" role=\"tab\" data-toggle=\"tab\">\r\n                                            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 2969, "\"", 3004, 2);
            WriteAttributeValue("", 2975, "/UploadedFiles/", 2975, 15, true);
#nullable restore
#line 56 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
WriteAttributeValue("", 2990, item.MediaURL, 2990, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3005, "\"", 3011, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"50\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3023, "\"", 3052, 3);
            WriteAttributeValue("", 3033, "toDisplay(", 3033, 10, true);
#nullable restore
#line 56 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
WriteAttributeValue("", 3043, item.Id, 3043, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3051, ")", 3051, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3053, "\"", 3066, 1);
#nullable restore
#line 56 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
WriteAttributeValue("", 3058, item.Id, 3058, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 59 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                    <!--Tab slider End-->
                    <div class=""col-xl-9 col-sm-12"">
                        <div class=""product-detail-content"">
                            <!--Product details-->
                            <div class=""new-arrival-content pr"">
                                <h4>");
#nullable restore
#line 78 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                               Write(Model.FarsiTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                <div class=""star-rating mb-2"">
                                    <ul class=""produtct-detail-tag"">
                                        <li><i class=""fa fa-star""></i></li>
                                        <li><i class=""fa fa-star""></i></li>
                                        <li><i class=""fa fa-star""></i></li>
                                        <li><i class=""fa fa-star""></i></li>
                                        <li><i class=""fa fa-star""></i></li>
                                    </ul>
                                    <span class=""review-text"">(34 نظر ) / </span><a class=""product-review"" href=""#"">نظری دارید؟</a>
                                </div>
                                <p class=""price"">");
#nullable restore
#line 89 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                            Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" تومان</p>
                                <p>
                                    دسترسی: <span class=""item"">
                                        در انبار <i class=""fa fa-shopping-basket""></i>
                                    </span>
                                </p>
                                <p>پارت نامبر:<span class=""item"">");
#nullable restore
#line 95 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                                            Write(Model.PartNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </p>\r\n                                <p>برند: <span class=\"item\">");
#nullable restore
#line 96 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                                       Write(Model.ProductBrandTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                <p>مدل: <span class=\"item\">");
#nullable restore
#line 97 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                                      Write(Model.ProductModelTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                <p>نوع: <span class=\"item\">");
#nullable restore
#line 98 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                                      Write(Model.ProductTypeTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                <p>وضعیت: <span class=\"item\">");
#nullable restore
#line 99 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                                        Write(Model.ProductStatusTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                <p>نحوه استفاده: <span class=\"item\">");
#nullable restore
#line 100 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                                               Write(Model.ProductUsageTypeTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                <p>کشور تولید کننده: <span class=\"item\">");
#nullable restore
#line 101 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                                                   Write(Model.CountryMadeIn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                <p> ابعاد: <span class=\"item\">");
#nullable restore
#line 102 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                                         Write(Model.Dimensions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                <p> وزن(کیلوگرم): <span class=\"item\">");
#nullable restore
#line 103 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                                                Write(Model.ProductWeight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                <p>\r\n                                    میزان گارانتی:\r\n");
#nullable restore
#line 106 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                     if (Model.WarrantyTypeId == WarrantyTypeId.Hour)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"item\">\r\n                                            ");
#nullable restore
#line 109 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                       Write(Model.WarrantyAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ساعت\r\n                                        </span>\r\n");
#nullable restore
#line 111 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                     if (Model.WarrantyTypeId == WarrantyTypeId.Day)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"item\">\r\n                                            ");
#nullable restore
#line 115 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                       Write(Model.WarrantyAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" روز\r\n                                        </span>\r\n");
#nullable restore
#line 117 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                     if (Model.WarrantyTypeId == WarrantyTypeId.Mounth)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"item\">\r\n                                            ");
#nullable restore
#line 121 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                       Write(Model.WarrantyAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ماه\r\n                                        </span>\r\n");
#nullable restore
#line 123 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                     if (Model.WarrantyTypeId == WarrantyTypeId.Year)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"item\">\r\n                                            ");
#nullable restore
#line 127 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                       Write(Model.WarrantyAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" سال\r\n                                        </span>\r\n");
#nullable restore
#line 129 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </p>\r\n                                <p>مدت زمان تحویل توی شهر: <span class=\"item\">");
#nullable restore
#line 131 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                                                         Write(Model.DeliveryDurationForCity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ساعت</span></p>\r\n                                <p>مدت زمان تحویل توی استان: <span class=\"item\">");
#nullable restore
#line 132 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                                                           Write(Model.DeliveryDurationForCapital);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ساعت</span></p>\r\n                                <p>مدت زمان تحویل به سایر نقاط: <span class=\"item\">");
#nullable restore
#line 133 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                                                                              Write(Model.DeliveryDurationForOther);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ساعت</span></p>

                                <p>
                                    برچسب های محصول:
                                    <span class=""badge badge-success light"">کیف</span>
                                    <span class=""badge badge-success light"">کت</span>
                                    <span class=""badge badge-success light"">کفش</span>
                                    <span class=""badge badge-success light"">پیراهن</span>
                                </p>
                                <p class=""text-content"">
                                    ");
#nullable restore
#line 143 "C:\Work\Projects\MyNiaSmart\MyNiaSmart\ServiceHost\Views\MainShop\SellerProductDetails.cshtml"
                               Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>

                                <div class=""shopping-cart mt-3"">
                                    <a class=""btn btn-primary btn-lg"" href=""#"">
                                        <i class=""fa fa-shopping-basket mr-2""></i>افزودن به سبد
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n<script>\r\n      function toDisplay(id){\r\n      debugger\r\n    let src=$(\"img#\"+id).attr(\'src\');\r\n    $(\"div.display\").removeClass(\"show active\");\r\n    $(\"div#\"+id).addClass(\"show active\");\r\n\r\n      }\r\n</script>\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopManagement.Application.Contract.SellerProduct.SellerProductDetailsToShowViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
