<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listarRutas.aspx.cs" Inherits="Transportes_3_capas.Catalogos.Rutas.ListarRutas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h3>Lista de Rutas</h3>

            <asp:Button ID="Insertar" runat="server" Text="Crear" CssClass="btn btn-primary btn-xs" Width="55px" OnClick="Insertar_Click" />

        </div>
        <div class="row">
            <asp:GridView ID="GVRutas"
                runat="server"
                CssClass="table table-bordered table-striped tabe-condensed"
                AutoGenerateColumns="false"
                DataKeyNames="Id_Ruta"
                OnRowDeleting="GVRutas_RowDeleting"
                OnRowCommand="GVRutas_RowCommand">

                <Columns>
                    <asp:BoundField DataField="Id_Ruta" HeaderText="ID RUTA"
                        ItemStyle-Width="50px" ReadOnly="true" />
                    <asp:BoundField DataField="Distancia" HeaderText="Distancia"
                        ItemStyle-Width="50px" />
                    <asp:BoundField DataField="Fecha_salida" HeaderText="feceha de salida"
                        ItemStyle-Width="50px" ReadOnly="true" />
                    <asp:BoundField DataField="Fecha_llegada_estimada" HeaderText="feceha de llegada estimada"
                        ItemStyle-Width="50px" ReadOnly="true" />

                    <asp:BoundField DataField="Camion_id" HeaderText="Camion ID" ItemStyle-Width="50px" ReadOnly="true" />
                    <asp:BoundField DataField="Chofer_id" HeaderText="Chofer ID" ItemStyle-Width="50px" ReadOnly="true" />
                    <asp:BoundField DataField="Direccion_Origen_Id" HeaderText="Dirrecion Origen ID" ItemStyle-Width="50px" ReadOnly="true" />
                    <asp:BoundField DataField="Direccion_Destino_Id" HeaderText="Dirrecion Destino ID" ItemStyle-Width="50px" ReadOnly="true" />
                    <asp:BoundField DataField="Cargamento_id" HeaderText="Cargamento ID" ItemStyle-Width="50px" ReadOnly="true" />
                   
                    <asp:ButtonField ButtonType="Button"  CommandName="Select" HeaderText="Editar"   ShowHeader="true" 
                        Text="Editar" ControlStyle-CssClass="btn btn-primary btn-xs" ItemStyle-Width="50px"/>
                    
                    <asp:CommandField ButtonType="Button" HeaderText="Eliminar" ShowDeleteButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="50px" />

             
                </Columns>

            </asp:GridView>
        </div>
    </div>

</asp:Content>
