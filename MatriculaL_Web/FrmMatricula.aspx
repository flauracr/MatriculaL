<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMatricula.aspx.cs" Inherits="MatriculaL_Web.FrmMatricula" %>

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
           
            
            Estudiantes activos:<asp:DropDownList ID="dlistEstudiantes" runat="server" class="form-control form-control-sm"></asp:DropDownList>
            <br />
          
            
            <br />
            <br />
            <asp:GridView ID="grdListaMatricula" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" EmptyDataText="“No existen registros para mostrar”:" Width="100%">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkModificar" runat="server" CommandArgument='<%# Eval("ID_MATRICULA ").ToString() %>' CommandName="Modificar" OnCommand="lnkModificar_Command1">Modificar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ID_MATRICULA" HeaderText="IdMatricula" />
                    <asp:BoundField DataField="CEDULA_ESTUDIANTE" HeaderText="CedulaEstudiante" />
                    <asp:BoundField DataField="FECHA_MATRICULA" HeaderText="FechaMatricula" />
                    <asp:BoundField DataField="ESTADO_MATRICULA" HeaderText="EstadoMatricula" />
                    <asp:BoundField DataField="OBSERVACIONES " HeaderText="Observaciones" />
                </Columns>
                <EmptyDataTemplate>
                    <asp:LinkButton ID="lnkModificar" runat="server" CommandName="Modificar" OnCommand="lnkModificar_Command">Modificar</asp:LinkButton>
                </EmptyDataTemplate>
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
        </div>
            <footer>
                <p>"Sistema de Matrícula - Universidad J&M - Elaborado por Laura Fonseca Rojas, 2020"</p>
            </footer>
    </form>
    
</body>
</html>
