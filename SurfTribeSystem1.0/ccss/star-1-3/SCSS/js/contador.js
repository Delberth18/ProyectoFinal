      
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