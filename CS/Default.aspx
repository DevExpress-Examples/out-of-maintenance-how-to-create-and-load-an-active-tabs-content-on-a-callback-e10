<%-- BeginRegion Page setup --%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="ASPxperience_LoadOnCallback" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.12.0, Culture=neutral, PublicKeyToken=B88D1754D700E49A" Namespace="DevExpress.Web.ASPxEditors"
    TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.12.0, Culture=neutral, PublicKeyToken=B88D1754D700E49A" Namespace="DevExpress.Web.ASPxTabControl"
    TagPrefix="dxtc" %>
<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.12.0, Culture=neutral, PublicKeyToken=B88D1754D700E49A" Namespace="DevExpress.Web.ASPxClasses"
    tagprefix="dxw" %>


<%-- EndRegion --%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>How to create and load an active tab's content on a callback</title>
</head>
<body>
    <form id="form1" runat="server">
    
    <div>
        <dxtc:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" EnableCallBacks="True"
            Height="200px" Width="300px" OnActiveTabChanged="ASPxPageControl1_ActiveTabChanged">
            <TabPages>
                <dxtc:TabPage>
                </dxtc:TabPage>
                <dxtc:TabPage Name="UserControl" Text="User Control">
                </dxtc:TabPage>
                <dxtc:TabPage Name="ExternalPage" Text="External Page">
                </dxtc:TabPage>
            </TabPages>
        </dxtc:ASPxPageControl>
        &nbsp;&nbsp;<dxe:ASPxButton ID="ASPxButton1" runat="server" Text="PostBack">
        </dxe:ASPxButton>
    </div>
    </form>
</body>
</html>
