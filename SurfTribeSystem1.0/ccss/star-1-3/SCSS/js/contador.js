      
toHour=0;
toMinute=3;
toSecond = 60;


function countDown()
{

    if (localStorage.getItem("SurfTribeSystem_second") == null) {

        localStorage.setItem("SurfTribeSystem_second", toSecond);


    }
    if (localStorage.getItem("SurfTribeSystem_minute") == null) {

        localStorage.setItem("SurfTribeSystem_minute", toMinute);

    }

    
    localStorage.setItem("SurfTribeSystem_second", localStorage.getItem("SurfTribeSystem_second") - 1);

    if (localStorage.getItem("SurfTribeSystem_second")<0)
	{
        localStorage.setItem("SurfTribeSystem_second", 59);
        localStorage.setItem("SurfTribeSystem_minute", localStorage.getItem("SurfTribeSystem_minute") - 1);

	}
    
    $("input[name='second']").val(localStorage.getItem("SurfTribeSystem_second"));

    if (localStorage.getItem("SurfTribeSystem_minute")<0)
	{
       
        localStorage.setItem("SurfTribeSystem_minute", 59);
		toHour=toHour-1;
	}
   
    $("input[name='minute']").val(localStorage.getItem("SurfTribeSystem_minute"));
    
    $("input[name='hour']").val(toHour);
  
   
	if(toHour<0)
	{
       
        $("input[name='second']").val(0);
        $("input[name='minute']").val(0);
        $("input[name='hour']").val(0);
    } else {

		setTimeout("countDown()",1000);
	}
  
    if (localStorage.getItem("SurfTribeSystem_second") == 0 && localStorage.getItem("SurfTribeSystem_minute")==0)
    {
     location.href ="reservaClases.aspx";
    }
    
    

 
}





