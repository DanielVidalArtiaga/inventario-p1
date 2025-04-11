function loguear()
{
    let user=document.getElementById("usuario").value;
    let pass=document.getElementById("clave").value;

    if(user=="local" && pass=="1234")    
    {
        window.location="menu.html";
    }
    else
    {
        alert("datos incorrectos");
    }
     
}
function modificar()
{
    let user=document.getElementById("usuariox").value;
    let pass=document.getElementById("clavex").value;
    usuariox=user.value;
    clavex=user.value;
}