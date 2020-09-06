using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConManApp.Models
{
    public class HelperDDlista
    {
        public  HtmlString Dropdown(string name,IEnumerable<SelectListItem> items,int selectedlistvalue, string clas)
        {
            string x = string.Empty;
            x += "<select name='" + name + "' class='" + clas + "'>";
            foreach(SelectListItem item in items)
            {
                if(item.Value==selectedlistvalue.ToString())
                {
                    x += "<option value='"+item.Value+"' selected>"+item.Text+"</option>";
                }
                else
                {
                    x += "<option value='" + item.Value + "'>" + item.Text + "</option>";
                }
            }
            x += "</select>";
            return new HtmlString(x);
        }
       public HelperDDlista()
        { }
    }
}
