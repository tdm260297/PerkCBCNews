<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CBCNews.aspx.cs" Inherits="Default.CBCNews" %>

<!DOCTYPE html>
<html>
<head>
    <title>Top CBC News Stories</title>
</head>
<body>
    <div>
        <h1>Top CBC News Stories</h1>
        <asp:Repeater ID="rptNews" runat="server">
  <ItemTemplate>
    <div class="news-item">
      <img src='<%# Eval("ImageUrl") %>' alt='<%# Eval("Title") %>' />
      <h2><%# Eval("Title") %></h2>
      <p><%# Eval("Description") %></p>
      <span><%# Eval("Author") %></span>
    </div>
  </ItemTemplate>
</asp:Repeater>

    </div>
</body>
</html>
