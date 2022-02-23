
var palavras =[];
var i = 0;

do {

  var validador = prompt("Digite uma palavra. Se quisar parar, digite PARAR");

  if(validador != "parar"){
  palavras[i] = validador;
  i++;
  }
  
} while (validador != "parar");

var textos = palavras.sort((a,b) => {
  if (a>b){
      return -1;
  }
  if(a<b){
      return 1;
  }

  return 0
});

var tamanho = textos.length;

for(var u = 0; u < tamanho; u++){
  console.log(u);

  var section = document.createElement('section');
  section.textContent = textos[u];
  console.log(section.textContent);

  var div = document.querySelector('div');

  div.appendChild(section);

}