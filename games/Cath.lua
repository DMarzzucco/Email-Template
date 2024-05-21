<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Atrapame Si Puedes</title>
</head>
<style>
    body,
    html {
        background-color: #0f1518;
        margin: 0;
        overflow: hidden;
    }

    .conten {
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
    }

    .titulo {
        text-align: center;
        font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        color: tomato;
    }

    .sub-titulo {
        text-align: right;
        font-family: Arial, Helvetica, sans-serif;
        color: brown;
    }

    #gameCanvas {
        border: 3px solid #000;
        background: url(itm/cesped-en-el-cesped-768x573.webp);
        background-size: contain;
        /* margin-left: 200px; */
        border-radius: 20px;

    }
</style>

<body>
    <section class="conten">
        <h1 class="titulo">ATRAPAME SI PUEDES</h1>
        <canvas id="gameCanvas" width="800" height="400"></canvas> </canvas>
        </div>
    </section>
    <script>
        // Configuración del juego
        var canvas = document.getElementById("gameCanvas");
        var ctx = canvas.getContext("2d");
        var playerX = 400;
        var playerY = 300;
        var enemyX = 100;
        var enemyY = 100;
        var enemySpeed = 2;

        // Función para dibujar el jugador
        function drawPlayer() {
            ctx.beginPath();
            ctx.arc(playerX, playerY, 10, 0, Math.PI * 2);
            ctx.fillStyle = "red";
            ctx.fill();
            ctx.closePath();
        }

        // Función para dibujar al enemigo
        function drawEnemy() {
            ctx.beginPath();
            ctx.arc(enemyX, enemyY, 10, 0, Math.PI * 2);
            ctx.fillStyle = "blue";
            ctx.fill();
            ctx.closePath();
        }

        // Función para dibujar el juego
        function draw() {
            ctx.clearRect(0, 0, canvas.width, canvas.height);
            drawPlayer();
            drawEnemy();
        }

        // Función para actualizar el juego
        function update() {
            // Lógica de movimiento del jugador
            if (keys.ArrowUp && playerY > 10) {
                playerY -= 5;
            }
            if (keys.ArrowDown && playerY < canvas.height - 10) {
                playerY += 5;
            }
            if (keys.ArrowLeft && playerX > 10) {
                playerX -= 5;
            }
            if (keys.ArrowRight && playerX < canvas.width - 10) {
                playerX += 5;
            }

            // Lógica de movimiento del enemigo
            if (enemyX < playerX) {
                enemyX += enemySpeed;
            }
            if (enemyX > playerX) {
                enemyX -= enemySpeed;
            }
            if (enemyY < playerY) {
                enemyY += enemySpeed;
            }
            if (enemyY > playerY) {
                enemyY -= enemySpeed;
            }

            // Detección de colisiones
            var dx = playerX - enemyX;
            var dy = playerY - enemyY;
            var distance = Math.sqrt(dx * dx + dy * dy);
            if (distance < 20) {
                // Colisión detectada, muestra un mensaje
                alert("¡LA CAGASTE!");
                resetGame();
            }

            draw();
        }

        // Función para manejar los eventos de teclado
        var keys = {};
        window.addEventListener("keydown", function (e) {
            keys[e.key] = true;
        });

        window.addEventListener("keyup", function (e) {
            keys[e.key] = false;
        });

        // Función para reiniciar el juego
        function resetGame() {
            playerX = 400;
            playerY = 300;
            enemyX = 100;
            enemyY = 100;
        }

        // Bucle principal del juego
        function gameLoop() {
            update();
            requestAnimationFrame(gameLoop);
        }

        gameLoop();
    </script>
</body>

</html>