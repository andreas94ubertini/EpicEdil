<%@ Page Title="" Language="C#" MasterPageFile="~/EpicEdil.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EpicEdil.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-12 text-center mt-2">
            <h2>Lista di tutti i dipendenti registrati</h2>
        </div>
        <div class="col-12 mt-3">

            <table class="table table-primary table-striped table-hover shadow-lg">
                <thead>
                    <tr>
                        <th scope="col">#Id</th>
                        <th scope="col">Nome</th>
                        <th scope="col">Cognome</th>
                        <th scope="col">Indirizzo</th>
                        <th scope="col">Codice Fiscale</th>
                        <th scope="col">Mansione</th>
                        <th scope="col">Sposato?</th>
                        <th scope="col">N Figli</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="RepeaterDipendenti" runat="server" ItemType="EpicEdil.Models.Dipendente">
                        <ItemTemplate>
                            <tr>
                                <th scope="row"><%#Item.IdDipendente %></th>
                                <td><%#Item.Nome %></td>
                                <td><%#Item.Cognome %></td>
                                <td><%#Item.Indirizzo %></td>
                                <td><%#Item.Cdf %></td>
                                <td><%#Item.Mansione %></td>
                                <td><i class="<%#Item.IconToUse() %>"></i></td>
                                <td><%#Item.Nfigli %></td>

                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
    <div class="col-12">
        <h2 class="text-center">Il resoconto dei pagamenti</h2>
    </div>
    <div class="col-12 mt-3">


        <table class="table table-primary table-striped table-hover shadow-lg">
            <thead>
                <tr>
                    <th scope="col">#IdPagamento</th>
                    <th scope="col">Data</th>
                    <th scope="col">Importo</th>
                    <th scope="col">Stipendio?</th>
                    <th scope="col">Dipendente</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="RepeaterPagamenti" runat="server" ItemType="EpicEdil.Models.Pagamento">
                    <ItemTemplate>
                        <tr>
                            <th scope="row"><%#Item.IdPagamento %></th>
                            <td><%#Item.Data.ToShortDateString() %></td>
                            <td><%#String.Format("{0:0.00 €}",Item.Importo) %></td>
                            <td><i class="<%#Item.IconToUse() %>"></i></td>
                            <td><%#Item.IdDipendente %></td>

                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>


</asp:Content>
