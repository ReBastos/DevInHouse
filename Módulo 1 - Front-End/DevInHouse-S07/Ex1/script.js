const frutas = ['Banana', 'Morango', 'Maçã', 'Uva', 'Pêra'];
console.log(frutas);

let frutasString = [];

frutas.forEach((fruta, index) => {
    frutasString.push(`A fruta ${fruta} está na posição ${index}`);
});

console.log(frutasString);