class Endereco{
    constructor(logradouro, numero, cidade, pais, cep){
        this.logradouro = logradouro;
        this.numero = numero;
        this.cidade = cidade;
        this.pais = pais;
        this.cep = cep;
    }
    
    
}

const get = (seletor) => document.getElementsByClassName(seletor);  


function salvar(){

var cliente = new Endereco(get("logradouro")[0].value, 
                            get("numero")[0].value, 
                            get("cidade")[0].value, 
                            get("pais")[0].value,
                            get("cep")[0].value);
                            
                            
var loja = new Endereco(get("logradouro")[1].value, 
                            get("numero")[1].value, 
                            get("cidade")[1].value, 
                            get("pais")[1].value,
                            get("cep")[1].value);
                            
var mercado = new Endereco(get("logradouro")[2].value, 
                            get("numero")[2].value, 
                            get("cidade")[2].value, 
                            get("pais")[2].value,
                            get("cep")[2].value);
                            

var clienteStr = JSON.stringify(cliente);

var lojaStr = JSON.stringify(loja);

var mercadoStr = JSON.stringify(mercado);

localStorage.setItem("cliente", clienteStr);

localStorage.setItem("loja", lojaStr);

localStorage.marcadoStr = ("mercado", mercadoStr);

}