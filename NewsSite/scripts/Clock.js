$(document).ready(function () {
    setDate();
    setInterval(setDate, 1000);
});

function setDate() {
    var date = new Date();
    var dateValue =
        datePartFormatter(date.getDay()) + "-" +
        datePartFormatter(date.getMonth()) + "-" +
        date.getFullYear() + " " +
        datePartFormatter(date.getHours()) + ":" +
        datePartFormatter(date.getMinutes()) + ":" +
        datePartFormatter(date.getSeconds());
    $("#Clock").text(dateValue);
}

function datePartFormatter(datePart) {
    return datePart < 10 ? "0" + datePart : datePart;
}