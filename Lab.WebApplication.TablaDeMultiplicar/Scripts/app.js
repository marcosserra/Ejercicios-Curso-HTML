var app = {
    Init: function () {
        document.getElementsByTagName('input')[0].onkeypress = function (e) {
            if (e.keyCode === 13) {
                app.Process.Calcular();
            }
        };
        document.getElementsByTagName('button')[0].onclick = function () {
            app.Process.Calcular();
        };
    },
    Process: {
        Calcular: function () {
            var numero = parseInt(document.getElementsByTagName('input')[0].value);

            document.getElementById('res').innerHTML = '';

            for (var i = 1; i < 11; i++) {
                var item = document.createElement('h1');
                item.innerHTML = numero.toFixed(0) + ' x ' + i + ' = ' + (numero * i).toFixed(0);
                document.getElementById('res').appendChild(item);
            }
        }
    }
};