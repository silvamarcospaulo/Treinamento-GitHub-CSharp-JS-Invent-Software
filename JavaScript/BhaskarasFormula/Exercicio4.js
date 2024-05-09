var input = require('fs').readFileSync('stdin', 'utf8')
var valoresEntrada = input.split(' ')

var a = parseFloat(valoresEntrada.shift())
var b = parseFloat(valoresEntrada.shift())
var c = parseFloat(valoresEntrada.shift())

var delta = b*b - 4*a*c

if(delta < 0 || a == 0)
{
    console.log('Impossivel calcular')
}
else
{
    var r1 = (-b + Math.sqrt(delta))/(2*a)
    r1 = r1.toFixed(5)
    console.log('R1 = '+ r1)

    var r2 = (-b - Math.sqrt(delta))/(2*a)
    r2 = r2.toFixed(5)
    console.log('R2 = '+r2)
}