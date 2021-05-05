
function validateForm() {
  var nombre = document.getElementById("fNombre").value;
  var apellido = document.getElementById("fApellido").value;
  if (nombre== "" || apellido=="") {
    alert("Faltan campos por rellenar");
    return false;
  }
}

function limpiarFormulario() {
  document.getElementById("formulario").reset();
}