<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ESSBC.Default" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <main>
        <div class="container">
            <div class="row">
                <div class="col-md-4 pull-right">
                    <asp:Button ID="btnEnglish" runat="server" Text="English" CssClass="btn btn-info" UseSubmitBehavior="False" CausesValidation="False" ValidateRequestMode="Disabled"></asp:Button>
                    <asp:Button ID="btnArabic" runat="server" Text="Arabic" CssClass="btn btn-info" UseSubmitBehavior="False" CausesValidation="False" ValidateRequestMode="Disabled"></asp:Button>
                </div>
            </div>
            <div class="row">
                
                <div class="col-md-12">
                  
	                    <legend>
                            <p>
<asp:Label ID="lblForm" runat="server" Text="Employee" meta:resourcekey="lblFormResource1"></asp:Label>
                            </p>
	                    </legend>

                        <div class="form-group">
		                    
<asp:Label ID="lblID" runat="server" Text="ID" CssClass="control-label" meta:resourcekey="lblIDResource1"></asp:Label>
	                        <asp:TextBox ID="txtID" runat="server" CssClass="form-control numbers col-md-3 col-lg-3 col-sm-3" meta:resourcekey="txtIDResource1"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="ID required" ControlToValidate="txtID" meta:resourcekey="RequiredFieldValidator1Resource1"></asp:RequiredFieldValidator>
	                    </div>    

                     <div class="form-group">
           <asp:Label ID="lblName" runat="server" Text="Name" CssClass="control-label" meta:resourcekey="lblNameResource1"></asp:Label>

	                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control col-md-3 col-lg-3 col-sm-3" meta:resourcekey="txtNameResource1"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Name is Required !" ControlToValidate="txtName" meta:resourcekey="RequiredFieldValidator2Resource1"></asp:RequiredFieldValidator>

	                    </div> 

                     <div class="form-group">
		                    <asp:Label ID="lblSalaryInfo" runat="server" Text="Salary" CssClass="control-label" meta:resourcekey="lblSalaryInfoResource1"></asp:Label>

	                        <asp:TextBox ID="txtSalary" runat="server" CssClass="form-control numbers col-md-3 col-lg-3 col-sm-3" meta:resourcekey="txtSalaryResource1"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Salary is Required !" ControlToValidate="txtSalary" meta:resourcekey="RequiredFieldValidator3Resource1"></asp:RequiredFieldValidator>
	                    </div> 

                     <div class="form-group">
		                    <asp:Label ID="lblAge" runat="server" Text="Age" CssClass="control-label" meta:resourcekey="lblAgeResource1"></asp:Label>

	                        <asp:TextBox ID="txtAge" runat="server" CssClass="form-control numbers col-md-3 col-lg-3 col-sm-3" meta:resourcekey="txtAgeResource1"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Age is Required !" ControlToValidate="txtAge" meta:resourcekey="RequiredFieldValidator4Resource1"></asp:RequiredFieldValidator>
	                    </div> 
                    <br />
                    <div class="form-group">
                        <div class="radio">
                            <label>
                            <asp:RadioButton ID="rbManager" GroupName="type" runat="server" meta:resourcekey="rbManagerResource1"></asp:RadioButton> 
	                        <asp:Label runat="server" ID="lblManager" Text="Manager" meta:resourcekey="lblManagerResource1"></asp:Label>
                            </label>
                                </div>
                        <div class="radio">
                        <label>
                            <asp:RadioButton ID="rbEngineer" GroupName="type" runat="server" meta:resourcekey="rbEngineerResource1"></asp:RadioButton> 
                            <asp:Label runat="server" ID="lblEngineer" Text="Engineer" meta:resourcekey="lblEngineerResource1"></asp:Label>
                         </label>
                            </div>
                        <div class="radio">
                            <label><asp:RadioButton ID="rbWorker" GroupName="type" runat="server" meta:resourcekey="rbWorkerResource1"></asp:RadioButton> 
	                    <asp:Label runat="server" ID="lblWorker" Text="Worker" meta:resourcekey="lblWorkerResource1"></asp:Label>
                            </label></div>
                        <div class="radio">
                            <label><asp:RadioButton ID="rbAccountant" GroupName="type" runat="server" meta:resourcekey="rbAccountantResource1"></asp:RadioButton> 
	                    <asp:Label runat="server" ID="lblAccountant" Text="Accountant" meta:resourcekey="lblAccountantResource1"></asp:Label>
                            </label></div>
                    </div>

                      
	                    <asp:Button ID="btnCalcSalary" runat="server" Text="Calculate Salary" CssClass="btn btn-danger btn-validate" meta:resourcekey="btnCalcSalaryResource1" ></asp:Button>
                        <asp:Button ID="btnDoWork" runat="server" Text="Do Work" CssClass="btn btn-default btn-validate" meta:resourcekey="btnDoWorkResource1"></asp:Button>
                </div>

                <div class="col-md-12">
                    <br />
                    <asp:Label ID="lblDoWork" runat="server" meta:resourcekey="lblDoWorkResource1"></asp:Label>
                    <asp:Label ID="lblSalary" runat="server" meta:resourcekey="lblSalaryResource1"></asp:Label>
                </div>
            </div>
      </div>
    </main>
</asp:Content>
