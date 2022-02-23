
        var textos = ['animal','carro','humano','prédio','cadeira','objeto'];

        var textos2 = textos.sort();
         
        console.log(textos2);

        var tamanho = textos2.length;

         

        for(var i = 0; i < tamanho; i++){
            console.log(i);
        
            var section = document.createElement('section');
            section.textContent = textos2[i];
            console.log(section.textContent);

            var div = document.querySelector('div');

            div.appendChild(section);

        }

 