#pragma checksum "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c596b129a26df3b7653fd2254289a7d737086d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c596b129a26df3b7653fd2254289a7d737086d7", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0baa3cae9d6f91b1a254298d36fc964d6816076e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Available Products:</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\Index.cshtml"
 foreach (Product item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 155, "\"", 192, 2);
            WriteAttributeValue("", 162, "/Admin/Description?id=", 162, 22, true);
#nullable restore
#line 11 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\Index.cshtml"
WriteAttributeValue("", 184, item.id, 184, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\Index.cshtml"
                                            Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 220, "\"", 256, 2);
            WriteAttributeValue("", 227, "/Admin/UpdateForm?id=", 227, 21, true);
#nullable restore
#line 12 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\Index.cshtml"
WriteAttributeValue("", 248, item.id, 248, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 302, "\"", 460, 10);
            WriteAttributeValue("", 309, "/Admin/DeleteConfirmation?id=", 309, 29, true);
#nullable restore
#line 13 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\Index.cshtml"
WriteAttributeValue("", 338, item.id, 338, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 346, "&name=", 346, 6, true);
#nullable restore
#line 13 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\Index.cshtml"
WriteAttributeValue("", 352, item.name, 352, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("\r\n           ", 362, "&description=", 375, 26, true);
#nullable restore
#line 14 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\Index.cshtml"
WriteAttributeValue("", 388, item.description, 388, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 405, "&price=", 405, 7, true);
#nullable restore
#line 14 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\Index.cshtml"
WriteAttributeValue("", 412, item.price, 412, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("\r\n           ", 423, "&category=", 436, 23, true);
#nullable restore
#line 15 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\Index.cshtml"
WriteAttributeValue("", 446, item.category, 446, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n\r\n    </div> \r\n");
#nullable restore
#line 18 "C:\MYALLREPOS\CoffeeShopMVCLab\CoffeeShop\CoffeeShopProduct\Views\Admin\Index.cshtml"
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<a href=\"/Admin/ProductForm\" class=\"btn btn-primary\">Add Product</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
