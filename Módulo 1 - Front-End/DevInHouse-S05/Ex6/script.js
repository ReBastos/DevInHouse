class Client {
    constructor(name, cpf, adress, number){
        this.name = name;
        this.cpf = cpf;
        this.adress = adress;
        this.number = number;
    }
}

class Account extends Client{
    constructor(name, cpf, adress, number, cod, ammount){
        super(name, cpf, adress, number);
        this.cod = cod;
        this.ammount = ammount;
    }
}

var jose = new Client('Jose', '015.236.523-13', ['Avenida', 'Rua', 'Numero'], '75948756365');

console.log(jose);