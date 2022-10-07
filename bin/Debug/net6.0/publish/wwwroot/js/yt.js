if (window.matchMedia('(max-width: 330px)').matches) {
    $('.article-video-div').height($('.article-text-div').height()/2.5)
} else if (window.matchMedia('(max-width: 500px)').matches) {
    $('.article-video-div').height($('.article-text-div').height()/2)
} else if (window.matchMedia('(max-width: 769px)').matches) {
    $('.article-video-div').height($('.article-text-div').height()*1.2)
}