var input = require('fs').readFileSync('stdin', 'utf8')
var valoresEntrada = input.split('\n')

var entrada
var total = 0
var numeroGritos = 0

while(numeroGritos != 3)
    {
        entrada = valoresEntrada.shift() 
        entrada = String(entrada)

        if(entrada.charAt(0) == 'c')
            {
                console.log(total)
                total = 0
                numeroGritos++
            }
        else
            total += OlhoParaBin(entrada)
    }


/**
 * @param {string} olhos
 */
function OlhoParaBin( olhos)
{
     var saida = 0;
     var num = 2
     var c;

     var text = String(olhos)

        for(var i = 0; i < 3;i++, num--)
            {
                c = text.charAt(i)  
                if(c == '*')
                    {
                        saida += Math.pow(2, num)
                    }
        }
        return saida 
}
