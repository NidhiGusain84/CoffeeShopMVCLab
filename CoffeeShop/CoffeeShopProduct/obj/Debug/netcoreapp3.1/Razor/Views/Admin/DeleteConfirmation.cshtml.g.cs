#pragma checksum "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\DeleteConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76f87d69a28a5623356ad50f6b333e0dc6da4390"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DeleteConfirmation), @"mvc.1.0.view", @"/Views/Admin/DeleteConfirmation.cshtml")]
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
#line 1 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\_ViewImports.cshtml"
using CoffeeShopProduct;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\_ViewImports.cshtml"
using CoffeeShopProduct.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f87d69a28a5623356ad50f6b333e0dc6da4390", @"/Views/Admin/DeleteConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0baa3cae9d6f91b1a254298d36fc964d6816076e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DeleteConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\DeleteConfirmation.cshtml"
  
    ViewData["Title"] = "DeleteConfirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Are you sure you want to delete this product?</h1>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 132, "\"", 172, 2);
            WriteAttributeValue("", 139, "/Admin/DeleteProduct?id=", 139, 24, true);
#nullable restore
#line 8 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\DeleteConfirmation.cshtml"
WriteAttributeValue("", 163, Model.id, 163, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">\r\n    Yes</a>\r\n\r\n<a href=\"/Admin\" class=\"btn btn-primary\">No</a>\r\n\r\n<h2>Product Description</h2>\r\n\r\n\r\nProduct Id: ");
#nullable restore
#line 16 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\DeleteConfirmation.cshtml"
       Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\nProduct Name: ");
#nullable restore
#line 17 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\DeleteConfirmation.cshtml"
         Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\nProduct Description: ");
#nullable restore
#line 18 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\DeleteConfirmation.cshtml"
                Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\nProduct Price: $");
#nullable restore
#line 19 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\DeleteConfirmation.cshtml"
           Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\nProduct Category: ");
#nullable restore
#line 20 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\DeleteConfirmation.cshtml"
             Write(Model.category);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
