<%@ Page Title="" Language="C#" MasterPageFile="~/EpicEdil.Master" AutoEventWireup="true" CodeBehind="PagamentoPage.aspx.cs" Inherits="EpicEdil.Pagamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt-3 fs-4">
        <div class="col-12">
            <h2 class="text-center">Effettua un nuovo pagamento</h2>
        </div>
        <div class="d-flex flex-column gap-2 mt-2">
            <div class="col-12 d-flex gap-3 justify-content-center">
                <div class="d-flex flex-column">
                    <p class="m-0">Data</p>
                    <asp:TextBox ID="DataBox" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="d-flex flex-column">
                    <p class="m-0">Importo</p>
                    <asp:TextBox ID="ImportoBox" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mt-2">
                    <p class="m-0">Stipendio?</p>
                    <asp:CheckBox ID="StipendioBox" runat="server" CssClass="form-check" />
                </div>
            </div>

            <div class="col-12 d-flex flex-column align-items-center ">
                <p class="m-0 text-center">Destinatario</p>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-select w-50 mt-2">
                </asp:DropDownList>
            </div>
            <div class="col-12 text-center mt-2">
                <asp:Button ID="Inserisci" runat="server" Text="Effettua Pagamento" OnClick="Inserisci_Click" CssClass="w-50 btn btn-success" />
            </div>
        </div>
    </div>
</asp:Content>
