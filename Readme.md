<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
* [ExternalPageUserControl.ascx](./CS/ExternalPageUserControl.ascx) (VB: [ExternalPageUserControl.ascx](./VB/ExternalPageUserControl.ascx))
* [ExternalPageUserControl.ascx.cs](./CS/ExternalPageUserControl.ascx.cs) (VB: [ExternalPageUserControl.ascx.vb](./VB/ExternalPageUserControl.ascx.vb))
* [UserControl.ascx](./CS/UserControl.ascx) (VB: [ExternalPageUserControl.ascx](./VB/ExternalPageUserControl.ascx))
* [UserControl.ascx.cs](./CS/UserControl.ascx.cs) (VB: [ExternalPageUserControl.ascx.vb](./VB/ExternalPageUserControl.ascx.vb))
<!-- default file list end -->
# How to create and load an active tab's content on a callback
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e10/)**
<!-- run online end -->


<p>This sample demonstrates how to create and load an active tab's content on a callback. This allows you to reduce Page_Load time on the server, because content hierarchy won't be created for invisible pages.</p><p>Please note that the technique demonstrated in the sample is viable only when displaying static content on a tab page - the content that is state-independent (i.e. not connected with ViewState, ControlState, CallbackState, or any other state). Examples of such a content include: text documents, messages, etc.</p>

<br/>


