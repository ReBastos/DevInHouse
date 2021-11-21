class Client {
    constructor(name, cpf, adress, number){
        this.name = name;
        this.cpf = cpf;
        this.adress = adress;
        this.number = number;
    }
}

var jose = new Client('Jose', '015.236.523-13', ['Avenida', 'Rua', 'Numero'], '75948756365');

console.log(jose);