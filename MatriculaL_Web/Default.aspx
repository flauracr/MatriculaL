<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MatriculaL_Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="hojasestilo/bootstrap.min.css" rel="stylesheet" />
    <link href="hojasestilo/estilos.css" rel="stylesheet" />
    
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
           <%-- inicia el carrussel--%>
            <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="imagenes/estudiantes1.jpg" class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="imagenes/estudiantes2.jpg" class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="imagenes/estudiantes.jpg" class="d-block w-100" alt="...">
                    </div>
                    </div>
                        <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="sr-only">Previous</span>
                        </a>
                        <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="sr-only">Next</span>
                        </a>
            </div>
        <%--    finaliza el carrusel--%>
            <br />
            <br />
            <hr />
            <div>
                <div class="card text-white bg-dark mb-3" style="max-width: 18rem; float:left; margin:10px 35px">
                    <div class="card-header">Informática</div>
                        <div class="card-body">
                            <h5 class="card-title"></h5>
                            <p class="card-text">Universidad JYM ofrece cursos gratis de Informática Básica, Intemedia y Avanzada.</p>
                        </div>
                </div>
                <div class="card text-white bg-dark mb-3" style="max-width: 18rem; float:left; margin:10px 35px">
                    <div class="card-header">Inglés</div>
                        <div class="card-body">
                            <h5 class="card-title"></h5>
                            <p class="card-text">Universidad JYM ofrece cursos gratis de Inglés Básico, Intemedio y Avanzado.</p>
                        </div>
                </div>
                <div class="card text-white bg-dark mb-3" style="max-width: 18rem; float:left; margin:10px 36px">
                    <div class="card-header">Contabilidad</div>
                        <div class="card-body">
                            <h5 class="card-title"></h5>
                            <p class="card-text">Universidad JYM oferce cursos gratis de Contabilidad Básica, Intemedia y Avanzada.</p>
                        </div>
                </div>

            </div>   
            <br />
            <br />
            </div>
            <footer>
                <p>"Sistema de Matrícula - Universidad J&M - Elaborado por Laura Fonseca Rojas, 2020"</p>
            </footer>

    </form>
    
    
    <script src="javascript/jquery.js"></script>
    <script src="javascript/bootstrap.min.js"></script>
  
</body>
</html>
