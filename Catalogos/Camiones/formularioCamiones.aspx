<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="formularioCamiones.aspx.cs" Inherits="Transportes_3_capas.Catalogos.Camiones.formularioCamiones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <asp:Label ID="Titulo" runat="server" CssClass="text-center modal-tittle" Text=""></asp:Label>
            <asp:Label ID="Subtitulo" runat="server" CssClass="text-center modal-tittle" Text=""></asp:Label>
        </div>

        <div class="row">
            <div class="col-md-12">
                <%--Formulario--%>
                <div class="form-group">
                    <%--Etiquetado--%>
                    <asp:Label ID="lblmatricula" runat="server" Text="">Matricula</asp:Label>
                    <%--Campo--%>
                    <asp:TextBox ID="txtmatricula" runat="server" CssClass="form-control"></asp:TextBox>
                    <%--Etiquetado--%>
                    <asp:Label ID="lblcapacidad" runat="server" Text="">Capacidad</asp:Label>
                    <%--Campo--%>
                    <asp:TextBox ID="txtcapacidad" runat="server" CssClass="form-control"></asp:TextBox>
                    <%--Etiquetado--%>
                    <asp:Label ID="lblkilometraje" runat="server" Text="">kilometraje</asp:Label>
                    <%--Campo--%>
                    <asp:TextBox ID="txtkilometraje" runat="server" CssClass="form-control"></asp:TextBox><%--Etiquetado--%>
                    <asp:Label ID="lblmarca" runat="server" Text="">Marca</asp:Label>
                    <%--Campo--%>
                    <asp:TextBox ID="txtmarca" runat="server" CssClass="form-control"></asp:TextBox><%--Etiquetado--%>
                    <asp:Label ID="lblmodelo" runat="server" Text="">Modelo</asp:Label>
                    <%--Campo--%>
                    <asp:TextBox ID="txtmodelo" runat="server" CssClass="form-control"></asp:TextBox><%--Etiquetado--%>
                    <asp:Label ID="lbltipo_camion" runat="server" Text="">Tipo Camion</asp:Label>
                    <%--Campo--%>
                    <asp:TextBox ID="txttipo_camion" runat="server" CssClass="form-control"></asp:TextBox>

                    <br />
                    <br />
                    <asp:Label ID="lbldisponibilidad" runat="server" Text="">Disponibilidad</asp:Label>
                    <br />
                    <asp:CheckBox ID="chkdisponibilidad" runat="server" CssClass="form-control"/>
                    <br />
                    <br />

                    <asp:Label ID="lblimg" runat="server">Imagen</asp:Label>
                    <input type="file" id="subeimagen" runat="server" class="btn btn-group" />
                    <asp:Button ID="btnsubeimagen" runat="server" Text="SubirImagen" CssClass="btn btn-primary"
                        OnClick="btnsubeimagen_Click" />
                    <asp:Label ID="lblurlfoto" runat="server" Text="">Foto</asp:Label>
                    <asp:Image ID="imgfoto" Width="100" Height="100" runat="server" />
                    <asp:Image ID="imgcamion" Width="100" Height="100" runat="server" />
                    <asp:Label ID="urlfoto" runat="server"></asp:Label>


                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary"
                        OnClick="btnGuardar_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
