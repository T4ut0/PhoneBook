<%@ Page Title="" Language="C#" MasterPageFile="~/user.Master" AutoEventWireup="true" CodeBehind="mycontact.aspx.cs" Inherits="PhoneBook.mycontact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
     <div class="row small-spacing">
            <div class="col-lg-12 col-xs-12">
                <div class="box-content card white">
                    <h4 class="box-title">My Contacts</h4>

                    <table class="table">
                           <tr>
                               <td>
                                    <label for="firstname">FirstName</label>
                               </td>
                               <td> <asp:TextBox ID="firstname" runat="server" class="form-control" placeholder="Enter First Name"></asp:TextBox> </td>
                               <td>
                                    <asp:Button ID="b1" runat="server" Text="Search" class="btn btn-success btn-sm waves-effect waves-light" OnClick="b1_Click"/>
                               </td>
                           </tr>
                    </table>

                    <asp:Repeater ID="r1" runat="server">

                        <HeaderTemplate>
                            <table class="table table-bordered">
                                <tr>
                                    <th>firstname</th>
                                    <th>lastname</th>
                                    <th>contactno</th>
                                    <th>email</th>
                                    <th>address</th>
                                    <th>city</th>
                                </tr>
                        </HeaderTemplate>

                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("firstname") %></td>
                                <td><%#Eval("lastname") %></td>
                                <td><%#Eval("contactno") %></td>
                                <td><%#Eval("email") %></td>
                                <td><%#Eval("resident_address") %></td>
                                <td><%#Eval("city") %></td>
                                <td>
                                    <a href="edit.aspx?id=<%#Eval("id") %>"><img src="assets/images/edit.png" height="30" width="30" /></a>
                                    <a href="delete.aspx?id=<%#Eval("id") %>"><img src="assets/images/delete.png" height="30" width="30" /></a>

                                </td>
                                
                            </tr>

                        </ItemTemplate>

                        <FooterTemplate>

                            </table>
                        </FooterTemplate>


                    </asp:Repeater>
                </div>
            </div>
     </div>

</asp:Content>
