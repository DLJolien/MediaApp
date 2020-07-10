#pragma checksum "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a36d68b0843ba15401f03e0bf97b3f4faf05112"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\_ViewImports.cshtml"
using MediaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\_ViewImports.cshtml"
using MediaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a36d68b0843ba15401f03e0bf97b3f4faf05112", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790c984f0a7ce632dd32656ef5119182c2669c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MediaApp.Models.Index.CommentListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml"
  
    if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>There are no pending comments</p>\r\n");
#nullable restore
#line 7 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>There are ");
#nullable restore
#line 10 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml"
                Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" comments waiting on your approval</p>\r\n");
            WriteLiteral(@"        <div class=""container"">
            <div id=""title"" class=""row"">
                <div class=""col"">
                    Options
                </div>
                <div class=""col-2"">
                    Author
                </div>
                <div class=""col-4"">
                    Comment
                </div>
                <div class=""col-2"">
                    Date
                </div>
                <div class=""col-3"">
                    In response to
                </div>
            </div>
");
#nullable restore
#line 30 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml"
             foreach (var comment in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col\">\r\n                        <i id=\"icon-remove\"");
            BeginWriteAttribute("onclick", " onclick=\"", 976, "\"", 1005, 3);
            WriteAttributeValue("", 986, "Remove(", 986, 7, true);
#nullable restore
#line 34 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml"
WriteAttributeValue("", 993, comment.Id, 993, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1004, ")", 1004, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-times\"></i>\r\n                        <i id=\"icon-approve\"");
            BeginWriteAttribute("onclick", "onclick=\"", 1078, "\"", 1107, 3);
            WriteAttributeValue("", 1087, "Approve(", 1087, 8, true);
#nullable restore
#line 35 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1095, comment.Id, 1095, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1106, ")", 1106, 1, true);
            EndWriteAttribute();
            WriteLiteral("class=\"fas fa-chevron-down\"></i>\r\n                    </div>\r\n                    <div class=\"col-2\">\r\n                        ");
#nullable restore
#line 38 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml"
                   Write(comment.UserName.Split('@')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-4\">\r\n                        ");
#nullable restore
#line 41 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml"
                   Write(comment.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-2\">\r\n                        ");
#nullable restore
#line 44 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml"
                   Write(comment.PublishedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1595, "\"", 1634, 2);
            WriteAttributeValue("", 1602, "/Film/Detail?id=", 1602, 16, true);
#nullable restore
#line 47 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1618, comment.MediaId, 1618, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml"
                                                              Write(comment.MediaTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>                     \r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 50 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 53 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://kit.fontawesome.com/a6748bd2b3.js"" crossorigin=""anonymous""></script>
<script>
    async function Remove(id) {
       await $.post(""/Admin/RemoveComment"", { id: id }, function () {
            console.log(""removed"" + id);
        });
        window.location.href=""/Admin/index""
    }
    async function Approve(id) {
       await $.post(""/Admin/ApproveComment"", { id: id }, function () {
            console.log(""approved"" + id);
        });
        window.location.href = ""/Admin/index""
    }
</script>
<style>
    i:hover{
        cursor: pointer;
    }
    #title{
        font-weight: 500;
    }
    #icon-approve{
        color: seagreen;
    }
    #icon-remove{
        color: darkred;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MediaApp.Models.Index.CommentListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591