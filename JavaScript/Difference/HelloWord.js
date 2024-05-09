var input = require('fs').readFileSync('stdin', 'utf8')
var valoresEntrada = input.split('\n');

var A = parseInt(valoresEntrada.shift())
var B = parseInt(valoresEntrada.shift())
var C = parseInt(valoresEntrada.shift())
var D = parseInt(valoresEntrada.shift())

var X = A*B - C*D;

console.log('DIFERENCA = ' +X)