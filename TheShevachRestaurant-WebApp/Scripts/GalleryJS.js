$(document).ready(function () {
    console.log("ready");

    //cash
    var $divPaper;

    $(".imgGallery").mouseover(function () {
        console.log("Enter");
        $divPaper = $("#" + this.id + "-in");
        $divPaper.removeClass("displayNone");
    });

    $(".imgGallery").mouseout(function () {
        console.log("Out");
        $divPaper.addClass("displayNone");
    });
});