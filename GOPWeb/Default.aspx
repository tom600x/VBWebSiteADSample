<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeFile="Default.aspx.vb" Inherits="Default1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 <dl>


  <dt>IsAuthenticated</dt> 
     <dd><%= HttpContext.Current.User.Identity.IsAuthenticated %></dd>
     <dt>AuthenticationType</dt> 
     <dd><%= HttpContext.Current.User.Identity.AuthenticationType %></dd>
     <dt>Name</dt> <dd><%= HttpContext.Current.User.Identity.Name %></dd>
   
 
 </dl>

</asp:Content>