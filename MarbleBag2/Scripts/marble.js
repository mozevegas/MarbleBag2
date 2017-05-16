console.log("hello there!!");

let loadMarbles = () => {
    $.ajax({
        url: "/api/marble",
        dataType: "json",
        success: (listMarbles) => {
            listMarbles.map((m) => {
                $("#marbleClass")
                    .append($("<li>").html(m.Color))
            });
        }
    })
}

let randomMarble = () => {
    let baggy = $("#marbleClass").children();
    var rando = Math.floor(Math.random() * baggy.length);
    $("#randoClass").html(baggy[rando].innerHTML);
}

let addMarble = () => {
    let newMarble = $("#ColorNew").val();
    $("#marbleClass").append($("<li>").text(newMarble));
}

$(document).ready(() => {
    console.log("ready...");
    loadMarbles();
});