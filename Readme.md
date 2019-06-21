<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [ExternalPageUserControl.ascx](./CS/WebSite/ExternalPageUserControl.ascx) (VB: [ExternalPageUserControl.ascx](./VB/WebSite/ExternalPageUserControl.ascx))
* [ExternalPageUserControl.ascx.cs](./CS/WebSite/ExternalPageUserControl.ascx.cs) (VB: [ExternalPageUserControl.ascx.vb](./VB/WebSite/ExternalPageUserControl.ascx.vb))
* [UserControl.ascx](./CS/WebSite/UserControl.ascx) (VB: [UserControl.ascx](./VB/WebSite/UserControl.ascx))
* [UserControl.ascx.cs](./CS/WebSite/UserControl.ascx.cs) (VB: [UserControl.ascx.vb](./VB/WebSite/UserControl.ascx.vb))
<!-- default file list end -->
# How to create and load an active tab's content on a callback
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e10/)**
<!-- run online end -->


<p>This sample demonstrates how to create and load an active tab's content on a callback. This allows you to reduce Page_Load time on the server, because content hierarchy won't be created for invisible pages.</p><p>Please note that the technique demonstrated in the sample is viable only when displaying static content on a tab page - the content that is state-independent (i.e. not connected with ViewState, ControlState, CallbackState, or any other state). Examples of such a content include: text documents, messages, etc.</p>

<br/>


