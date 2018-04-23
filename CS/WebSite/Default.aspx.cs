using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using DevExpress.Web.ASPxDataView;
using System.Text;
using DevExpress.Web.ASPxCallback;
using System.Xml;
using DevExpress.Web.ASPxTabControl;


public partial class ASPxperience_LoadOnCallback : System.Web.UI.Page {
    protected void LoadActiveTabPageContent() {
        TabPage activePage = ASPxPageControl1.ActiveTabPage;
        if(activePage.Controls.Count == 0) {
            Control contentControl = CreateTabPageContentControl(activePage.Name);
            if(contentControl != null)
                activePage.Controls.Add(contentControl);
        }
    }
    protected Control CreateTabPageContentControl(string name) {
        switch(name) {
            case "UserControl":
                return LoadControl("UserControl.ascx");
            case "ExternalPage":
                return LoadControl("ExternalPageUserControl.ascx");
            default:
                return null;
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        LoadActiveTabPageContent();
    }
    protected void ASPxPageControl1_ActiveTabChanged(object source, DevExpress.Web.ASPxTabControl.TabControlEventArgs e) {
        LoadActiveTabPageContent();
    }
}