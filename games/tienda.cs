<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Games Venado Tuerto</title>
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Lobster&family=Maven+Pro&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" integrity="sha512-iecdLmaskl7CVkqkXNQ/ZH/XLlvWZOJyj7Yy7tcenmpD1ypASozpmT/E0iPtmFIB46ZmdtAc9eNBvH0H/ZpiBw==" crossorigin="anonymous" referrerpolicy="no-referrer" />
</head>
<style>
@import url('https://fonts.googleapis.com/css2?family=Lobster&family=Maven+Pro&display=swap');
*{
    margin: 0;
    padding: 0;
    font-family: 'Maven Pro';
    color: rgb(25, 39, 51);
}
h1{
    color: rgb(204, 160, 110);
    text-shadow: 2px 2px 4px black;
    font-family: Lobster;
    text-align: center;
    font-size: 80px;
}
header{
    background: linear-gradient(to top, rgba(206, 165, 42, 0.11),
    rgba(83, 64, 12, 0.685));
    background-size: cover;
    background-position: center;
    height: 300px;
    width: 100%;
}
.contenedor{
    width: 100%;
    padding: 50px 20px;
    background-color: rgb(111, 140, 206);
    margin: auto;
    display: flex;
    justify-content: space-between;
    contain: paint;
}
.contenedor .contenedor-items{
    margin-top: 30px;
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(220px, 1fr));
    grid-gap: 30px;
    grid-row-gap: 30px;
    width: 100%;
    transition: .3s;
}
.contenedor .contenedor-items .items{
    max-width: 200px;
    padding:  0 40px ;
    margin: auto;
    background-color: rgb(23, 125, 214);
    border: 1px solid rgba(0, 0, 0, 0.911);
    border-radius: 10px;
    padding: 20px;
    transition: .3s;
}
.contenedor .contenedor-items .items:hover{
    box-shadow: 0 0 27px #a1df84;
    scale: 1.05;
}
.contenedor .contenedor-items .items .img-item{
    width: 100%;
    display: flex;
    flex-direction: column;
    margin: 0 15px 15px 0;
    align-items: center;
    justify-content: center;
    transition: .3s;
}
.contenedor .contenedor-items .items .titulo-item{
    display: block;
    font-weight: bold;
    text-align: center;
    text-transform: uppercase;
    font-size: 13px;
}
.contenedor-items .items .precio-item{
    display: block;
    text-align: center;
    font-size: 20px;
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    text-decoration: solid;
}
.contenedor-items .items .boton-item{
    display: block;
    margin: 10px auto;
    border: solid rgba(7, 53, 13, 0.582);
    background-color: #58a336;
    color: black;
    padding: 5px 15px;
    border-radius: 4px;
    cursor: pointer;
    width: 50px;
    height: 25px;
    padding: 0 10px;
    /*box-shadow:0 0 7px #a1df84;*/
}
.contenedor-items .items .boton-item i{
    color: rgb(17, 63, 8);
}
/*carro*/
.carro{
    border: 1px solid black;
    width: 35%;
    margin-top: 30px;
    border-radius: 15px;
    overflow: hidden;
    margin-bottom: auto;
    position: sticky !important;
    top: 0;
    transition: .3s;
    opacity: 0;
    margin-right: -100%;
}
.carro .cabezal-carro{
    background-color: #58a336;
    text-align: center;
    padding: 30px 0;
}
.carro .carro-items{
    display: flex;
    flex-direction: column;/*esto se lo agregue yo, en el original no esta*/
    align-items: center;
    position: relative;
    border-bottom: 1px solid wheat;
    padding: 20px 0;
}
.carro .carro-items img{
    margin-right: 20px;
    padding: 0 20px 0;
}
.carro .carro-items .carro-items-titulo{
    display: block;
    font-weight: bold;
    margin-bottom: 10px;
    text-transform: uppercase;
}
.carro .carro-items .selector-cantidad{
    display: inline-block;
    margin-right: 25px;
}
.carro .carro-items .carro-cantidad{
    border: none;
    font-size: 18px;
    background: transparent;
    display: inline-block;
    width: 30px;
    padding: 5px;
    text-align: center;
}
.carro .carro-items .selector-cantidad i{
    font-size: 18px;
    width: 32px;
    height: 32px;
    line-height: 32px;
    text-align: center;
    border-radius: 50%;
    border: 1px solid black;
    cursor: pointer;
}
.carro .carro-items .carro-precio{
    font-weight: bold;
    display: inline-block;
    font-size: 18px;
    margin-bottom: 5px;
}
.carro .carro-items .bt-eliminar {
    position: relative;
    right: 16px;
    top: 16px;
    width: 30px;
    height: 30px;
    line-height: 30px;
    text-align: center;
    border-radius: 50%;
    border: 1px solid black;
    cursor: pointer;
    display: block;
    background: transparent;
    z-index: 20;
}
.carro .carro-items .bt-eliminar i{
    pointer-events: none;
    color: #58a336;
}
.carro-total{
    padding: 30px;
    background-color: bisque;
}
.carro-total .fila{
    display: flex;
    justify-content: space-between;
    align-items: center;
    font-size: 10px;
    font-weight: bold;
    margin-bottom: 10px;
}
.carro-total .btn-pagar{
    display: block;
    width: 100%;
    border: none;
    background: yellow;
    color: violet;
    border-radius: 5px;
    font-size: 18px;
    padding: 20px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    cursor: pointer;
    transition: .3s;
}
.carro-total .btn-pagar:hover{
    scale: 1.05;
}
/*responsive */
@media screen and (max-width: 850px){
    .contenedor{
        display: block;
    }
    .contenedor-items{
        width: 100% !important;
    }
    .carro{
        width: 100% !important;
    }
}

