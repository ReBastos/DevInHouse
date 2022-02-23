const range = document.querySelector('#range'),
progressbar = document.querySelector('.progress-bar');
  
  

let value = 0;
setInterval(function(){
	value++;
  progressbar.style.setProperty('--progress', value);

  if(value == 100){
      window.alert("Concluído!");
      value = 0;
  }
}, 1000);