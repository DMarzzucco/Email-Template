<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pong</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" />
</head>
<style>
    body,
    html {
        background-color: rgb(73, 105, 211);
        margin: 0;
        padding: 0;
        display: flex;
        justify-content: center;
        align-items: center;
        height: 100vh;
    }

    .encabezado-principal .logo {
        background: linear-gradient(to top, rgb(80 128 173 0), rgb(3 31 53 0.719));
        position: fixed;
        width: 100%;
        left: 0;
        margin-top: -93px;
        z-index: 1;
    }

    .encabezado-principal h1 {
        padding: 0 80px;
        text-align: center;
        font-size: 82px;
        font-family: Arial, Helvetica, sans-serif;
        color: rgba(240, 248, 255, 0.548);
    }

    #game-container {
        width: 800px;
        height: 400px;
        background-color: #1c8129;
        border: 1px solid #000;
        position: relative;
    }

    .paddle {
        width: 10px;
        height: 80px;
        background-color: #000;
        position: absolute;
    }

    #paddle-left {
        background-color: #dd8d14fd;
        left: 10px;
        top: 160px;
        border: 2px solid #31200554;
        border-radius: 10px;
    }

    #paddle-right {
        background-color: rgb(144, 33, 218);
        right: 10px;
        top: 160px;
        border: 2px solid rgba(46, 11, 70, 0.411);
        border-radius: 10px;
    }

    .ball {
        width: 10px;
        height: 10px;
        background-color: rgba(84, 84, 87, 0.178);
        border-radius: 50%;
        position: absolute;
    }

    #ball .fa-solid.fa-volleyball {
        font-size: 30px;
        color: rgb(192, 168, 142);
    }

    #linea {
        width: 800px;
        border-right: #063324 dashed 0.70px;
        height: 400px;
        position: absolute;

        transform: translateX(-50%);
    }
</style>

<body>
    <div class="encabezado-principal">
        <header>
            <div class="logo">
                <h1 class="titulo"><i class="fa-solid fa-volleyball"> </i>P O N G</h1>
            </div>
        </header>
    </div>
    <section class="contenedor-deljuego">
        <div id="game-container">
            <div id="paddle-left" class="paddle"></div>
            <div id="paddle-right" class="paddle"></div>
            <div id="ball" class="ball"><i class="fa-solid fa-volleyball"></i></div>
            <div id="linea"> </div>
            <!--  -->
        </div>
    </section>
    <script>
        var gameContainer = document.getElementById("game-container");
        var paddleLeft = document.getElementById("paddle-left");
        var paddleRight = document.getElementById("paddle-right");
        var ball = document.getElementById("ball");
        var ballX = 395;
        var ballY = 195;
        var ballSpeedX = -4;
        var ballSpeedY = 4;
        var paddleSpeed = 5;
        var isPaused = false;
        document.addEventListener("keydown", function (event) {
            if (event.key === " ") {
                isPaused = !isPaused;
            }
        });

        function moveBall() {
            if (!isPaused) {
                ballX += ballSpeedX;
                ballY += ballSpeedY;

                if (ballY <= 0 || ballY >= 390) {
                    ballSpeedY *= -1;
                }

                if (ballX < 0 || ballX > 790) {
                    if (ballX < 0) {
                        // Paddle left missed the ball
                        alert("PUUNTOOOO para el jugador DOOOS!!");
                    } else {
                        // Paddle right missed the ball
                        alert("PUUNTOOOO para el jugador UNOOO!!");
                    }
                    reset();
                }

                // Detectar colisión con las paletas
                if (ballX < 20 && ballY + 10 >= paddleLeft.offsetTop && ballY <= paddleLeft.offsetTop + 80) {
                    ballSpeedX *= -1;
                }

                if (ballX > 770 && ballY + 10 >= paddleRight.offsetTop && ballY <= paddleRight.offsetTop + 80) {
                    ballSpeedX *= -1;
                }
            }
        }

        function movePaddles() {
            if (isPaused) return;

            if (paddleLeft.offsetTop >= 0 && keysState.w) {
                paddleLeft.style.top = paddleLeft.offsetTop - paddleSpeed + "px";
            }
            if (paddleLeft.offsetTop <= 320 && keysState.s) {
                paddleLeft.style.top = paddleLeft.offsetTop + paddleSpeed + "px";
            }
            if (paddleRight.offsetTop >= 0 && keysState.ArrowUp) {
                paddleRight.style.top = paddleRight.offsetTop - paddleSpeed + "px";
            }
            if (paddleRight.offsetTop <= 320 && keysState.ArrowDown) {
                paddleRight.style.top = paddleRight.offsetTop + paddleSpeed + "px";
            }
        }

        function update() {
            ball.style.left = ballX + "px";
            ball.style.top = ballY + "px";
        }

        function updateKeysState(event, isPressed) {
            if (event.key in keysState) {
                keysState[event.key] = isPressed;
            }
        }

        function reset() {
            ballX = 395;
            ballY = 195;
        }

        var keysState = {
            w: false,
            s: false,
            ArrowUp: false,
            ArrowDown: false
        };

        setInterval(function () {
            moveBall();
            movePaddles();
            update();
        }, 10);

        document.addEventListener("keydown", function (event) {
            updateKeysState(event, true);
        });

        document.addEventListener("keyup", function (event) {
            updateKeysState(event, false);
        });
    </script>
</body>

</html>