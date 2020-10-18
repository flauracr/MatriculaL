<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAbrirMaterias.aspx.cs" Inherits="MatriculaL_Web.FrmAbrirMaterias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="hojasestilo/bootstrap.min.css" rel="stylesheet" />
    <link href="hojasestilo/estilos.css" rel="stylesheet" />
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
                        <a class="nav-link" href="FrmAbrirMaterias.aspx">Abrir Materias</a>
                        <a class="nav-link" href="FrmMatricula.aspx">Matrícula</a>
                    </div>
                  </div>
            </nav>
            <%--finaliza el menu--%>

            <br />
            <h2>Módulo de Matrícula de estudiantes</h2>
            <hr />
            <br />
            Materias disponibles:<asp:DropDownList ID="dlistMaterias" runat="server" class="form-control form-control-sm" ></asp:DropDownList>
            <br />
           
            Profesores disponibles:<asp:DropDownList ID="dlistProfesores" runat="server" class="form-control form-control-sm"></asp:DropDownList>
            <br />
           
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click1" class="btn btn-primary"/>
            <br />
            <br />
            <asp:GridView ID="grdListaMA" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="5" OnPageIndexChanging="grdListaMA_PageIndexChanging" Width="100%">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkModificar" runat="server" CommandArgument='<%# Eval("ID_MATERIA_ABIERTA ").ToString() %>' CommandName="Modificar">Modificar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEliminar" runat="server" CommandArgument='<%# Eval("ID_MATERIA_ABIERTA ").ToString() %>' CommandName="Eliminar">Eliminar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ID_MATERIA_ABIERTA " HeaderText="Id" />
                    <asp:BoundField DataField="ID_MATERIA" HeaderText="IdMateria" />
                    <asp:BoundField DataField="CEDULA_PROFESOR" HeaderText="CedulaProfesor" />
                    <asp:BoundField DataField="CEDULA_PROFESOR" HeaderText="Grupo" />
                    <asp:BoundField DataField="CUPO" HeaderText="Cupo" />
                    <asp:BoundField DataField="ANIO" HeaderText="Anio" />
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
            <br />
            <hr />
            <br />
        </div>
    </form>
    <script src="javascript/jquery.js"></script>
    <script src="javascript/bootstrap.min.js"></script>
</body>
</html>
