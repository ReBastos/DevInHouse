var nParticipantes = 0;
var nSatisfeitos = 0;
var idadeMedia = 0;
var idade = 0;

function participar() {
  nParticipantes++;

  window.prompt("Digite seu nome:");

  do {
    var satisfacao = window.prompt(
      "Digite um número de 1  a 10 para expressar sua satisfação:"
    );
  } while (satisfacao < 1 || satisfacao > 10);

  var idadePrompt = window.prompt("Digite sua idade:");
  idade = parseInt(idadePrompt);

  idadeMedia = (idadeMedia + idade) / nParticipantes;

  var satisfeito = window.prompt(
    "Podemos incluir você na lista de satisfeitos"
  );

  window.alert("Salvo com Sucesso!");

  if (satisfeito == "sim") {
    nSatisfeitos++;
  }

  document.getElementById("nParticipantes").textContent = nParticipantes;
  document.getElementById("idadeMedia").textContent = idadeMedia;
  document.getElementById("satisfeitos").textContent = nSatisfeitos;
}
