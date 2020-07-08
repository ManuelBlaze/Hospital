<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medico.aspx.cs" Inherits="Hospital.Medico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Médico</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous"/>
    <script src="https://kit.fontawesome.com/5bd7cc0966.js" crossorigin="anonymous"></script>
</head>
<body class="bg-light">
    <form id="form1" runat="server" class="mx-auto col-md-8">
        <div class="container">
            <p class="text-center">&nbsp;</p>
            <p class="text-center">&nbsp;</p>
            <h1 class="text-center">Médico</h1>
            <p class="text-center">&nbsp;</p>
            <div class="form-row">
                <div class="form-group col-md-4">
                  <label for="txtIDMed">ID Médico</label>
                  <asp:TextBox ID="txtIDMed" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-8 " style="text-align: center">
                    <label for="txtNomMed">Nombre Médico</label>
                    <asp:TextBox ID="txtNomMed" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-row ">
                <div class="form-group col-md-4">
                  <label for="txtTelMed">Teléfono</label>
                  <asp:TextBox ID="txtTelMed" runat="server" class="form-control"></asp:TextBox>
                </div>  
                
                <div class="form-group col-md-6 " style="text-align: center">
                    <label for="txtEspecialidadMed">Especialidad</label>
                    <asp:TextBox ID="txtEspecialidadMed" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            
            <div class="form-group"> 
                <asp:Button ID="cmdConsultarMed" runat="server" Text="Consultar" class="btn btn-outline-primary mr-5" OnClick="cmdConsultarMed_Click" />
                <asp:Button ID="cmdIngresarMed" runat="server" Text="Ingresar" class="btn btn-outline-success" OnClick="cmdIngresarMed_Click" />
            </div>
            <asp:Label ID="lblConfirmarMed" runat="server" Text="Consulte antes de ingresar Médico"></asp:Label>
        </div>
    </form>
    &nbsp;
    <div class="row m-0 justify-content-center align-items-center ">

        <a class="btn btn-danger" href="https://github.com/ManuelBlaze/Hospital" target="_blank"><i class="fab fa-github"></i> Manuel Alejandro Escobar Mira</a>
     </div>
    &nbsp;
</body>
</html>
