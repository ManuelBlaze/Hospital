<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paciente.aspx.cs" Inherits="Hospital.Paciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Paciente</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous"/>
    <style type="text/css">
        .auto-style1 {
            left: 0px;
            top: 3px;
        }
    </style>
    <script src="https://kit.fontawesome.com/5bd7cc0966.js" crossorigin="anonymous"></script>
</head>
<body class="bg-light">
    <form id="form1" runat="server" class="mx-auto col-md-8">
        <div class="container">
            <p class="text-center">&nbsp;</p>
            <p class="text-center">&nbsp;</p>
            <h1 class="text-center">Paciente</h1>
            <p class="text-center">&nbsp;</p>
            <div class="form-row ">
                <div class="form-group col-md-3.5 " style="text-align: center">
                    <label for="txtIDPac">ID Paciente</label>
                    <asp:TextBox ID="txtIDPac" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-6 " style="text-align: center">
                    <label for="txtNomPac">Nombre Paciente</label>
                    <asp:TextBox ID="txtNomPac" runat="server" class="form-control"></asp:TextBox>
                </div>              
                <div class="form-group col-md-3" style="left: 0px; top: 0px; text-align: center">
                    <label for="txtTipoIDPac">Tipo de Documento</label>
                    <asp:TextBox ID="txtTipoIDPac" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label for="txtDireccionPac">Dirección</label>
                <asp:TextBox ID="txtDireccionPac" runat="server" class="form-control" placeholder="1234 Main St"></asp:TextBox>
            </div>
            <div class="form-row">
                <div class="form-group col-md-4">
                  <label for="txtTelPac">Teléfono(fijo)</label>
                  <asp:TextBox ID="txtTelPac" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                  <label for="txtCelPac">Celular</label>
                  <asp:TextBox ID="txtCelPac" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group"> 
                <asp:Button ID="cmdConsultarPac" runat="server" Text="Consultar" class="btn btn-outline-primary mr-5" OnClick="cmdConsultarPac_Click" />
                <asp:Button ID="cmdIngresarPac" runat="server" Text="Ingresar" class="btn btn-outline-warning" OnClick="cmdIngresarPac_Click" />
            </div>
            <asp:Label ID="lblConfirmarPac" runat="server" Text="Consulte antes de ingresar el Paciente"></asp:Label>
        </div>
    </form>
    &nbsp;
    <div class="row m-0 justify-content-center align-items-center ">

        <a class="btn btn-danger" href="https://github.com/ManuelBlaze" target="_blank"><i class="fab fa-github"></i> Manuel Alejandro Escobar Mira</a>
     </div>
    &nbsp;
</body>
</html>
