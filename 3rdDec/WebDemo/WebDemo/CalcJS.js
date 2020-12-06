function calculate(opreator) {
    var a, b;
    a = document.getElementById("text1").value;
    b = document.getElementById("text2").value;
    var result = eval(a + opreator + b);
    //alert(a);
    //alert(b);
    //alert(result);
    document.getElementById("text3").value =  result;
 }

function clear() {
    document.getElementById("calc").reset();
}