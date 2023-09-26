<%@ Page Title="" Language="C#" MasterPageFile="~/EpicEdil.Master" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="EpicEdil.Insert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row fs-3 mt-3">
        <div class="col-12">
            <h2 class="text-center">Inserisci un nuovo dipendente</h2>
        </div>
        <div class="d-flex flex-column gap-3 mt-2">
            <div class="col-12 d-flex gap-3 justify-content-center">
                <div class="d-flex flex-column">
                    <p class="m-0">Nome</p>
                    <asp:TextBox ID="NomeBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="d-flex flex-column">
                    <p class="m-0">Cognome</p>
                    <asp:TextBox ID="CognomeBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-12 d-flex gap-3 justify-content-center">
                <div class="d-flex flex-column">
                    <p class="m-0">Indirizzo</p>
                    <asp:TextBox ID="IndirizzoBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="d-flex flex-column">
                    <p class="m-0">Codice Fiscale</p>
                    <asp:TextBox ID="CdfBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-12 d-flex gap-3 justify-content-center">
                <div class="d-flex flex-column">
                    <p class="m-0">Mansione</p>
                    <asp:TextBox ID="MansioneBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="d-flex flex-column">
                    <p class="m-0">Numero Figli</p>
                    <asp:TextBox ID="FigliBox" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-12 d-flex gap-3 justify-content-center">
                <div class="d-flex form-control w-50 mt-2">
                    <p class="m-0">Sposato?</p>
                    <asp:CheckBox ID="SposatoBox" runat="server" CssClass="form-check" />
                </div>
            </div>
            <div class="col-12 text-center mt-2">
                <asp:Button ID="Inserisci" runat="server" Text="Inserisci Dipendente" OnClick="Inserisci_Click" CssClass="w-50 btn btn-success" />
            </div>
        </div>
    </div>
</asp:Content>
