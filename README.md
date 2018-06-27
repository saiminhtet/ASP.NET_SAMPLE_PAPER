# ASP.NET_SAMPLE_PAPER

For Section Question 1-E

 Difference between HTML control and Web Server control

HTML controls

HTML controls are the native browser elements and they are part of HTML language. These are client side controls which is accessible only in the HTML page, so it will improve the performance of the web page. HTML controls on an ASP.NET Web page are not available to the web server.

HTML Server controls

You can add the attribute runat="server" to any HTML control, such cases it will be an HTML server control. These controls map directly to html tags and without runat="server" it cannot access the control in code behind.

Web Server Controls or ASP.NET controls

Web Server Controls are group of controls derived directly from the System.Web.UI.WebControls base class. They are executed on the server side and output HTML sent back to the client browser. These controls are programmable and reusable that can perform function as the ordinary HTML controls. Web Server Controls can detect the target browser's capabilities and render themselves accordingly.

WServer Control Advantages

Server controls are easy to use and manage but HTML controls are not. Server control events are handled in the server side whereas HTML control events are handled in the client side browser only . It can maintain data across each requests using view state whereas HTML controls have no such mechanism to store data between user requests.


Another Example ------------------

In order to set values and modify these controls from .NET code (server-side), you need to right-click on them and select Run As Server Control, which introduces us to the server control concept. A server control is one that is run by ASP.NET, and available to .NET code in the code-behind or runat="server" script sections. Non-server controls (HTML) are not processed by ASP.NET. Rather, they are just design-time "views" of the underlying HTML source of the page itself.

Server controls can be either HTML Server Controls or Web Forms Controls (a.k.a. WebControls). The difference between the two is about functionality and design-time support. The latter have better designers, a more intuitive programming model, more OOP, can control their own rendering logic to better target the client platform, etc. So, if you need to access a control from .NET code, I'd say you should use WebControls. On the other hand, if you don't need to change a label text, a table configuration, etc., go for the the (non-server) HTML controls, which render faster and don't consume resources on the server for processing. 