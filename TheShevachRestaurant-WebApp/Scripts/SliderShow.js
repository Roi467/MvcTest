$(document).ready(function(){
    console.log("ready");
    
    //configurtion
    var width = 700;
    var animateSpeed = 1000;
    var pause = 3000;
    var currentSlide = 1;
    
    //cash
    var $slider = $('#slider');
    var $slideContainer = $slider.find('.slides');
    var $slides = $slideContainer.find('.slide');
    
    var interval;
    
    function startSlider(){
        interval = setInterval(function() {
            $slideContainer.animate({"margin-right": "-="+width}, animateSpeed, function(){
                if(++currentSlide == $slides.length){
                    currentSlide = 1;
                    $slideContainer.css("margin-right" , 0);
                }     
            });
        }, pause);
    }
    
    function stopSlider(){
        clearInterval(interval);
    }
    
    $slider.on('mouseenter', stopSlider).on('mouseleave', startSlider);
    
    startSlider();
});