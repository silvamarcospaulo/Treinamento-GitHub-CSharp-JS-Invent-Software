var input = require('fs').readFileSync('stdin', 'utf8');
var valoresEntrada = input.split(' ');

var a = parseFloat(valoresEntrada.shift())
var b = parseFloat(valoresEntrada.shift())
var c = parseFloat(valoresEntrada.shift())

if(a < b + c && b < a + c && c < a + b)
{
    var x = a + b + c
    x = x.toFixed(1)
    console.log('Perimetro = '+x)
}
else
{
    var x = (a + b)*c/2
    x = x.toFixed(1)
    console.log('Area = '+x)
}