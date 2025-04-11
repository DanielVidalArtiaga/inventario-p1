function modificar()
{
    let user=document.getElementById("usuario").value;
    let pass=document.getElementById("clave").value;

    if(user=="danny" && pass=="1234")
    {
        
        window.location="menu.html";
    }
    else
    {
        alert("datos incorrectos");
    }
     
}