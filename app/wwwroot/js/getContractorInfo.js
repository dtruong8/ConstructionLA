var input = document.getElementById("contractor_business_name");
input.addEventListener("keyup", function(event){
    if(event.which === 13 || event.keyCode === 13){ // If user presses "Enter" key
        input = document.getElementById("contractor_business_name").value;
        alert(input);
    }
});
