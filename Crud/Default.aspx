<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Crud._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:TextBox Text="0" ID="filtroIDtxt" runat="server" TextMode="Number" CssClass="input-group"></asp:TextBox>
        <asp:Button runat="server" OnClick="Filtro" CssClass="btn btn-sm btn-primary" Text="Filtrar"/>
    </div>
    
    <div class="row">
        <div class="col-12">
            <asp:GridView ID="GVEmpleado" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false">
                <columns>
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="City" HeaderText="City" />

                    <asp:TemplateField>
                        <itemtemplate>
                            <asp:LinkButton runat="server" CommandArgument='<%# Eval("PersonID") %>'
                                CssClass="btn btn-sm btn-primary">
                                Editar
                            </asp:LinkButton>

                            <asp:LinkButton runat="server" CommandArgument='<%# Eval("PersonID") %>'
                                CssClass="btn btn-sm btn-danger" >
                                Eliminar
                            </asp:LinkButton>
                        </itemtemplate>
                    </asp:TemplateField>

                </columns>

            </asp:GridView>
        </div>


    </div>


</asp:Content>
