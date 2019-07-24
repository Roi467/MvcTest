$(document).ready(function(){
        
    $("#send").click(function(){
        /*  
            Check if all inputs filed with valide value 
        */
        
        //Configuration
        var name,email,phone,errorfg = 0; 
        var inputs = document.getElementById('contact').getElementsByTagName('input');
        
        name = $("input[name='Name']").val();
        email = $("input[name='Email']").val();
        phone = $("input[name='Phone']").val();
        
        //Resrt css class
        remove_error();
        
        //Check valide
        if(name.length < 3){
            errorfg = 1;
            add_error(inputs[0]);
        }
        if(ValidEmail(email)){ 
            errorfg = 1;
            add_error(inputs[1]);
        }
        if(phone.length < 10){
            errorfg = 1;
            add_error(inputs[2]);
        }
        
        //Check error flag
        if(errorfg)
            alert("יש לתקן את הערכים השגויים");
        else
            alert("נשלח בהצלחה!");
        
    });
    
    $("input[name='Phone']").on('input',function(){
        /*  Valide phone input on run time
            only numbers allow
        */
        var ex = $("input[name='Phone']").val();
        var ch = ex[ex.length-1];
        log("ch = " +ch);
        if(isNaN(ch))
            $("input[name='Phone']").val(ex.substr(0,ex.length-1));
    });
    
    $("input[name='Name']").on('input',function(){
        /*  Valide name input on run time
            only letters allow
        */
        var ex = $("input[name='Name']").val();
        var ch = ex[ex.length-1];
        log("ch = " +ch);
        if(!isNaN(ch))
            $("input[name='Name']").val(ex.substr(0,ex.length-1));
    });
    
    $("textarea[name='Message']").on('input',function(){
        /*  Update the max letter on run time  */
        
        var $txtArea = $("textarea[name='Message']");
        var ex = $txtArea.val();
        var $letterNum = $("span#letterNumbers");
        $letterNum.text(250-ex.length);
    });
    
});

function log(text){
    /* Print to log  */
    console.log(text);
}

function ValidEmail(email){
        /* Valide Email - if there is a tow strudel
            or if there is not dot after the strudel
            or if there is a dot srigth after the strudel
            is not valide.        
        */
        var fiStrodel,lsStrodel,indexDot;
        log(typeof(email));
        log(email);
        fiStrudel = email.indexOf('@');
        lsStrudel = email.lastIndexOf('@');
        indexDot = email.lastIndexOf('.');
        log("First: " + fiStrudel +" Last: " + lsStrudel);
        if(fiStrudel <= 0 || fiStrudel != lsStrudel || indexDot <= lsStrudel+1 || email[fiStrudel+1] == '.' )
            return 1;
        
}

function remove_error(){   
    /* Remove css error class  */
    //var inputs1 = $('#contact :input');
    //log(inputs1);
    var inputs = document.getElementById('contact').getElementsByTagName('input'); 
    for(var i =0; i < inputs.length; i++){
        inputs[i].classList.remove("error_border");
    }  
}

function add_error(elm){
    /* Add css error class  */
    elm.classList.add("error_border");
}