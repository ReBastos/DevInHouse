 let mostrarNome = (a, b) =>{
    var nome = "Jane";
    var sobrenome = "Doe";

    if(a && !b){
        nome = a;
        sobrenome = "Doe";
    } else if(a && b){
        nome = a;
        sobrenome = b;
    }

    return nome +" "+ sobrenome;
}

console.log(mostrarNome());

console.log(mostrarNome("Renato"));

console.log(mostrarNome("Renato", "Bastos"));