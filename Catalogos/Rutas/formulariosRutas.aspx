<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="formulariosRutas.aspx.cs" Inherits="Transportes_3_capas.Catalogos.Rutas.formulariosRutas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h3>
                <asp:Label ID="Titulo" runat="server" Text=""></asp:Label>
            </h3>
            <h4>
                <asp:Label ID="Subtitulo" runat="server" Text=""></asp:Label>
            </h4>
        </div>

        <div class="row col-md-5">

            <div class="col-md-12">
                <%--Formulario--%>
                <%--Etiquetado--%>
                <asp:Label ID="lbldistancia" runat="server" Text="">Distancia</asp:Label>
                <%--Campo--%>
                <asp:TextBox ID="txtdistancia" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="lblcamion" runat="server" Text="">camion</asp:Label>
                <%--Campo--%>
                <asp:DropDownList ID="ddlcamion" runat="server" CssClass="form-control"></asp:DropDownList>
                <%--Etiquetado--%>
                <asp:Label ID="lblchofer" runat="server" Text="">Chofer</asp:Label>
                <%--Campo--%>
                <asp:DropDownList ID="dllchofer" runat="server" CssClass="form-control"></asp:DropDownList>

                <asp:Label ID="Label1" runat="server" Text="">Cargamento</asp:Label>
                <%--Campo--%>
                <asp:DropDownList ID="ddlcargamento" runat="server" CssClass="form-control"></asp:DropDownList>


                <%--Etiquetado--%>
                <asp:Label ID="lblorigen" runat="server" Text="">origen</asp:Label>
                <%--Campo--%>
                <asp:DropDownList ID="ddlorigen" runat="server" CssClass="form-control"></asp:DropDownList>
                <%--Etiquetado--%>

                <asp:Label ID="lbldestino" runat="server" Text="">destino</asp:Label>
                <%--Campo--%>
                <asp:DropDownList ID="ddldestino" runat="server" CssClass="form-control"></asp:DropDownList>

            </div>
            <br />
            <br />
            <%--Calendarios--%>
            <div class="row">

                <div class="col-md-6">
                    <h5>
                        <asp:Label ID="lblsalida" runat="server" Text="Fecha de Salida"></asp:Label>
                    </h5>
                    <asp:Calendar ID="calsalida" runat="server" OnSelectionChanged="calsalida_SelectionChanged"></asp:Calendar>
                </div>
                <div class="col-md-6">
                    <h5>
                        <asp:Label ID="lblestimada" runat="server" Text="Fecha Estimada de Llegada"></asp:Label>
                    </h5>
                    <asp:Calendar ID="calestimada" runat="server"></asp:Calendar>
                </div>
            </div>
            <br />
            <asp:Button ID="btnGuardar" CssClass="btn btn-primary btn-sm" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </div>
</asp:Content>
