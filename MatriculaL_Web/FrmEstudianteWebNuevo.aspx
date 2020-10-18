<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmEstudianteWebNuevo.aspx.cs" Inherits="MatriculaL_Web.FrmEstudianteWebNuevo" %>

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
                        <a class="nav-link" href="FrmAbrirMaterias.aspx">Abrir Materias</a>
                        <a class="nav-link" href="FrmMatricula.aspx">Matrícula</a>
                    </div>
                  </div>
            </nav>
            <%--finaliza el menu--%>
            <br />
            <h5>Nuevo estudiante:</h5>
            <hr />
          
            Id:<asp:TextBox ID="txtid" runat="server" ReadOnly="True" class="form-control form-control-sm"></asp:TextBox>
            Cedula:<asp:TextBox ID="txtCedula" runat="server" class="form-control form-control-sm"></asp:TextBox>
            Nombre:<asp:TextBox ID="txtNombre" runat="server" class="form-control form-control-sm"></asp:TextBox>
            Apellido1:<asp:TextBox ID="txtApellido1" runat="server" class="form-control form-control-sm"></asp:TextBox>
            Apellido2:<asp:TextBox ID="txtApellido2" runat="server" class="form-control form-control-sm"></asp:TextBox>
            Telefono:<asp:TextBox ID="txtTelefono" runat="server" class="form-control form-control-sm"></asp:TextBox>
            Correo:<asp:TextBox ID="txtCorreo" runat="server" class="form-control form-control-sm"></asp:TextBox>
            <br />
            
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click1" class="btn btn-primary"/>
            <asp:Button ID="btnAtras" runat="server" Text="Atras" OnClick="btnAtras_Click" class="btn btn-primary"/>

        </div>
            <footer>
                <p>"Sistema de Matrícula - Universidad J&M - Elaborado por Laura Fonseca Rojas, 2020"</p>
            </footer>
    </form>
</body>
</html>
