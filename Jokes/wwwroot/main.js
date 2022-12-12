fetch(`jokes/all`)
    .then(response => response.json())
    .then(data => IdListába(data));

var jokeSk = [];
var sorszám = 0;

function IdListába(data) {
    for (var i = 0; i < data.length; i++) {
        var szám = data[i].jokeSk;
        jokeSk.push(szám);
    }
    ViccBetöltés(jokeSk[sorszám]);
}

function ViccBetöltés(id) {
    fetch(`jokes/${id}`)
        .then(response => response.json())
        .then(data => Kiíratás(data));
}

function Kiíratás(data) {
    let elem = data.jokeText;
    document.getElementById("választottVicc").innerText = elem;
}

function KövetkezőVicc() {
    sorszám++;
    ViccBetöltés(jokeSk[sorszám]);
}

window.onload = function(e) {
    document.getElementById("add").onclick = KövetkezőVicc;
}
