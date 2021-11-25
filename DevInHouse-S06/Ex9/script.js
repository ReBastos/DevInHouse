const $circuloPrincipal = document.querySelector("#circuloPrincipal");
const tamanhoDiminuicao = 1;

function recuperaDimensao(){
    return{
        largura: $circuloPrincipal.getBoundingClientRect().width,
        altura: $circuloPrincipal.getBoundingClientRect().height
    }
};

setInterval(() => {
    const size = recuperaDimensao();
    let largura = size.largura;
    let altura = size.altura;
    $circuloPrincipal.style.height = (altura - tamanhoDiminuicao) + "px";
    $circuloPrincipal.style.width = (altura - tamanhoDiminuicao) + "px";
    validaGameOver();

    
},100);





$circuloPrincipal.addEventListener("click", e =>{
    const size = recuperaDimensao();
    let largura = size.largura;
    let altura = size.altura;
    $circuloPrincipal.style.height = (altura + 15) + "px";
    $circuloPrincipal.style.width = (largura + 15) + "px";

    tamanhoDiminuicao = tamanhoDiminuicao + 10;

    validaGameOver();

});

function validaGameOver(){
    const objetoDimensao = recuperaDimensao();
    if(objetoDimensao.altura < 1|| objetoDimensao.altura > 500
        || objetoDimensao.largura < 1|| objetoDimensao.largura > 500){
            const result = confirm("Game Over! Deseja jogar novamente?");
            if(result){
                $circuloPrincipal.style.width = "190px";
                $circuloPrincipal.style.height = "190px";
            };
        }
}