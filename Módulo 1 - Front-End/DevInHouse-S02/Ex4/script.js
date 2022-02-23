
        var random = 0;
        var countInf = 0;
        var countSup = 0;
        var countHundred = 0;
        for(var i=0; i<1000; i++){

            random = Math.floor(Math.random() * 1000);

            if (random <= 500){
                countInf++;
            } else if( random >= 501){
                countSup++;
            }

            if (countInf > countSup){
                document.body.style.backgroundImage = "url('https://picsum.photos/200/300')";
            } else if(countSup > countInf){
                document.body.style.backgroundImage = "url('https://via.placeholder.com/500')";
            }

            if(random == 100){
                countHundred++;
            }

            if(countHundred == 1){
                document.body.style.backgroundColor = "orange";
            } else if (countHundred > 1){
                document.body.style.backgroundColor = "black";
            }
            

            console.log(countInf);
            console.log(countSup);
            
            
            
        }
