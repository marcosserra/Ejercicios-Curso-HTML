var app = {
    Letras: ['T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E', 'T'],
    Init: function () {
        document.getElementById('dni').value = '';
        document.getElementById('b1').onclick = function () {
            app.Process.CalcularDNI();
        };
    },
    Process: {
        CalcularDNI: function () {
            var numero = parseFloat(document.getElementById('dni').value);
            var posicion = numero % 23;
            document.getElementById('res').innerHTML = numero + app.Letras[posicion];
        }
    }
};