function validar(){
    var numero = document.getElementById("input").value;

    if(numero % 2 == 0){
        alert("O número é PAR!");
    } else 
    alert("O número é IMPAR");
}