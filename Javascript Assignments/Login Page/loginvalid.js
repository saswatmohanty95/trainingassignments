var atp = 3;
function validate(){
var username = document.getElementById("usn").value;
var password = document.getElementById("psw").value;
if ( username == "System" && password == "Admin"){
//  alert("Successful");
document.getElementById('lol').innerHTML='Successful';
document.getElementById('lod').innerHTML='';
// var msg="<div class='alert' id='lol'> <div class='closebtn' onclick='this.parentElement.style.display='none';'>&times</div><strong class='text-primary' style='text-align: center'>Successful</strong></div>";

// document.getElementById('js').innerHTML=msg;

}
else{
atp--;// Decrementing by one.
//  alert("Invalid");
document.getElementById('lod').innerHTML='Invalid';
document.getElementById('lol').innerHTML='';
// var msg="<div class='alert' id='lol'> <div class='closebtn' onclick='this.parentElement.style.display='none';'>&times</div><strong class='text-' style='text-align: center'>Invalid</strong></div>";

// document.getElementById('js').innerHTML=msg;

if( atp == 0){
document.getElementById("usn").disabled = true;
document.getElementById("psw").disabled = true;
document.getElementById("submit").disabled = true;
alert("You have been locked out temporarily. Please try after sometime.")
}
}
}