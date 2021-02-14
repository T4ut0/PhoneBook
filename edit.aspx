<%@ Page Title="" Language="C#" MasterPageFile="~/user.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="PhoneBook.edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
     <div class="row small-spacing">
            <div class="col-lg-12 col-xs-12">
                <div class="box-content card white">
                    <h4 class="box-title">Update Contact</h4>

                    <div class="card-content">
                        
                            <div class="form-group">
                                <label for="firstname">FirstName</label>
                               
                                <asp:TextBox ID="firstname" runat="server" class="form-control" placeholder="Enter First Name"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="lastname">LastName</label>
                               
                                <asp:TextBox ID="lastname" runat="server" class="form-control" placeholder="Enter Last Name"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="contactno">Contact No</label>
                               
                                <asp:TextBox ID="contactno" runat="server" class="form-control" placeholder="Enter Contact No"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="email">E-Mail</label>
                               
                                <asp:TextBox ID="email" runat="server" class="form-control" placeholder="Enter E-Mail"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="residentaddress">Resident Address</label>
                              
                                <asp:TextBox ID="residentaddress" runat="server" class="form-control" placeholder="Enter Resident Address"></asp:TextBox>
                            </div>
                             <div class="form-group">
                                <label for="city">City</label>
                             
                                 <asp:TextBox ID="city" runat="server" class="form-control" placeholder="Enter City"></asp:TextBox>
                            </div>


                           
                                <asp:Button ID="b1" runat="server" Text="Update Contact" class="btn btn-success btn-sm waves-effect waves-light" OnClick="b1_Click"/>

                            
                        
                    </div>

                </div>

            </div>

        </div>
</asp:Content>
