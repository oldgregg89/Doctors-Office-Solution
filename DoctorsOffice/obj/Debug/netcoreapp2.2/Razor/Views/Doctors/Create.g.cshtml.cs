#pragma checksum "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21c28d61eb5ee8916653f2cd0be74627a87cc554"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Create), @"mvc.1.0.view", @"/Views/Doctors/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctors/Create.cshtml", typeof(AspNetCore.Views_Doctors_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c28d61eb5ee8916653f2cd0be74627a87cc554", @"/Views/Doctors/Create.cshtml")]
    public class Views_Doctors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorsOffice.Models.Doctor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(63, 27, true);
            WriteLiteral("\n<h1>Add New Doctors</h1>\n\n");
            EndContext();
#line 9 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(123, 34, false);
#line 11 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(163, 36, false);
#line 12 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(206, 36, false);
#line 14 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Create.cshtml"
Write(Html.LabelFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(248, 38, false);
#line 15 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Create.cshtml"
Write(Html.TextBoxFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(288, 75, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new course\" class=\"btn btn-default\" />\n");
            EndContext();
#line 18 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Create.cshtml"
}

#line default
#line hidden
            BeginContext(365, 42, true);
            WriteLiteral("\n<input type=\"button\" value=\"Docotrs List\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 407, "\"", 465, 3);
            WriteAttributeValue("", 417, "location.href=\'", 417, 15, true);
#line 20 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Create.cshtml"
WriteAttributeValue("", 432, Url.Action("Index", "Docotrs"), 432, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 463, "\';", 463, 2, true);
            EndWriteAttribute();
            BeginContext(466, 68, true);
            WriteLiteral(" class=\"btn btn-primary\" />\n<input type=\"button\" value=\"Return Home\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 534, "\"", 589, 3);
            WriteAttributeValue("", 544, "location.href=\'", 544, 15, true);
#line 21 "/Users/iangregg/Desktop/DoctorsOffice.solution/DoctorsOffice/Views/Doctors/Create.cshtml"
WriteAttributeValue("", 559, Url.Action("Index", "Home"), 559, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 587, "\';", 587, 2, true);
            EndWriteAttribute();
            BeginContext(590, 27, true);
            WriteLiteral(" class=\"btn btn-primary\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorsOffice.Models.Doctor> Html { get; private set; }
    }
}
#pragma warning restore 1591