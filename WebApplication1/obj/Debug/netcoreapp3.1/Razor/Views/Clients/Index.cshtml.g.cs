#pragma checksum "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Clients\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04f94f595fa3b24c3a9b51647af85ae0cddd7c0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Index), @"mvc.1.0.razor-page", @"/Views/Clients/Index.cshtml")]
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
#line 1 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04f94f595fa3b24c3a9b51647af85ae0cddd7c0c", @"/Views/Clients/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<br>
<h2>List of Clients</h2>
<a class= 'btn btn-primary btn-sm' href= '/Clients/Create'>New Client</a>
<table class=""table"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Phone</th>
            <th>Address</th>
            <th>Created At</th>
            <th>Action</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Clients\Index.cshtml"
         foreach(var item in Model.listClients)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Clients\Index.cshtml"
           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Clients\Index.cshtml"
           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Clients\Index.cshtml"
           Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Clients\Index.cshtml"
           Write(item.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Clients\Index.cshtml"
           Write(item.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Clients\Index.cshtml"
           Write(item.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 818, "\"", 850, 2);
            WriteAttributeValue("", 825, "/Clients/Edit?id=", 825, 17, true);
#nullable restore
#line 33 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Clients\Index.cshtml"
WriteAttributeValue("", 842, item.id, 842, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 911, "\"", 945, 2);
            WriteAttributeValue("", 918, "/Clients/Delete?id=", 918, 19, true);
#nullable restore
#line 34 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Clients\Index.cshtml"
WriteAttributeValue("", 937, item.id, 937, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n\r\n\r\n</tr>\r\n");
#nullable restore
#line 38 "C:\Users\DELL\source\repos\WebApplication1\WebApplication1\Views\Clients\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Views.Clients.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Views.Clients.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Views.Clients.IndexModel>)PageContext?.ViewData;
        public WebApplication1.Views.Clients.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
