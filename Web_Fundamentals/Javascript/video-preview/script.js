console.log("page loaded...");

function videoPreviewOn(element) {
    // console.log(element.children);
    var img = element.children[0];
    img.setAttribute("class","displayNone");
    // <video src="assets/pexels-1722593.mp4" id="videoSmallPreview" 
    // width="170" height="113" autoplay="" loop="" muted=""></video>
    var video = document.createElement("VIDEO");
    video.setAttribute("src","assets/pexels-1722593.mp4");
    video.setAttribute("id", "videoSmallPreview");
    video.setAttribute("width", "170");
    video.setAttribute("height", "113");
    video.loop = true;
    video.autoplay = true;
    video.muted = true;
    element.prepend(video);
}

function videoPreviewOff(element) {
    element.removeChild(element.children[0]);
    var img = element.children[0];
    img.removeAttribute("class");
    img.setAttribute("class","vid-s");

    //<img src="assets/video-placeholder.png" alt="video placeholder" class="vid-s">
    // var img = document.createElement("IMG");
    // img.setAttribute("src", "assets/video-placeholder.png");
    // img.setAttribute("alt", "video placeholder");
    // img.setAttribute("class", "vid-s")
    // element.prepend(img);
}

function videoPlay(element) {
    element.play();
}

function videoPause(element) {
    element.pause();
}