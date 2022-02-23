
var array_enderecos = [];



function salvar(){

    var enderecos = new Object; 

    enderecos.nome = document.getElementById("nome").value;

    enderecos.tipo = document.getElementById("tipo").value;

    enderecos.endereco = document.getElementById("endereco").value;
    
    array_enderecos.push(enderecos);

    var tabela = document.getElementById("tabela");

    var iconeTrash = '<i class="fas fa-trash"></i>';
    
    
    

    if(enderecos.tipo == "Residencial"){

        var icone = '<i class="fas fa-briefcase"></i>';

    } else if(enderecos.tipo == "Comercial"){

        var icone = '<i class="fas fa-home"></i>';

    }

   var linha = "<tr> <td>"+enderecos.nome+"</td> <td>"+enderecos.endereco+"</td> <td class='icone'>"+icone+" "+enderecos.tipo+"</td> <td class='icone'>"+iconeTrash+"</td> <tr>"

   tabela.insertAdjacentHTML("beforeend", linha);


}