// $(document).ready(function(){
//     ...jquery...
// });
$(function () {
    let slideIndex = -1;
    let slides = $(".slides");
    //showSlides();
    showSlides();

    function showSlides() {
        ////////////////////////////////////////
        // attempt 1
        slides.hide();

        slides.each(function (index) {
            $(this).css("border", "3px solid black");
            $(this).css({
                width: "560px",
                height: "500px",
                padding: "0",
                contentSizing: "cover"
            });
            $(this).children("img").css({
                width: "560px",
                height: "500"
            });
        });

        slideIndex++;
        if (slideIndex > slides.length)
            slideIndex = 1;

        //alert(slideIndex)
        let currSlide = slides.eq(slideIndex - 1);

        currSlide.css("display", "block");
        //currSlide.click(function () {
        //    showSlides();
        //})
        setTimeout(showSlides, 4000);
    }
});