</style>
<body>
    <header>
        <h1>Games Venado Tuerto</h1>
    </header>
    <!--elementos-->
    <section class="contenedor">
        <div class="contenedor-items">
            <div class="items">
                <span class="titulo-item">Grand Theft Auto IV</span>
                <img src="gtaiv.jpg" alt="" class="img-item">
                <span class="precio-item">$250,00</span>
                <button class="boton-item"><i class="fa-solid fa-cart-arrow-down"></i></button>
            </div>
            <div class="items">
                <span class="titulo-item">Doom 3</span>
                <img src="doom.jpg" alt="" class="img-item">
                <span class="precio-item">$120,01</span>
                <button class="boton-item"><i class="fa-solid fa-cart-arrow-down"></i></button>
            </div>
            <div class="items">
                <span class="titulo-item">Half Life 2</span>
                <img src="hf.jpg" alt="" class="img-item">
                <span class="precio-item">$170,00</span>
                <button class="boton-item"><i class="fa-solid fa-cart-arrow-down"></i></button>
            </div>
            <div class="items">
                <span class="titulo-item">Crysis</span>
                <img src="crys.jpg" alt="" class="img-item">
                <span class="precio-item">$250,00</span>
                <button class="boton-item"><i class="fa-solid fa-cart-arrow-down"></i></button>
            </div>
            <div class="items">
                <span class="titulo-item">Fallout 3</span>
                <img src="fall.jpg" alt="" class="img-item">
                <span class="precio-item">$174,00</span>
                <button class="boton-item"><i class="fa-solid fa-cart-arrow-down"></i></button>
            </div>
            <div class="items">
                <span class="titulo-item">F.E.A.R</span>
                <img src="fear.jpg" alt="" class="img-item">
                <span class="precio-item">$250,00</span>
                <button class="boton-item"> <i class="fa-solid fa-cart-arrow-down"></i></button>
            </div>
            <div class="items">
                <span class="titulo-item">Gear of War</span>
                <img src="gear.jpg" alt="" class="img-item">
                <span class="precio-item">$123,00</span>
                <button class="boton-item"> <i class="fa-solid fa-cart-arrow-down"></i></button>
            </div>
            <div class="items">
                <span class="titulo-item">The Elder Scrolls IV Oblivion</span>
                <img src="tes.jpg" alt="" class="img-item">
                <span class="precio-item">$230,00</span>
                <button class="boton-item"><i class="fa-solid fa-cart-arrow-down"></i></button>
            </div>
        </div>
        <!--carro de compras-->
        <div class="carro">
            <div class="cabezal-carro">
                <h2>Carro</h2>
            </div>
            <div class="carro-items">
                <!--
                <div class="compra-items">
                    <img src="gtaiv.jpg" alt="" width="60px">
                    <div class="compra-item-detalle">
                        <span class="carro-items-titulo">Grand Theft Auto IV</span>
                        <div class="selector-cantidad">
                            <i class="fa-solid fa-minus restar-cantidad"></i>
                            <input type="text" value="1" class="carro-cantidad" disabled>
                            <i class="fa-solid fa-plus sumar-cantidad"></i>
                        </div>
                        <sapn class="carro-precio">$250,00</sapn>
                    </div>
                    <span class="bt-eliminar">
                        <i class="fa-solid fa-trash"></i>
                    </span>
                </div>
                <div class="compra-items">
                    <img src="doom.jpg" alt="" width="60px">
                    <div class="compra-item-detalle">
                        <span class="carro-items-titulo">Doom 3</span>
                        <div class="selector-cantidad">
                            <i class="fa-solid fa-minus restar-cantidad"></i>
                            <input type="text" value="1" class="carro-cantidad" disabled>
                            <i class="fa-solid fa-plus sumar-cantidad"></i>
                        </div>
                        <sapn class="carro-precio">$120,01</sapn>
                    </div>
                    <span class="bt-eliminar">
                        <i class="fa-solid fa-trash"></i>
                    </span>
                </div>
                -->
            </div>
            <div class="carro-total">
                <div class="fila">
                    <strong>Total</strong>
                    <span class="carro-precio-total">
                        $120.000,00
                    </span>
                </div>
                <button class="btn-pagar">Comprar <i class="fa-solid fa-money-bill"></i></button>
            </div>
        </div>
    </section>
