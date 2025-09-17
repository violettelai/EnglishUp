<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EnglishUp.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%--    <h2 id="title"><%: Title %></h2>
    <h3>Login page.</h3>--%>

        <div class="card shadow p-4" style="max-width: 400px; width: 100%;">
            <asp:Login ID="Login1" runat="server"
                onAuthenticate="LoginUser"
                FailureText="Invalid credentials."
                TitleText=""
                CssClass="w-100"
                TextBoxStyle-CssClass="form-control mb-3"
                LabelStyle-CssClass="form-label"
                CheckBoxStyle-CssClass="form-check-input"
                LoginButtonStyle-CssClass="btn btn-primary w-100">
                <LayoutTemplate>
                    <div class="d-flex flex-column align-items-center">
                        <div class="form-group w-100 mb-3 d-flex align-items-center">
                            <div style="width: 100px;">
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" CssClass="form-label mb-0">Username</asp:Label>
                            </div>
                            <div class="flex-grow-1">
                                <asp:TextBox ID="UserName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group w-100 mb-3 d-flex align-items-center">
                            <div style="width: 100px;">
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" CssClass="form-label mb-0">Password</asp:Label>
                            </div>
                            <div class="flex-grow-1">
                                <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="d-flex justify-content-center w-100">
                            <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" CssClass="btn btn-primary px-4 w-100" />
                        </div>

                        <div class="mt-3 text-danger">
                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                        </div>

                        <div class="w-100 d-flex justify-content-center">
                            <a class="text-decoration-underline">Forgot Password?</a>
                        </div>
                    </div>
                </LayoutTemplate>
            </asp:Login>
        </div>

  <%--  <div class="dropdown">
        <button class="btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButton1" data-bs-toggle="dropdown" aria-expanded="false">
            Dropdown button</button>
        <ul class="dropdown-menu" aria-labelledby="dropdownMenuButton1">
            <li><a class="dropdown-item" href="#">Action</a></li>
            <li><a class="dropdown-item" href="#">Another action</a></li>
            <li><a class="dropdown-item" href="#">Something else here</a></li>
        </ul>
    </div>--%>
</asp:Content>
