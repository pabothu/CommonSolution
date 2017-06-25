using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAngular.HtmlHelpers
{
    public static class CustomHelpers
    {
        public static MvcHtmlString MvcAngularModel(this HtmlHelper htmlhelper, string moduleName, string modelName, IHtmlString jsonModel)
        {
            var ScriptTag = new TagBuilder("script");
            ScriptTag.InnerHtml = "angular.module('" + moduleName + "', []).value('" + modelName + "',  " + jsonModel + ");";
            return MvcHtmlString.Create(ScriptTag.ToString(TagRenderMode.Normal));
        }
    }
}