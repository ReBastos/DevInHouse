
function getForm() {

console.log("Teste");

document.querySelector("#nomeCard").textContent = document.querySelector("#nome").value;

document.querySelector("#perfilCard").src = document.querySelector("#imagem").value;

document.querySelector("#descricaoCard").textContent = document.querySelector("#descricao").value;

}

export default getForm;