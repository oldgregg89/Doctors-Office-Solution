#pragma checksum "/Users/taylor/Desktop/Doctors-Office-Solution/DoctorsOffice/Views/Doctors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf4a7e3cd6e7121ff37413fa4a309ae8a8997cb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Index), @"mvc.1.0.view", @"/Views/Doctors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctors/Index.cshtml", typeof(AspNetCore.Views_Doctors_Index))]
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
#line 5 "/Users/taylor/Desktop/Doctors-Office-Solution/DoctorsOffice/Views/Doctors/Index.cshtml"
using DoctorsOffice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf4a7e3cd6e7121ff37413fa4a309ae8a8997cb3", @"/Views/Doctors/Index.cshtml")]
    public class Views_Doctors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DoctorsOffice.Models.Doctor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/taylor/Desktop/Doctors-Office-Solution/DoctorsOffice/Views/Doctors/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(99, 19, true);
            WriteLiteral("\n<h1>Doctors</h1>\n\n");
            EndContext();
#line 10 "/Users/taylor/Desktop/Doctors-Office-Solution/DoctorsOffice/Views/Doctors/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(144, 43, true);
            WriteLiteral("  <h3>No doctors have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/taylor/Desktop/Doctors-Office-Solution/DoctorsOffice/Views/Doctors/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(190, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/taylor/Desktop/Doctors-Office-Solution/DoctorsOffice/Views/Doctors/Index.cshtml"
 foreach (Doctor doctor in Model)
{

#line default
#line hidden
            BeginContext(227, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(234, 74, false);
#line 17 "/Users/taylor/Desktop/Doctors-Office-Solution/DoctorsOffice/Views/Doctors/Index.cshtml"
 Write(Html.ActionLink($"{doctor.Name}", "Details", new { id = doctor.DoctorId }));

#line default
#line hidden
            EndContext();
            BeginContext(308, 11, true);
            WriteLiteral(" || Dr. of ");
            EndContext();
            BeginContext(320, 16, false);
#line 17 "/Users/taylor/Desktop/Doctors-Office-Solution/DoctorsOffice/Views/Doctors/Index.cshtml"
                                                                                       Write(doctor.Specialty);

#line default
#line hidden
            EndContext();
            BeginContext(336, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/taylor/Desktop/Doctors-Office-Solution/DoctorsOffice/Views/Doctors/Index.cshtml"
}

#line default
#line hidden
            BeginContext(344, 48, true);
            WriteLiteral("<hr>\n<input type=\"button\" value=\"Add new doctor\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 392, "\"", 451, 3);
            WriteAttributeValue("", 402, "location.href=\'", 402, 15, true);
#line 20 "/Users/taylor/Desktop/Doctors-Office-Solution/DoctorsOffice/Views/Doctors/Index.cshtml"
WriteAttributeValue("", 417, Url.Action("Create", "Doctors"), 417, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 449, "\';", 449, 2, true);
            EndWriteAttribute();
            BeginContext(452, 68, true);
            WriteLiteral(" class=\"btn btn-primary\" />\n<input type=\"button\" value=\"Return Home\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 520, "\"", 575, 3);
            WriteAttributeValue("", 530, "location.href=\'", 530, 15, true);
#line 21 "/Users/taylor/Desktop/Doctors-Office-Solution/DoctorsOffice/Views/Doctors/Index.cshtml"
WriteAttributeValue("", 545, Url.Action("Index", "Home"), 545, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 573, "\';", 573, 2, true);
            EndWriteAttribute();
            BeginContext(576, 27, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DoctorsOffice.Models.Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
