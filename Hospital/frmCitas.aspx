<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCitas.aspx.cs" Inherits="Hospital.frmCitas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous"/>
    <title>Citas</title>
    <script src="https://kit.fontawesome.com/5bd7cc0966.js" crossorigin="anonymous"></script>
</head>
<body class="bg-light">
    <form id="form1" runat="server" class="mx-auto col-md-8">
        <div class="container">
            <p class="text-center">&nbsp;</p>
            <h1 class="text-center">Ingresar Cita</h1>
            <p class="text-center">&nbsp;</p>
            <div class="form-row ">
                <div class="form-group col-md-6 " style="text-align: center">
                    <label for="TextBox2">Codigo Cita</label>
                    <asp:TextBox ID="txtCodCita" runat="server" class="form-control" ToolTip="Ingrese código"></asp:TextBox>
                </div>
                <div class="form-group col-md-3.5 " style="text-align: center">
                    <label for="TextBox1">Fecha </label>
                    <asp:TextBox ID="txtFecha" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-3" style="left: 0px; top: 0px; text-align: center">
                    <label for="TextBox3">Hora </label>
                    <asp:TextBox ID="txtHora" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-3">
                    <label for="txtIdPaciente">ID Paciente</label>
                    <asp:TextBox ID="txtIdPaciente" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="lblBuscarPac">Nombre Paciente</label>
                    <asp:Label ID="lblBuscarPac" runat="server" Text="---------"></asp:Label>
                </div>
                <div class="form-group col-md-4">
                    <label for="lblTelPac">Télefono Paciente </label>
                    <asp:Label ID="lblTelPac" runat="server" Text="---------"></asp:Label>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-3">
                  <label for="TextBox5">ID Médico</label>
                  <asp:TextBox ID="txtIdMedico" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <label for="lblBuscarMed">Nombre Médico</label>
                    <asp:Label ID="lblBuscarMed" runat="server" Text="---------"></asp:Label>
                </div>
                <div class="form-group col-md-4">
                    <label for="lblEspMed">Especialidad Médico</label>
                    <asp:Label ID="lblEspMed" runat="server" Text="---------"></asp:Label>
            
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-4">
                  <label for="TextBox6">Valor Consulta</label>
                  <asp:TextBox ID="txtVlr" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                  <label for="TextBox6">Nombre Acompañante</label>
                  <asp:TextBox ID="txtNomAcomp" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label for="TextBox4">Diagnostico </label>
                <asp:TextBox ID="txtDiagnostico" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group"> 
                
                <asp:Button ID="confirmarCita" runat="server" Text="Confirmar Cita" class="btn btn-outline-success mr-5" OnClick="confirmarCita_Click" />
                <asp:Button ID="guardar" runat="server" Text="Guardar" class="btn btn-outline-warning ml-5" OnClick="guardar_Click" />
            </div>
            <div class="form-group"> 
                <asp:Label ID="lblConfirmar" runat="server" Text="Confirme la cita antes de Asignarla"></asp:Label>
                
                
            </div>
        </div>
    </form>
    &nbsp;
    <div class="row m-0 justify-content-center align-items-center ">

        <a class="btn btn-danger" href="https://github.com/ManuelBlaze/Hospital" target="_blank"><i class="fab fa-github"></i> Manuel Alejandro Escobar Mira</a>
     </div>
    &nbsp;
</body>
</html>
