#pragma checksum "C:\Users\chasi\source\repos\clspurge\CIS174-T4-HDProj\Team4_FinalProject\Team4_FinalProject\Views\Note\_NoteListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "802451219c2057485438b89840c2c91dabb5bb2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Note__NoteListPartial), @"mvc.1.0.view", @"/Views/Note/_NoteListPartial.cshtml")]
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
#line 1 "C:\Users\chasi\source\repos\clspurge\CIS174-T4-HDProj\Team4_FinalProject\Team4_FinalProject\Views\_ViewImports.cshtml"
using Team4_FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chasi\source\repos\clspurge\CIS174-T4-HDProj\Team4_FinalProject\Team4_FinalProject\Views\_ViewImports.cshtml"
using Team4_FinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"802451219c2057485438b89840c2c91dabb5bb2f", @"/Views/Note/_NoteListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ac47c7cbafcf6fd9d0b6805125d13433c64e9fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Note__NoteListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Note>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2 class=""display-4"">Ticket List</h2>

<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th class=""col-1"">Date Created</th>
            <th class=""col-1"">Creator</th>
            <th class=""col-6"">Content</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "C:\Users\chasi\source\repos\clspurge\CIS174-T4-HDProj\Team4_FinalProject\Team4_FinalProject\Views\Note\_NoteListPartial.cshtml"
         foreach (Note note in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\chasi\source\repos\clspurge\CIS174-T4-HDProj\Team4_FinalProject\Team4_FinalProject\Views\Note\_NoteListPartial.cshtml"
               Write(note.NoteId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\chasi\source\repos\clspurge\CIS174-T4-HDProj\Team4_FinalProject\Team4_FinalProject\Views\Note\_NoteListPartial.cshtml"
               Write(note.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\chasi\source\repos\clspurge\CIS174-T4-HDProj\Team4_FinalProject\Team4_FinalProject\Views\Note\_NoteListPartial.cshtml"
               Write(note.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\chasi\source\repos\clspurge\CIS174-T4-HDProj\Team4_FinalProject\Team4_FinalProject\Views\Note\_NoteListPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Note>> Html { get; private set; }
    }
}
#pragma warning restore 1591
