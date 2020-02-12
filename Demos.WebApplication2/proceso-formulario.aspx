<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="proceso-formulario.aspx.cs" Inherits="Demos.WebApplication2.proceso_formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <br />
    <div class="container">
        <div class="row">
            <div class="col"></div>
            <div class="col-10">
                <h1>Proceso de Formulario</h1>
                <hr />
                <h3><b>Resultado:</b> <%=Mensaje%></h3>
                <br />
                <p><b>Nombre Completo:</b> <%=Nombre%> <%=Apellido1%> <%=Apellido2%></p>
            </div>
            <div class="col"></div>
        </div>
    </div>
</body>
</html>
