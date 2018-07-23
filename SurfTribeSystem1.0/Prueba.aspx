<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="SurfTribeSystem1._0.Prueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <script language="javascript">
toHour=0;
toMinute=0;
toSecond=60;


function countDown()
{
	toSecond=toSecond-1;
	if(toSecond<0)
	{
		toSecond=59;
		toMinute=toMinute-1;
	}
    
    $("input[name='second']").val(toSecond);

	if(toMinute<0)
	{
		toMinute=59;
		toHour=toHour-1;
	}
   
    $("input[name='minute']").val(toMinute);
    
    $("input[name='hour']").val(toHour);
  
   
	if(toHour<0)
	{
    
		form2.second.value=0;
		form2.minute.value=0;
		form2.hour.value=0;
	}else{
		setTimeout("countDown()",1000);
	}
  
  if(toSecond==0 && toMinute==0)
    {
     location.href ="http://www.pagina1.com";
    }
 
}



        </script>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
.form_input
{
	font-family: Verdana;
	font-size: 12;
	color: #ffffff;
	border-width: 0;
	
	text-align: right;
}
</style>
</head>

    
<body>
    
   <body onload="countDown();">
<form name="form">

	 <font size="4"><b FACE="arial" style="margin-left: 58%; margin-top: -80%;" >Tiempo Restante: </b></font>


	<input type="text" size="5" class="form_input" name="hour" disabled visible="false">:
	<input type="text" size="5" class="form_input" name="minute" disabled>:
	<input type="text" size="5" class="form_input" name="second" disabled>
</form>
 
</body>
       
</body>
        
</html>