</body>
<script>
//variables para mantener el estado del carro
var carroVer = false;

if (document.readyState== 'loading'){
    document.addEventListener('DOMContentLoaded', ready)
} else {
    ready();
}

function ready(){
    //funcion para boton de eliminar
    var botonDelet = document.getElementsByClassName ('bt-eliminar');
    for (var i =0; i<botonDelet.length; i++){
        var button = botonDelet[i];
        button.addEventListener('click', elimnaritemdelcarro);
    }
var botonesSumar= document.getElementsByClassName('fa-solid fa-plus sumar-cantidad');
    for (var i=0; i<botonesSumar.length; i++){
        var button = botonesSumar[i];
        button.addEventListener('click', sumarCantidad);

    }
var botonesRestar= document.getElementsByClassName('fa-solid fa-minus restar-cantidad');
 for (var i=0; i<botonesRestar.length; i++){
    var button = botonesRestar[i];
    button.addEventListener('click', restarCantidad);
}
var agregaAlCarro = document.getElementsByClassName('botoan-item');
for (var i=0; i<agregaAlCarro.length; i++){
    var button = agregaAlCarro[i];
    button.addEventListener('click', agregarAlCarroClicked);
}
document.getElementsByClassName('btn-pagar')[0].addEventListener('click', pagarClicked);
}
//funcino para sacar item del carro
function elimnaritemdelcarro(event){
    var botonClik = event.target;
    botonClik.parentElement.remove();
    //Actualizar el total
    actualizarTotal();
    ocultarCarro();
}
//function de datos para actualizar el carro
function actualizarTotal(){
    var contenderoCarro= document.getElementsByClassName('carro')[0];
    var carroitems = contenderoCarro.getElementsByClassName ('carro-items');
    var total= 0;
    for (var i=0; i<carroitems.length;i++){
        var produc=carroitems[i];
        var precioelem= produc.getElementsByClassName('carro-precio')[0];
        console.log (precioelem);
        var precio = parseFloat(precioelem.innerText.replace('$','').replace('.',''));
        //console.log(precio);
        var cantidadItem= contenderoCarro.getElementsByClassName('selector-cantidad')[0];
        var cantidad= parseInt(cantidadItem.value);
        //console.log (cantidad);
        total= total + (precio*cantidad);
    }
    total=Math.round(total*100)/100;
    document.getElementsByClassName('carro-precio-total')[0].innerText = '$'+ total.toLocaleString('es')+',00';
}
function ocultarCarro(){
    var carro = document.getElementsByClassName('carro-items')[0];
    if(carro.childElementCount == 0){
        var carrito=document.getElementsByClassName('carro')[0];
        carrito.style.marginRight= '-100%';
        carrito.style.opacity= '0';
        carroVer = false;
    var item= document.getElementsByClassName('contenedor-items')[0];
    item.style.width= '100%';
    }
}
function sumarCantidad(event){
    var botonClik= event.target;
    var selector =botonClik.parentElement;
    var CantidadActual= selector.getElementsByClassName('carro-cantidad')[0].value;
    CantidadActual++;
    selector.getElementsByClassName('carro-cantidad')[0].value= CantidadActual;
    actualizarTotal();
}
function restarCantidad(event){
    var botonClik= event.target;
    var selector =botonClik.parentElement;
    var CantidadActual= selector.getElementsByClassName('carro-cantidad')[0].value;
    CantidadActual--;
    if (CantidadActual>=1){
    selector.getElementsByClassName('carro-cantidad')[0].value= CantidadActual;
    actualizarTotal();
}
}
function agregarAlCarroClicked(event){
    var botonClik= event.target;
    var item = botonClik.parentElement;
    var titulo = item.getElementsByClassName('titulo-item')[0].innerText;
    var precio = item.getElementsByClassName('precio-item')[0].innerText;
    var imagen = item.getElementsByClassName('img-item')[0].src;
    agregarItemAlCarrito(titulo, precio, imagen);
    HacerVisibleElCarro();
}
function agregarItemAlCarrito (titulo, precio, imagen){
    var item = document.createElement('div');
    item.classList.add('items');
    var itemsCarrito = document.getElementsByClassName('carro-items')[0];
    var nombreItemsCarro = itemsCarrito.getElementsByClassName('titulo-item');
    for (var i=0; i<nombreItemsCarro.length; i++){
        if(nombreItemsCarro[i].innerText == titulo){
            alert('Este producto ya esta en el carro');
            return;
        }
    }
    var itemesContenidoDelCarro =` <div class="compra-items">
    <img src="${imagen}" alt="" width="60px">
    <div class="compra-item-detalle">
        <span class="carro-items-titulo">${titulo}</span>
        <div class="selector-cantidad">
            <i class="fa-solid fa-minus restar-cantidad"></i>
            <input type="text" value="1" class="carro-cantidad" disabled>
            <i class="fa-solid fa-plus sumar-cantidad"></i>
        </div>
        <sapn class="carro-precio">${precio}</sapn>
    </div>
    <span class="bt-eliminar">
        <i class="fa-solid fa-trash"></i>
    </span>
</div>`
    item.innerHTML= itemesContenidoDelCarro;
    itemsCarrito.append(item);
    item.getElementsByClassName('bt-eliminar')[0].addEventListener('click', elimnaritemdelcarro);
    var botonSUmar= item.getElementsByClassName('fa-solid fa-plus sumar-cantidad')[0];
    botonSUmar.addEventListener('click', sumarCantidad);
    var botonRestar= item.getElementsByClassName('fa-solid fa-minus restar-cantidad')[0];
    botonRestar.addEventListener('click', restarCantidad);
}
function pagarClicked(event){
    alert('Gracias por su compra');
    var CarroItems = document.getElementsByClassName('carro-items')[0];
    while (CarroItems.hasChildNodes()){
        CarroItems.removeChild(CarroItems.firstChild);
    }
    actualizarTotal();
    ocultarCarro();
}
function HacerVisibleElCarro(){
    carroVer = true;
    var carrito=document.getElementsByClassName('carro')[0];
    carrito.style.marginRight= '0';
    carrito.style.opacity= '1';
    var item= document.getElementsByClassName('contenedor-items')[0];
    item.style.width= '60%';
}

</script>
</html>
