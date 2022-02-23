class Transaction{
    constructor(account){
        this.account = account;
        this.ammount = 500;
    }

    transfer(ammount){

        if(this.ammount < ammount){
            return "Saldo insuficiente!";
        } else {
            this.ammount -= ammount;
        }
    }

    deposit(ammount){
        this.ammount += ammount; 
    }

    getAmmount(){
        return "R$"+ this.ammount.toFixed(2);
    }

}

var jose = new Transaction('jose');

console.log(jose.transfer(5000));

jose.transfer(30);
jose.deposit(50);

console.log(jose);