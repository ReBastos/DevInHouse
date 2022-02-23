function primo(a){

    var index = 0;

    for(i=2; i<a; i++){
        if(a%i == 0){
            index++;
        }

       
    }

    if(index == 0){
        return "Número é Primo!";
    } else {
        return "Número não é Primo!";
    }
    
}

console.log(primo(13));