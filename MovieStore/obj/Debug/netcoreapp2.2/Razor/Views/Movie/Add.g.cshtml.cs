#pragma checksum "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c29df0a0174c082b57a6cadd87624c14707cd9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Add), @"mvc.1.0.view", @"/Views/Movie/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Add.cshtml", typeof(AspNetCore.Views_Movie_Add))]
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
#line 1 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\_ViewImports.cshtml"
using MovieStore;

#line default
#line hidden
#line 2 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\_ViewImports.cshtml"
using MovieStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c29df0a0174c082b57a6cadd87624c14707cd9a", @"/Views/Movie/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a8c2dc702b202c6daeaeb5df09bdab9162bf52c", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
  
    ViewData["Title"] = "Add";

#line default
#line hidden
            BeginContext(59, 20, true);
            WriteLiteral("\r\n<h1>Add</h1>\r\n\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
 using (@Html.BeginForm("AddMovie", "Movie", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(151, 24, false);
#line 11 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(177, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(216, 55, false);
#line 13 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.LabelFor(m => m.Id, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(271, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(282, 57, false);
#line 14 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.TextBoxFor(m => m.Id, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(339, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(350, 73, false);
#line 15 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.ValidationMessageFor(m => m.Id, "", new { @class = "label-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(423, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(476, 57, false);
#line 18 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.LabelFor(m => m.Name, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(533, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(544, 59, false);
#line 19 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.TextBoxFor(m => m.Name, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(603, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(614, 75, false);
#line 20 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "label-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(689, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(742, 58, false);
#line 23 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.LabelFor(m => m.Genre, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(800, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(811, 61, false);
#line 24 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.TextAreaFor(m => m.Genre, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(872, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(883, 39, false);
#line 25 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.ValidationMessageFor(m => m.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(922, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(975, 59, false);
#line 28 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.LabelFor(m => m.Rating, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1045, 61, false);
#line 29 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.TextBoxFor(m => m.Rating, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1117, 40, false);
#line 30 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.ValidationMessageFor(m => m.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1210, 59, false);
#line 33 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.LabelFor(m => m.Length, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1280, 61, false);
#line 34 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.TextBoxFor(m => m.Length, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1352, 40, false);
#line 35 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
   Write(Html.ValidationMessageFor(m => m.Length));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 56, true);
            WriteLiteral("\r\n    </div>\r\n    <input value=\"Save\" type=\"submit\" />\r\n");
            EndContext();
#line 38 "C:\Users\Jovana\Desktop\mvc homework\MovieStore\Views\Movie\Add.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591