#pragma checksum "C:\Users\Асад\source\repos\CourseProject\CourseProject\Views\Windows\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e15b3867d993eeb9745c060813647f287945fe70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Windows_List), @"mvc.1.0.view", @"/Views/Windows/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Windows/List.cshtml", typeof(AspNetCore.Views_Windows_List))]
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
#line 1 "C:\Users\Асад\source\repos\CourseProject\CourseProject\Views\_ViewImports.cshtml"
using CourseProject.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Асад\source\repos\CourseProject\CourseProject\Views\_ViewImports.cshtml"
using CourseProject.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15b3867d993eeb9745c060813647f287945fe70", @"/Views/Windows/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a0272b5902c309d329f70d9f112fc0f55d34ea5", @"/Views/_ViewImports.cshtml")]
    public class Views_Windows_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 32, true);
            WriteLiteral("<div class=\"row m-3 p-3\">\r\n\t<h3>");
            EndContext();
            BeginContext(33, 18, false);
#line 2 "C:\Users\Асад\source\repos\CourseProject\CourseProject\Views\Windows\List.cshtml"
   Write(Model.currCategory);

#line default
#line hidden
            EndContext();
            BeginContext(51, 12, true);
            WriteLiteral("</h3>\r\n\t<h4>");
            EndContext();
            BeginContext(64, 14, false);
#line 3 "C:\Users\Асад\source\repos\CourseProject\CourseProject\Views\Windows\List.cshtml"
   Write(Model.currDesc);

#line default
#line hidden
            EndContext();
            BeginContext(78, 42, true);
            WriteLiteral("</h4>\r\n</div>\r\n<div class=\"row m-3 p-5\">\r\n");
            EndContext();
#line 6 "C:\Users\Асад\source\repos\CourseProject\CourseProject\Views\Windows\List.cshtml"
      
		foreach (var window in Model.allWindows)
		{

#line default
#line hidden
            BeginContext(174, 53, true);
            WriteLiteral("\t<div class=\"col-lg-4\">\r\n\t\t<img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 227, "\"", 244, 1);
#line 10 "C:\Users\Асад\source\repos\CourseProject\CourseProject\Views\Windows\List.cshtml"
WriteAttributeValue("", 233, window.img, 233, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 245, "\"", 263, 1);
#line 10 "C:\Users\Асад\source\repos\CourseProject\CourseProject\Views\Windows\List.cshtml"
WriteAttributeValue("", 251, window.name, 251, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(264, 11, true);
            WriteLiteral(" />\r\n\t\t<h2>");
            EndContext();
            BeginContext(276, 11, false);
#line 11 "C:\Users\Асад\source\repos\CourseProject\CourseProject\Views\Windows\List.cshtml"
       Write(window.name);

#line default
#line hidden
            EndContext();
            BeginContext(287, 25, true);
            WriteLiteral("</h2>\r\n\t\t<p><u>Цена:</u> ");
            EndContext();
            BeginContext(313, 26, false);
#line 12 "C:\Users\Асад\source\repos\CourseProject\CourseProject\Views\Windows\List.cshtml"
                   Write(window.price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(339, 26, true);
            WriteLiteral("</p>\r\n\t\t<p><u>Размер:</u> ");
            EndContext();
            BeginContext(366, 11, false);
#line 13 "C:\Users\Асад\source\repos\CourseProject\CourseProject\Views\Windows\List.cshtml"
                     Write(window.size);

#line default
#line hidden
            EndContext();
            BeginContext(377, 28, true);
            WriteLiteral("</p>\r\n\t\t<p><u>Описание:</u> ");
            EndContext();
            BeginContext(406, 15, false);
#line 14 "C:\Users\Асад\source\repos\CourseProject\CourseProject\Views\Windows\List.cshtml"
                       Write(window.longDesc);

#line default
#line hidden
            EndContext();
            BeginContext(421, 15, true);
            WriteLiteral("</p>\r\n\t</div>\r\n");
            EndContext();
#line 16 "C:\Users\Асад\source\repos\CourseProject\CourseProject\Views\Windows\List.cshtml"
		}

	

#line default
#line hidden
            BeginContext(447, 105, true);
            WriteLiteral("</div>\r\n<!--блок кода(характеристика каждого отдельного товара) , который мы вставим в общий шаблон -->\r\n");
            EndContext();
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
