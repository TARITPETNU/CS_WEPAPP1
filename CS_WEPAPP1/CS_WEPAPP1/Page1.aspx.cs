using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_WEPAPP1
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //checkAge(int.Parse(Request.Cookies["userSetting"].Value));
            if (readSeesioon() != 0)
            {
                checkAge(readSeesioon());
            }
           
        }

        protected void Click__Click(object sender, EventArgs e)
        {
            //showTxt.Text = "Welcome";
            int age = DateTime.Now.Year - int.Parse(date_.Text);
            // writeCookie(age);
            //checkAge(int.Parse(Request.Cookies["userSetting"].Value));
            writeSeesion(age);
            checkAge(readSeesioon());
        }
        private void writeCookie(int age)
        {
            HttpCookie userCookie = new HttpCookie("userSetting");
            userCookie.Value = age.ToString();
            userCookie.Expires = DateTime.Now.AddDays(2d);
            Response.Cookies.Add(userCookie);
        }
        private int readCookie()
        {
            HttpCookie userCookie = Request.Cookies["userSetting"];
            return int.Parse(userCookie.Value);
        }
        private void checkAge(int age)
        {
            if (age > 18)
            {
                Server.Transfer("Page2.aspx");
                // Response.Redirect("Page2.aspx");
            }
            else
            {
                Response.Write("Error");
            }
        }
        private void writeSeesion(int Age)
        {
            Session["userAge"] = Age;
        }
        private int readSeesioon()
        {
            if (Session["userAge"] == null)
            {
                return 0;
            }
            return int.Parse(Session["userAge"].ToString());
        }
    }
}