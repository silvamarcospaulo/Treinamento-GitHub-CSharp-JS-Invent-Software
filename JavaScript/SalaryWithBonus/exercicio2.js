const input = require('fs').readFileSync('stdin','utf8')
var valoresEntrada = input.split('\n')

var nome = valoresEntrada.shift()
var salario = parseFloat(valoresEntrada.shift())
var totalVendas = parseFloat(valoresEntrada.shift())

var x = salario + totalVendas*0.15

x = x.toFixed(2);

console.log('TOTAL = R$ ' + x)
