#pragma checksum "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66b68dd1474a1c849a32ea5869584c75f8be609b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_Controlpanel), @"mvc.1.0.view", @"/Views/Administration/Controlpanel.cshtml")]
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
#line 1 "E:\Git\Project\Project\Project\Views\_ViewImports.cshtml"
using Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Git\Project\Project\Project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b68dd1474a1c849a32ea5869584c75f8be609b", @"/Views/Administration/Controlpanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc6df3f5edff003d6bb7b963e72c81362e302945", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_Controlpanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EditInformationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/control.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
#nullable restore
#line 7 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
   
    var contact = ViewData["contact"] as IEnumerable<Project.Models.Contacting>;
    var NewsLetter = ViewData["NewsLetter"] as IEnumerable<Project.Models.newsLetters>;
    var JobApp = ViewData["App"] as IEnumerable<Project.Models.Job_App>;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66b68dd1474a1c849a32ea5869584c75f8be609b6364", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
          integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link href=""css/bootstrap.min.css"" rel=""stylesheet"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "66b68dd1474a1c849a32ea5869584c75f8be609b7194", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66b68dd1474a1c849a32ea5869584c75f8be609b9081", async() => {
                WriteLiteral(@"
    <div class=""container"" style=""padding-top:50px"">
        <div class=""bg"">
            <h1 class=""p-4"">control panel</h1>
        </div>
        <section id=""tables"" class=""mt-5 text-center"">
            <ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist"" class=""mt-5"">
                <li class=""nav-item"" role=""presentation"">
                    <button class=""nav-link active"" id=""pills-home-tab"" data-bs-toggle=""pill"" data-bs-target=""#pills-home""
                            type=""button"" role=""tab"" aria-controls=""pills-home"" aria-selected=""true"">
                        customer info
                    </button>
                </li>
                <li class=""nav-item"" role=""presentation"">
                    <button class=""nav-link"" id=""pills-profile-tab"" data-bs-toggle=""pill"" data-bs-target=""#pills-profile""
                            type=""button"" role=""tab"" aria-controls=""pills-profile"" aria-selected=""false"">
                        news letter eamil
                    </b");
                WriteLiteral(@"utton>
                </li>
                <li class=""nav-item"" role=""presentation"">
                    <button class=""nav-link"" id=""pills-contact-tab"" data-bs-toggle=""pill"" data-bs-target=""#pills-contact""
                            type=""button"" role=""tab"" aria-controls=""pills-contact"" aria-selected=""false"">
                        job application
                    </button>
                </li>
                <li class=""nav-item"" role=""presentation"">
                    <button class=""nav-link"" id=""pills-info-tab"" data-bs-toggle=""pill"" data-bs-target=""#pills-info"" type=""button""
                            role=""tab"" aria-controls=""pills-info"" aria-selected=""false"">
                        edit info
                    </button>
                </li>

            </ul>
            <div class=""tab-content"" id=""pills-tabContent"">
                <div class=""tab-pane fade show active mt-5"" id=""pills-home"" role=""tabpanel"" aria-labelledby=""pills-home-tab""
                     tabindex=""0");
                WriteLiteral(@""">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">id</th>
                                <th scope=""col"">first name</th>
                                <th scope=""col"">last name</th>
                                <th scope=""col"">phone</th>
                                <th scope=""col"">messae</th>
                                <th scope=""col"">Email</th>
                                



                            </tr>
                        </thead>
                        
                        <tbody class=""table-group-divider"">
");
#nullable restore
#line 77 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                             foreach (var con in contact)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 80 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                               Write(con.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 81 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                   Write(con.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 82 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                   Write(con.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 83 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                   Write(con.PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 84 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                     if (@con.Message == null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td>No Message </td>\r\n");
#nullable restore
#line 87 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td>");
#nullable restore
#line 90 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                       Write(con.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 91 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>");
#nullable restore
#line 92 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                   Write(con.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 94 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </tbody>
                    </table>
                </div>
                <div class=""tab-pane fade"" id=""pills-profile"" role=""tabpanel"" aria-labelledby=""pills-profile-tab"" tabindex=""0"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">id</th>
                                <th scope=""col"">email</th>
                                <th scope=""col"">sending News</th>
                            </tr>
                        </thead>
                        <tbody class=""table-group-divider"">

");
#nullable restore
#line 110 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                             foreach (var News in NewsLetter)
                                
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 114 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                           Write(News.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 115 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                               Write(News.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 116 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                 if(News.send == null)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>No Emailing</td>\r\n");
#nullable restore
#line 119 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>");
#nullable restore
#line 122 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                           Write(News.send);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 123 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                \r\n                            </tr>\r\n");
#nullable restore
#line 126 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                  

                            </tbody>
                    </table>
                </div>
                <div class=""tab-pane fade"" id=""pills-contact"" role=""tabpanel"" aria-labelledby=""pills-contact-tab"" tabindex=""0"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                
                                <th scope=""col"">id</th>
                                <th scope=""col"">first name</th>
                                <th scope=""col"">last name</th>
                                <th scope=""col"">Country</th>
                                <th scope=""col"">City</th>
                                <th scope=""col"">Mobile Phone</th>

                            </tr>
                        </thead>
                        <tbody class=""table-group-divider"">
");
#nullable restore
#line 147 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                             foreach (var job in JobApp)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 150 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                               Write(job.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 151 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                   Write(job.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 152 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                   Write(job.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 153 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                   Write(job.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 154 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                   Write(job.City);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 155 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                                   Write(job.Mobile_Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 157 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </tbody>
                    </table>
                </div>
                <div class=""tab-pane fade"" id=""pills-info"" role=""tabpanel"" aria-labelledby=""pills-info-tab"" tabindex=""0"">
                  
                    <div class=""w-75 text-center mx-auto mt-5"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66b68dd1474a1c849a32ea5869584c75f8be609b22249", async() => {
                    WriteLiteral("\r\n                                <button class=\"btn btn-success mt-5\">Update Information</button>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");
#nullable restore
#line 172 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
             if (signinManager.IsSignedIn(User))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66b68dd1474a1c849a32ea5869584c75f8be609b24164", async() => {
                    WriteLiteral("\r\n                    <button type=\"submit\" class=\"nav-link btn btn-link py-0\"style=\"width:auto\">\r\n                        LogOut  ");
#nullable restore
#line 176 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
                           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </button>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 179 "E:\Git\Project\Project\Project\Views\Administration\Controlpanel.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n   \r\n\r\n    </section>\r\n    <script src=\"JAVA SCRIPT/jquery-3.6.0.min.js\"></script>\r\n    <script src=\"js/bootstrap.bundle.js\"></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> signinManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditInformationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
