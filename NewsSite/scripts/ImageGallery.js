$(document).ready(() => {
    var currentImgIndex = 0;

    //read all images from the storage
    var allImgNames = $("#imgNamesStorage").text().split(";");

    //set next image value
    $("#GoRightBtn").attr("nextImg", allImgNames[currentImgIndex + 1]);
    //disable left arrow
    $("#GoLeftBtn").addClass("disabled");

    //right arrow click subscription
    $("#GoRightBtn").click(() => {
        if (!$("#GoRightBtn").attr("nextImg"))
            return;

        var nextImg = $("#GoRightBtn").attr("nextImg");
        $("#CurrentImg").attr("src", "/ImageGallery/Index/" + nextImg);

        currentImgIndex++;
        
        $("#GoRightBtn").attr("nextImg", allImgNames[currentImgIndex + 1]);
        $("#GoLeftBtn").attr("previousImg", allImgNames[currentImgIndex - 1]);
        $("#ImageTitle").text(nextImg);

        $("#GoLeftBtn").removeClass("disabled");
       
        if (currentImgIndex == allImgNames.length - 1) {
            $("#GoRightBtn").attr("nextImg", "");
            $("#GoRightBtn").addClass("disabled");
        }
    });

    //left arrow click subscription
    $("#GoLeftBtn").click(() => {
        if (!$("#GoLeftBtn").attr("previousImg"))
            return;

        var previousImg = $("#GoLeftBtn").attr("previousImg");
        $("#CurrentImg").attr("src", "/ImageGallery/Index/" + previousImg);

        currentImgIndex--;

        $("#GoRightBtn").removeClass("disabled");
        $("#GoRightBtn").attr("nextImg", allImgNames[currentImgIndex + 1]);
        $("#ImageTitle").text(previousImg);

        if (currentImgIndex == 0) {
            $("#GoLeftBtn").attr("previousImg", "");
            $("#GoLeftBtn").addClass("disabled");
            return;
        }

        $("#GoLeftBtn").attr("previousImg", allImgNames[currentImgIndex - 1]);
    });
});