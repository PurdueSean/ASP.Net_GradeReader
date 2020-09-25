<%@ Page Title="Grade Report" Language="C#"  AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="Web_App_Unit_7._Default" %>

<!Doctype HTML>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
        Course: Quantum Physics 403
    </p>
    <p>
        Instructor: Dr. Jeckel
    </p>
    <form id="form1" runat="server">
        <p>
            Average Final Grade:&#32;  <asp:TextBox ID="txtAverageGrade" runat="server"></asp:TextBox>
        </p>
        <p>
            Highest Grade:&#32;  <asp:TextBox ID="txtHighestGrade" runat="server"></asp:TextBox>
        </p>
        <p>
            Lowest Grade:&#32;  <asp:TextBox ID="txtLowestGrade" runat="server"></asp:TextBox>
        </p>

    </form>
</body>
</html>