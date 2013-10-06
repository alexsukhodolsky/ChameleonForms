﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.32559
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChameleonForms.Templates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 1 "..\..\Templates\HtmlHelpers.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Templates\HtmlHelpers.cshtml"
    using Component.Config;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Templates\HtmlHelpers.cshtml"
    using Enums;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Templates\HtmlHelpers.cshtml"
    using Templates;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public class HtmlHelpers : System.Web.WebPages.HelperPage
    {

#line 10 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndForm() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 10 "..\..\Templates\HtmlHelpers.cshtml"
                   


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </form>\r\n");


#line 12 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 12 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 14 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginSection(IHtmlString title, IHtmlString leadingHtml, HtmlAttributes htmlAttributes) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 14 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                                 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <fieldset");


#line 15 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, htmlAttributes);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        <legend>");


#line 16 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</legend>\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 17 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, leadingHtml);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dl>\r\n");


#line 19 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 19 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 21 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginNestedSection(IHtmlString title, IHtmlString leadingHtml, HtmlAttributes htmlAttributes)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 22 "..\..\Templates\HtmlHelpers.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <dt>");


#line 23 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "            <dd>\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 25 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, leadingHtml);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "                <dl");


#line 26 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, htmlAttributes);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 27 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 27 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 29 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndSection() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 29 "..\..\Templates\HtmlHelpers.cshtml"
                      


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        </dl>\r\n");

WriteLiteralTo(__razor_helper_writer, "    </fieldset>\r\n");


#line 32 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 32 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 34 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndNestedSection() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 34 "..\..\Templates\HtmlHelpers.cshtml"
                            


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                </dl>\r\n");

WriteLiteralTo(__razor_helper_writer, "            </dd>\r\n");


#line 37 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 37 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 39 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult GetPrependedHtml(IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 39 "..\..\Templates\HtmlHelpers.cshtml"
                                                                          
    if (fieldConfiguration != null) {
        foreach (var html in fieldConfiguration.PrependedHtml) {

#line default
#line hidden

#line 41 "..\..\Templates\HtmlHelpers.cshtml"
                                  WriteTo(__razor_helper_writer, html);


#line default
#line hidden

#line 41 "..\..\Templates\HtmlHelpers.cshtml"
                                                                     }
    }


#line default
#line hidden
});

#line 43 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 45 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult GetAppendedHtml(IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 45 "..\..\Templates\HtmlHelpers.cshtml"
                                                                         
    if (fieldConfiguration != null) {
        foreach (var html in fieldConfiguration.AppendedHtml) {

#line default
#line hidden

#line 47 "..\..\Templates\HtmlHelpers.cshtml"
                                 WriteTo(__razor_helper_writer, html);


#line default
#line hidden

#line 47 "..\..\Templates\HtmlHelpers.cshtml"
                                                                    }
    }


#line default
#line hidden
});

#line 49 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 51 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult GetHint(IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 51 "..\..\Templates\HtmlHelpers.cshtml"
                                                                 
    if (fieldConfiguration != null && fieldConfiguration.Hint != null) {

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<div");

WriteLiteralTo(__razor_helper_writer, " class=\"hint\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 52 "..\..\Templates\HtmlHelpers.cshtml"
                                                            WriteTo(__razor_helper_writer, fieldConfiguration.Hint);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>");


#line 52 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                                                        }


#line default
#line hidden
});

#line 53 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 55 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginFieldInternal(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml, IReadonlyFieldConfiguration fieldConfiguration, ModelMetadata fieldMetadata, IHtmlString requiredDesignator) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 55 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                                                                                                                                                     


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <dt>");


#line 56 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, labelHtml);


#line default
#line hidden

#line 56 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, new HtmlString(fieldMetadata != null && fieldMetadata.IsRequired ? requiredDesignator.ToHtmlString() : ""));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "            <dd>\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 58 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, GetPrependedHtml(fieldConfiguration));


#line default
#line hidden

#line 58 "..\..\Templates\HtmlHelpers.cshtml"
                         WriteTo(__razor_helper_writer, elementHtml);


