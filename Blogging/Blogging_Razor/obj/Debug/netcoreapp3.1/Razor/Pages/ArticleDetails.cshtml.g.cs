#pragma checksum "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\Blogging\Blogging\Blogging_Razor\Pages\ArticleDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "955c7584617458ad8ce0f9a7ab63c763b33b8d3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Blogging_Razor.Pages.Pages_ArticleDetails), @"mvc.1.0.razor-page", @"/Pages/ArticleDetails.cshtml")]
namespace Blogging_Razor.Pages
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
#line 1 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\Blogging\Blogging\Blogging_Razor\Pages\_ViewImports.cshtml"
using Blogging_Razor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"955c7584617458ad8ce0f9a7ab63c763b33b8d3a", @"/Pages/ArticleDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7861fdedeb65728cd5b08a2b9717f55dfcedf0f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ArticleDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-12 mb-3\">\r\n    <h1>");
#nullable restore
#line 6 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\Blogging\Blogging\Blogging_Razor\Pages\ArticleDetails.cshtml"
   Write(Model.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<div class=\"col-12 mb-3\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 179, "\"", 207, 1);
#nullable restore
#line 9 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\Blogging\Blogging\Blogging_Razor\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 185, Model.Article.Picture, 185, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 208, "\"", 239, 1);
#nullable restore
#line 9 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\Blogging\Blogging\Blogging_Razor\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 214, Model.Article.PictureAlt, 214, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 240, "\"", 275, 1);
#nullable restore
#line 9 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\Blogging\Blogging\Blogging_Razor\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 248, Model.Article.PictureTitle, 248, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n</div>\r\n<div class=\"col-12\">\r\n    <p class=\"article-content\">\r\n        ");
#nullable restore
#line 13 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\Blogging\Blogging\Blogging_Razor\Pages\ArticleDetails.cshtml"
   Write(Model.Article.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n</div>\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blogging_Razor.Pages.ArticleDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Blogging_Razor.Pages.ArticleDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Blogging_Razor.Pages.ArticleDetailsModel>)PageContext?.ViewData;
        public Blogging_Razor.Pages.ArticleDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591