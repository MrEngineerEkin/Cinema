#pragma checksum "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97c8f9acc2307c58864016857e6ae2b34fd3313e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMainPage_AdminMoviePage), @"mvc.1.0.view", @"/Views/AdminMainPage/AdminMoviePage.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97c8f9acc2307c58864016857e6ae2b34fd3313e", @"/Views/AdminMainPage/AdminMoviePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42fd429d129da1b7030d35220f8e50d42701dc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminMainPage_AdminMoviePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cinema.Management.System.ViewModels.MovieCreateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/AdminMainPage/AdminMoviePage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c8f9acc2307c58864016857e6ae2b34fd3313e4728", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Movie Page</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
        integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.4/css/all.css"">
    <style>
        #background {
            background-image: url(https://www.arttablo.com/upload/U-sinema-salonu-fotograf-kanvas-tablo1461331435-800.jpg);
            background-attachment: fixed;
            background-position: center;
            background-repeat: no-repeat;
            background-size: cover;
        }
    </style>

");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c8f9acc2307c58864016857e6ae2b34fd3313e6584", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 29 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
Write(await Html.PartialAsync("_admNavbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    <h2><strong>Edit: </strong> ");
#nullable restore
#line 32 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
                           Write(Model.movie.movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h2>\r\n\r\n    <div class=\"container\" id=\"container\">\r\n        <div class=\"form-container sign-in-container\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c8f9acc2307c58864016857e6ae2b34fd3313e7569", async() => {
                    WriteLiteral("\r\n                \r\n                <input name=\"MovieId\" action=\"/AdminMainPage/AdminMoviePage\" class=\"form-control\" type=\"number\"\r\n                    placeholder=\"MovieId\"");
                    BeginWriteAttribute("value", " value=\"", 1457, "\"", 1485, 1);
#nullable restore
#line 39 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
WriteAttributeValue("", 1465, Model.movie.movieId, 1465, 20, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" hidden/>\r\n                <br>\r\n                <label for=\"MovieName\">Movie Name</label>\r\n                <input name=\"MovieName\" action=\"/AdminMainPage/AdminMoviePage\" class=\"form-control\" type=\"text\"\r\n                    placeholder=\"MovieName\"");
                    BeginWriteAttribute("value", " value=\"", 1734, "\"", 1764, 1);
#nullable restore
#line 43 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
WriteAttributeValue("", 1742, Model.movie.movieName, 1742, 22, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" maxlength=""100"" required />
                <br>
                <label for=""MovieReleaseDate"">Movie Release Date</label>
                <input name=""MovieReleaseDate"" action=""/AdminMainPage/AdminMoviePage"" class=""form-control"" type=""date""
                    placeholder=""MovieReleaseDate""");
                    BeginWriteAttribute("value", " value=\"", 2061, "\"", 2098, 1);
#nullable restore
#line 47 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
WriteAttributeValue("", 2069, Model.movie.movieReleaseDate, 2069, 29, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" required />
                <br>
                <label for=""MovieDuration"">Movie Duration</label>
                <input name=""MovieDuration"" action=""/AdminMainPage/AdminMoviePage"" class=""form-control"" type=""number""
                    placeholder=""MovieDuration""");
                    BeginWriteAttribute("value", " value=\"", 2368, "\"", 2402, 1);
#nullable restore
#line 51 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
WriteAttributeValue("", 2376, Model.movie.movieDuration, 2376, 26, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" required />
                <br>
                <label for=""MovieTrailerUrl"">Movie Trailer Url</label>
                <input name=""MovieTrailerUrl"" action=""/AdminMainPage/AdminMoviePage"" class=""form-control"" type=""text""
                    placeholder=""MovieTrailerUrl""");
                    BeginWriteAttribute("value", " value=\"", 2679, "\"", 2715, 1);
#nullable restore
#line 55 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
WriteAttributeValue("", 2687, Model.movie.movieTrailerUrl, 2687, 28, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" maxlength=""150"" required />
                <br>
                <label for=""MovieSummary"">Movie Summary</label>
                <input name=""MovieSummary"" action=""/AdminMainPage/AdminMoviePage"" class=""form-control"" type=""textarea""
                    style=""resize: none; height: 200px;"" placeholder=""MovieSummary"" class=""form-control""
                    maxlength=""2000""");
                    BeginWriteAttribute("value", " value=\"", 3095, "\"", 3128, 1);
#nullable restore
#line 60 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
WriteAttributeValue("", 3103, Model.movie.movieSummary, 3103, 25, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" required />\r\n                <br>\r\n                \r\n                <input name=\"DirectorId\" action=\"/AdminMainPage/AdminMoviePage\" class=\"form-control\" type=\"number\"\r\n                    placeholder=\"DirectorId\"");
                    BeginWriteAttribute("value", " value=\"", 3343, "\"", 3374, 1);
#nullable restore
#line 64 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
WriteAttributeValue("", 3351, Model.movie.directorId, 3351, 23, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@"  hidden/>
                    <br>
                <label for=""DirectorFirstName"">Director FirstName</label>
                <input name=""DirectorFirstName"" action=""/AdminMainPage/AdminMoviePage"" class=""form-control"" type=""text""
                    placeholder=""DirectorFirstName""");
                    BeginWriteAttribute("value", " value=\"", 3660, "\"", 3712, 1);
#nullable restore
#line 68 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
WriteAttributeValue("", 3668, Model.movie.movieDirector.directorFirstName, 3668, 44, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" maxlength=""20"" required />
                
<br>
                <label for=""DirectorLastName"">Director Lastname</label>
                <input name=""DirectorLastName"" action=""/AdminMainPage/AdminMoviePage"" class=""form-control"" type=""text""
                    placeholder=""DirectorLastName""");
                    BeginWriteAttribute("value", " value=\"", 4009, "\"", 4060, 1);
#nullable restore
#line 73 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
WriteAttributeValue("", 4017, Model.movie.movieDirector.directorLastName, 4017, 43, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" maxlength=\"20\" required />\r\n                <br>\r\n\r\n                <div class=\"container\">\r\n");
#nullable restore
#line 77 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
                     if (Model.movie.isShowing == true)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                        <input type=""radio"" id=""showing"" name=""MovieIsShowing"" value=""1"" checked>
                        <label for=""showing"">Is Showing</label><br>
                        <input type=""radio"" id=""not showing"" name=""MovieIsShowing"" value=""0"">
                        <label for=""not showing"">Not Showing</label><br>
");
#nullable restore
#line 83 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                        <input type=""radio"" id=""showing"" name=""MovieIsShowing"" value=""1"">
                        <label for=""showing"">Is Showing</label><br>
                        <input type=""radio"" id=""not showing"" name=""MovieIsShowing"" value=""0"" checked>
                        <label for=""not showing"">Not Showing</label><br>
");
#nullable restore
#line 90 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                </div>
                <br>
                <label for=""MoviePhotoUrl"">Movie Photo Url</label>
                <input name=""MoviePhotoUrl"" action=""/AdminMainPage/AdminMoviePage"" class=""form-control"" type=""text""
                    placeholder=""MoviePhotoUrl""");
                    BeginWriteAttribute("value", " value=\"", 5282, "\"", 5316, 1);
#nullable restore
#line 95 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
WriteAttributeValue("", 5290, Model.movie.moviePhotoUrl, 5290, 26, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" maxlength=""300"" required />
                <br>
                <label for=""MoviePosterUrl"">Movie Poster Url</label>
                <input name=""MoviePosterUrl"" action=""/AdminMainPage/AdminMoviePage"" class=""form-control"" type=""text""
                    placeholder=""MoviePosterUrl""");
                    BeginWriteAttribute("value", " value=\"", 5605, "\"", 5640, 1);
#nullable restore
#line 99 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
WriteAttributeValue("", 5613, Model.movie.moviePosterUrl, 5613, 27, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" maxlength=""300"" required />

                <!-- KATEGORİ DEĞİŞTİRSİN Mİ DEĞİŞTİRSİN KNK? B==D -->
                <br>
                <label for=""MovieCategory"">Movie Category</label>
                <div class=""form-group mt-4"">


                    <select name=""MovieCategoryId"" required class=""form-select"" id=""sessionSelect"">
                        
");
#nullable restore
#line 109 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
                 foreach (Category item in Model.allCategories)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
                         if (Model.movie.movieCategory.Equals(item.categoryName))
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c8f9acc2307c58864016857e6ae2b34fd3313e18400", async() => {
#nullable restore
#line 114 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
                                                               Write(item.categoryName);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
                                       WriteLiteral(item.categoryId);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 115 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
                        }
                        else{

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c8f9acc2307c58864016857e6ae2b34fd3313e21066", async() => {
#nullable restore
#line 117 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
                                                      Write(item.categoryName);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
                              WriteLiteral(item.categoryId);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 118 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
                         
                    } 

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </select>\r\n                </div>\r\n\r\n                \r\n                <br>\r\n                <button class=\"btn btn-primary btn-sm mr-2\" type=\"submit\">Edit Movie</button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    ");
#nullable restore
#line 136 "C:\Users\pc\Desktop\CINEMA\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminMoviePage.cshtml"
Write(await Html.PartialAsync("_footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\"\r\n        integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\"\r\n        crossorigin=\"anonymous\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cinema.Management.System.ViewModels.MovieCreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