#line default
#line hidden

#line 58 "..\..\Templates\HtmlHelpers.cshtml"
                                     WriteTo(__razor_helper_writer, GetAppendedHtml(fieldConfiguration));


#line default
#line hidden

#line 58 "..\..\Templates\HtmlHelpers.cshtml"
                                                                         WriteTo(__razor_helper_writer, GetHint(fieldConfiguration));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 58 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                                      WriteTo(__razor_helper_writer, validationHtml);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 59 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 59 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 61 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult Field(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration, IHtmlString requiredDesignator) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 61 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                                                                                                                                        


#line default
#line hidden

#line 62 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, BeginFieldInternal(labelHtml, elementHtml, validationHtml, fieldConfiguration, fieldMetadata, requiredDesignator));


#line default
#line hidden

#line 62 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                                                  


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </dd>\r\n");


#line 64 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 64 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 66 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginField(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration, IHtmlString requiredDesignator)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 67 "..\..\Templates\HtmlHelpers.cshtml"
 


#line default
#line hidden

#line 68 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, BeginFieldInternal(labelHtml, elementHtml, validationHtml, fieldConfiguration, fieldMetadata, requiredDesignator));


#line default
#line hidden

#line 68 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                                                  


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <dl>\r\n");


#line 70 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 70 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 72 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndField() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 72 "..\..\Templates\HtmlHelpers.cshtml"
                    


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                </dl>\r\n");

WriteLiteralTo(__razor_helper_writer, "            </dd>\r\n");


#line 75 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 75 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 77 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult RequiredDesignator() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 77 "..\..\Templates\HtmlHelpers.cshtml"
                              


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " <em");

WriteLiteralTo(__razor_helper_writer, " class=\"required\"");

WriteLiteralTo(__razor_helper_writer, ">*</em>");


#line 78 "..\..\Templates\HtmlHelpers.cshtml"
                                         

#line default
#line hidden
});

#line 78 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 80 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginNavigation() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 80 "..\..\Templates\HtmlHelpers.cshtml"
                           


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div class=\"form_navigation\">\r\n");


#line 82 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 82 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 84 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndNavigation() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 84 "..\..\Templates\HtmlHelpers.cshtml"
                         


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        </div>\r\n");


#line 86 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 86 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 88 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginMessage(MessageType messageType, IHtmlString heading) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 88 "..\..\Templates\HtmlHelpers.cshtml"
                                                                    


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "      <div class=\"");


#line 89 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, string.Format("{0}{1}", messageType.ToString().ToLower(), "_message"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\">\r\n");


#line 90 "..\..\Templates\HtmlHelpers.cshtml"
            if (!string.IsNullOrEmpty(heading.ToHtmlString()))
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "          <h3>");


#line 92 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, heading);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</h3>\r\n");


#line 93 "..\..\Templates\HtmlHelpers.cshtml"
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "          <div class=\"message\">\r\n");


#line 95 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 95 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 97 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndMessage() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 97 "..\..\Templates\HtmlHelpers.cshtml"
                      


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "          </div>\r\n");

WriteLiteralTo(__razor_helper_writer, "      </div>\r\n");


#line 100 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 100 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 102 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult MessageParagraph(IHtmlString paragraph) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 102 "..\..\Templates\HtmlHelpers.cshtml"
                                                 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p>\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 104 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, paragraph);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "    </p>\r\n");


#line 106 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 106 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

#line 108 "..\..\Templates\HtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult List(IEnumerable<IHtmlString> items) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 108 "..\..\Templates\HtmlHelpers.cshtml"
                                              


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <ul>\r\n");


#line 110 "..\..\Templates\HtmlHelpers.cshtml"
foreach(var i in items) {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li>");


#line 111 "..\..\Templates\HtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, i);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 112 "..\..\Templates\HtmlHelpers.cshtml"
}


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </ul>\r\n");


#line 114 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
});

#line 114 "..\..\Templates\HtmlHelpers.cshtml"
}
#line default
#line hidden

    }
}
#pragma warning restore 1591
