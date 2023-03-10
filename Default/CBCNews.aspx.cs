using System;
using System.Data;
using System.Xml;
using System.Net;

namespace Default
{
    public partial class CBCNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string url = "http://www.cbc.ca/cmlink/rss-topstories";
                XmlDocument doc = new XmlDocument();
                doc.Load(url);
                XmlNodeList nodes = doc.SelectNodes("//item");
                DataTable dt = new DataTable();
                dt.Columns.Add("title", typeof(string));
                
                dt.Columns.Add("ImageUrl", typeof(string));

                dt.Columns.Add("description", typeof(string));
                dt.Columns.Add("author", typeof(string));
                foreach (XmlNode node in nodes)
                {
                    DataRow row = dt.NewRow();
                    row["title"] = node.SelectSingleNode("title").InnerText;
                    row["description"] = node.SelectSingleNode("description").InnerText;
                    row["author"] = node.SelectSingleNode("author").InnerText;
                    dt.Rows.Add(row);
                }
                rptNews.DataSource = dt;
                rptNews.DataBind();
            }
        }

    }
}
