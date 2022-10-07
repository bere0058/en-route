// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// Breaking lines

Array.from($("p")).forEach(p => {
    p.innerHTML = p.textContent.replace("<br>", "<br>")
});