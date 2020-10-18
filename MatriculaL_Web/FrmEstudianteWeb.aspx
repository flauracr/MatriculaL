<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmEstudianteWeb.aspx.cs" Inherits="MatriculaL_Web.FrmEstudianteWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="hojasestilo/bootstrap.min.css" rel="stylesheet" />
    <link href="hojasestilo/estilos.css" rel="stylesheet" />
    <%--<style>
        #form1 {
            margin:10px auto;
            width:70%;
        }
    </style>--%>
    <script type="text/javascript">
        function mostrarMensaje(mensaje) {
            alert(mensaje);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <%--inicia el menu--%>
            <nav class="navbar navbar-expand-lg navbar-light bg-light">
                <a class="navbar-brand" href="#">Sistema de Matrícula-Universidad JYM</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                    <div class="navbar-nav">
                        <a class="nav-link active" href="Default.aspx">Inicio<span class="sr-only">(current)</span></a>
                        <a class="nav-link" href="FrmEstudianteWeb.aspx">Estudiantes</a>
                        <a class="nav-link" href="FrmProfesorWeb.aspx">Profesores</a>
                        <a class="nav-link" href="FrmMateriasWeb.aspx">Materias</a>
                        <<a class="nav-link" href="FrmAbrirMaterias.aspx">Abrir Materias</a>
                        <a class="nav-link" href="FrmMatricula.aspx">Matrícula</a>
                    </div>
                  </div>
            </nav>
            <%--finaliza el menu--%>
            
            <br />
           
            <h5>Mantenimiento de estudiantes</h5>
            <hr />
            <br />
            
            
            Nombre de estudiante: <asp:TextBox ID="txtnombre" runat="server" Width="238px" class="form-control form-control-sm"></asp:TextBox><br />
            &nbsp;
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" class="btn btn-primary" />
            <asp:Button ID="btnAtras" runat="server" Text="Atras" OnClick="btnAtras_Click" class="btn btn-primary"/>
             <asp:Button ID="btnAgregar" runat="server" Text="Agregar Nuevo" OnClick="btnAgregar_Click" class="btn btn-primary"/>
            
            <br />
            <br />
            <hr />
            
            <br />
            <br />
            <asp:GridView ID="grdLista" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="3" EmptyDataText="&quot;No existen registros para mostrar&quot;" OnPageIndexChanged="grdLista_PageIndexChanged" Width="100%" OnPageIndexChanging="grdLista_PageIndexChanging" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="linkModificar" runat="server" CommandArgument='<%# Eval("ID_ESTUDIANTE").ToString() %>' CommandName="Modificar" OnCommand="linkModificar_Command1">Modificar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="linkEliminar" runat="server" CommandArgument='<%# Eval("ID_ESTUDIANTE").ToString() %>' CommandName="Eliminar" OnCommand="linkEliminar_Command">Eliminar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ID_ESTUDIANTE" HeaderText="Id" />
                    <asp:BoundField DataField="CEDULA_ESTUDIANTE" HeaderText="CedulaEstudiante" />
                    <asp:BoundField DataField="NOMBRE_ESTUDIANTE" HeaderText="NombreEstudiante" />
                    <asp:BoundField DataField="PRIMER_APELLIDO_E" HeaderText="PrimerApellidoEstudiante" />
                    <asp:BoundField DataField="SEGUNDO_APELLIDO_E" HeaderText="SegundoApellidoEstudiante" />
                    <asp:BoundField DataField="TELEFONO_ESTUDIANTE" HeaderText="TelefonoEstudiante" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            
        </div>
            <footer>
                <p>"Sistema de Matrícula - Universidad J&M - Elaborado por Laura Fonseca Rojas, 2020"</p>
            </footer>
    </form>
</body>
</html>
