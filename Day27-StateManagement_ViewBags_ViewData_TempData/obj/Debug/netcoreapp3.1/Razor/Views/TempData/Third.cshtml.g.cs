#pragma checksum "C:\Users\kyleg\source\repos\Day27-StateManagement_ViewBags_ViewData_TempData\Day27-StateManagement_ViewBags_ViewData_TempData\Views\TempData\Third.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f974e84467184278b5f2b4552d90bfde5dfbadb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TempData_Third), @"mvc.1.0.view", @"/Views/TempData/Third.cshtml")]
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
#line 1 "C:\Users\kyleg\source\repos\Day27-StateManagement_ViewBags_ViewData_TempData\Day27-StateManagement_ViewBags_ViewData_TempData\Views\_ViewImports.cshtml"
using Day27_StateManagement_ViewBags_ViewData_TempData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kyleg\source\repos\Day27-StateManagement_ViewBags_ViewData_TempData\Day27-StateManagement_ViewBags_ViewData_TempData\Views\_ViewImports.cshtml"
using Day27_StateManagement_ViewBags_ViewData_TempData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f974e84467184278b5f2b4552d90bfde5dfbadb", @"/Views/TempData/Third.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dc641948ea4f6da8297d41ff9082e6c6eb2bdd8", @"/Views/_ViewImports.cshtml")]
    public class Views_TempData_Third : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kyleg\source\repos\Day27-StateManagement_ViewBags_ViewData_TempData\Day27-StateManagement_ViewBags_ViewData_TempData\Views\TempData\Third.cshtml"
  
    ViewData["Title"] = "Third";
    var jonVariable = "";
    if (TempData["Jon"] != null)
    {
         

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kyleg\source\repos\Day27-StateManagement_ViewBags_ViewData_TempData\Day27-StateManagement_ViewBags_ViewData_TempData\Views\TempData\Third.cshtml"
                                       
         jonVariable = TempData["Jon"].ToString() ?? null; 
    }
    else
    {
         jonVariable = "ERRR";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Third</h1>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\kyleg\source\repos\Day27-StateManagement_ViewBags_ViewData_TempData\Day27-StateManagement_ViewBags_ViewData_TempData\Views\TempData\Third.cshtml"
Write(jonVariable);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591