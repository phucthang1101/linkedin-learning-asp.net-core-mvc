#pragma checksum "C:\Users\DELL\Desktop\.NET\Learning ASP.NET Core MVC - LinkedIn Learning\ExploreOntario\ExploreOntario\Views\Shared\Components\MonthlySpecials\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d51129952ca717feef58caf29992ce6dde02291"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MonthlySpecials_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MonthlySpecials/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MonthlySpecials/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MonthlySpecials_Default))]
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
#line 1 "C:\Users\DELL\Desktop\.NET\Learning ASP.NET Core MVC - LinkedIn Learning\ExploreOntario\ExploreOntario\Views\_ViewImports.cshtml"
using ExploreOntario;

#line default
#line hidden
#line 2 "C:\Users\DELL\Desktop\.NET\Learning ASP.NET Core MVC - LinkedIn Learning\ExploreOntario\ExploreOntario\Views\_ViewImports.cshtml"
using ExploreOntario.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d51129952ca717feef58caf29992ce6dde02291", @"/Views/Shared/Components/MonthlySpecials/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a200ff158ac7aa3a034d75100b9cfe1e5f1267c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MonthlySpecials_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExploreOntario.Models.MonthlySpecial>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 31, true);
            WriteLiteral("\r\n<h1>Monthly Specials</h1>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\DELL\Desktop\.NET\Learning ASP.NET Core MVC - LinkedIn Learning\ExploreOntario\ExploreOntario\Views\Shared\Components\MonthlySpecials\Default.cshtml"
 foreach (var special in Model)
{

#line default
#line hidden
            BeginContext(125, 34, true);
            WriteLiteral("    <h2 class=\"top\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 159, "\"", 195, 3);
            WriteAttributeValue("", 165, "/images/", 165, 8, true);
#line 8 "C:\Users\DELL\Desktop\.NET\Learning ASP.NET Core MVC - LinkedIn Learning\ExploreOntario\ExploreOntario\Views\Shared\Components\MonthlySpecials\Default.cshtml"
WriteAttributeValue("", 173, special.Key, 173, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 187, "_bug.gif", 187, 8, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 196, "\"", 215, 1);
#line 8 "C:\Users\DELL\Desktop\.NET\Learning ASP.NET Core MVC - LinkedIn Learning\ExploreOntario\ExploreOntario\Views\Shared\Components\MonthlySpecials\Default.cshtml"
WriteAttributeValue("", 202, special.Name, 202, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(216, 34, true);
            WriteLiteral(" width=\"75\" height=\"75\">\r\n        ");
            EndContext();
            BeginContext(251, 12, false);
#line 9 "C:\Users\DELL\Desktop\.NET\Learning ASP.NET Core MVC - LinkedIn Learning\ExploreOntario\ExploreOntario\Views\Shared\Components\MonthlySpecials\Default.cshtml"
   Write(special.Name);

#line default
#line hidden
            EndContext();
            BeginContext(263, 30, true);
            WriteLiteral("\r\n    </h2>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(294, 12, false);
#line 12 "C:\Users\DELL\Desktop\.NET\Learning ASP.NET Core MVC - LinkedIn Learning\ExploreOntario\ExploreOntario\Views\Shared\Components\MonthlySpecials\Default.cshtml"
   Write(special.Type);

#line default
#line hidden
            EndContext();
            BeginContext(306, 17, true);
            WriteLiteral(" <br>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 323, "\"", 355, 3);
            WriteAttributeValue("", 330, "/tours/", 330, 7, true);
#line 13 "C:\Users\DELL\Desktop\.NET\Learning ASP.NET Core MVC - LinkedIn Learning\ExploreOntario\ExploreOntario\Views\Shared\Components\MonthlySpecials\Default.cshtml"
WriteAttributeValue("", 337, special.Key, 337, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 351, ".htm", 351, 4, true);
            EndWriteAttribute();
            BeginContext(356, 2, true);
            WriteLiteral(">$");
            EndContext();
            BeginContext(359, 13, false);
#line 13 "C:\Users\DELL\Desktop\.NET\Learning ASP.NET Core MVC - LinkedIn Learning\ExploreOntario\ExploreOntario\Views\Shared\Components\MonthlySpecials\Default.cshtml"
                                        Write(special.Price);

#line default
#line hidden
            EndContext();
            BeginContext(372, 16, true);
            WriteLiteral("</a>\r\n    </p>\r\n");
            EndContext();
#line 15 "C:\Users\DELL\Desktop\.NET\Learning ASP.NET Core MVC - LinkedIn Learning\ExploreOntario\ExploreOntario\Views\Shared\Components\MonthlySpecials\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExploreOntario.Models.MonthlySpecial>> Html { get; private set; }
    }
}
#pragma warning restore 1591
