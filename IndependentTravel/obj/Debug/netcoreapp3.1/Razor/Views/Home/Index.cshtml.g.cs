#pragma checksum "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a50c5a369a9ecfd2a2aa4cbf58dc71d6206de61b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\_ViewImports.cshtml"
using IndependentTravel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\_ViewImports.cshtml"
using IndependentTravel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\_ViewImports.cshtml"
using IndependentTravel.DataModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a50c5a369a9ecfd2a2aa4cbf58dc71d6206de61b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"496580c10e73c39523949b8445d6e41859836eb9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DestinationViewModelList>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a50c5a369a9ecfd2a2aa4cbf58dc71d6206de61b3440", async() => {
                WriteLiteral("\r\n<style>\r\nbody {\r\n  background: #ebf7f4 url(\"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfjAXdf2zg1rGm7lu6hZSuz1WGTlw67xFZhw&usqp=CAU\") no-repeat right top;\r\n  margin-right: 200px;\r\n}\r\n</style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h1 style=\"text-align:center;\"> Here you can find ideas and useful tips for your next trip</h1>\r\n <br />\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
  if (Model == null || Model.List == null || Model.List.Count == 0)
 {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <h2> Don\'t travel now, my friend :)  </h2>\r\n        <div>Maybe you want to <a href=\"/Home/AddDestination\">add a destination</a></div>\r\n");
#nullable restore
#line 17 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
 }
 else
 {
     

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
      foreach (var destination in Model.List)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("onclick", " onclick=\"", 653, "\"", 697, 3);
            WriteAttributeValue("", 663, "loadDestination(\'", 663, 17, true);
#nullable restore
#line 22 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
WriteAttributeValue("", 680, destination.Id, 680, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 695, "\')", 695, 2, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"destination-container\" class=\"container\">\r\n        <h4><b>");
#nullable restore
#line 23 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
          Write(destination.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in ");
#nullable restore
#line 23 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
                               Write(destination.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\r\n        <div class=\"row\">\r\n            <div class=\"col-md\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 894, "\"", 923, 1);
#nullable restore
#line 26 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
WriteAttributeValue("", 900, destination.PictureURL, 900, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\" /></div></div>\r\n                <div class=\"row\">\r\n            <div class=\"col text-sm-center\">\r\n                ");
#nullable restore
#line 29 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
           Write(destination.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></div>\r\n        <div class=\"row\">\r\n            <div class=\"col text-sm-center\">\r\n               <b>Where to sleep?</b>  ");
#nullable restore
#line 32 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
                                  Write(destination.PlaceToSleep);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></div>\r\n                      <div class=\"row\">\r\n            <div class=\"col text-sm-center\">\r\n                <b>Where to eat?</b> ");
#nullable restore
#line 35 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
                                Write(destination.PlaceToEat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></div></div><hr />\r\n");
#nullable restore
#line 36 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <nav aria-label=\"...\">\r\n        <ul class=\"pagination\">\r\n");
#nullable restore
#line 42 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
             if (Model.CurrentPage == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item disabled\">\r\n                    <a class=\"page-link\" href=\"#\" tabindex=\"-1\">Previous</a>\r\n                </li>\r\n");
#nullable restore
#line 47 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1831, "\"", 1884, 2);
            WriteAttributeValue("", 1838, "/Home/Index?currentPage=", 1838, 24, true);
#nullable restore
#line 51 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
WriteAttributeValue("", 1862, Model.CurrentPage-1, 1862, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\">Previous</a>\r\n                </li>\r\n");
#nullable restore
#line 53 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.TotalPages; i++)
            {
                if (i + 1 == Model.CurrentPage)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item active\">\r\n                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2187, "\"", 2226, 2);
            WriteAttributeValue("", 2194, "/Home/Index?currentPage=", 2194, 24, true);
#nullable restore
#line 59 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
WriteAttributeValue("", 2218, i + 1, 2218, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
                                                                                 Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                    </li>\r\n");
#nullable restore
#line 61 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2430, "\"", 2469, 2);
            WriteAttributeValue("", 2437, "/Home/Index?currentPage=", 2437, 24, true);
#nullable restore
#line 64 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
WriteAttributeValue("", 2461, i + 1, 2461, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
                                                                                                   Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 65 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 68 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
             if (Model.CurrentPage == Model.TotalPages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item disabled\">\r\n                    <a class=\"page-link\" href=\"#\">Next</a>\r\n                </li>\r\n");
#nullable restore
#line 73 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2858, "\"", 2911, 2);
            WriteAttributeValue("", 2865, "/Home/Index?currentPage=", 2865, 24, true);
#nullable restore
#line 77 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
WriteAttributeValue("", 2889, Model.CurrentPage+1, 2889, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n                </li>\r\n");
#nullable restore
#line 79 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ul>\r\n    </nav>\r\n");
#nullable restore
#line 83 "C:\Users\Vanya\Documents\it steps\c#\final project\IndependentTravel\IndependentTravel\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <script>\r\n\r\n    const loadDestination = (destinationId) => {\r\n        window.location = \'/Home/DestinationDetails?destinationId=\' + destinationId;\r\n    }\r\n\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DestinationViewModelList> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
