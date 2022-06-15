
const nombreInput = document.getElementById("nombre");
const apellidoInput = document.getElementById("apellido");
const nacimientoInput = document.getElementById("nacimiento");
const edadInput = document.getElementById("edad");
const enviarButton = document.getElementById("enviar");
const limpiarButton = document.getElementById("limpiar");
const formulario = document.getElementById("form");
const provinciaSelect = document.getElementById("provincia");




window.onload = () => {
    nacimientoInput.onchange= calcular;
    enviarButton.onclick= enviar;
    limpiarButton.onclick= limpiar;
    consumirApi();
}




const calcular = () => {
    edadInput.value = CalcularEdad(nacimientoInput.value)
}

const enviar = () => {
    if(nombreInput.value.length>0 && apellidoInput.value.length>0 && nacimientoInput.value.length>0){
        window.alert("Su solicitud ha sido enviada")
    }
    else{
        window.alert("hay campos sin completar")
    }
    
}

const limpiar = () => {
    formulario.reset();
}

const agregar = (provincia) => {
    const option = document.createElement('option');
    option.text = provincia;
    provinciaSelect.appendChild(option);
  }


function CalcularEdad(nacimiento) {
    let fechaActual = new Date();
    let Nacimiento = new Date(nacimiento);
    let age = fechaActual.getFullYear() - Nacimiento.getFullYear();
    let m = fechaActual.getMonth() - Nacimiento.getMonth();
    if (m < 0 || (m === 0 && fechaActual.getDate() < Nacimiento.getDate())) {
        age--;
    }
    return age;
}


const consumirApi = () => {
    fetch('https://apis.datos.gob.ar/georef/api/provincias')
    .then(response => response.json())
    .then(data => {
        data.provincias.forEach(e => {
        agregar(e.nombre);
        });
  })
}