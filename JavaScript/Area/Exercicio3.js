var input = require('fs').readFileSync('stdin', 'utf8')
var valoresEntrada = input.split(' ')

var a = parseFloat(valoresEntrada.shift())
var b = parseFloat(valoresEntrada.shift())
var c = parseFloat(valoresEntrada.shift())

var x = a*c/2
x = x.toFixed(3)
console.log('TRIANGULO: '+x)

x = 3.14159*c*c
x = x.toFixed(3)
console.log('CIRCULO: ' + x)

x = (a+b)*c/2
x = x.toFixed(3)
console.log('TRAPEZIO: '+x)

x = b*b
x = x.toFixed(3)
console.log('QUADRADO: ' +x)

x = a*b
x = x.toFixed(3)
console.log('RETANGULO: ' + x)