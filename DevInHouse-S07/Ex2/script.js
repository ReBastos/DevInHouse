const numeros = [ 3, 5, 7, 9, 11, 13 ];

let double = numeros.map(function(num, index){
    if (index > 0){
    let num2 = numeros[index - 1];
    return num * num2;}
    else if (index == 0){
        return num;
    }
});

console.log(double);