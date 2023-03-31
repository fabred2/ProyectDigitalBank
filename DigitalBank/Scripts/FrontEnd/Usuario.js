class Usuario {
    setUser() {
        if ($("#nombre").val() == "") {
            alert("por favor ingrese el nombre del usuario");
            return false;
        }
        if ($("#fecha").val() == "") {
            alert("por favor ingrese la fecha de nacimiento del usuario");
            return false;
        }
        if ($("#genero").val() == "") {
            alert("por favor ingrese el género del usuario");
            return false;
        }
        var oData = {
            Nombre: $("#nombre").val(),
            FechaNacimiento: $("#fecha").val(),
            Sexo: $("#genero").val(),
        };
        $.ajax({
            type: 'GET',
            url: '../Home/setUsuario',
            data: oData,
            success: function (salida) {
                    $("#nombre").val(""),
                    $("#fecha").val(""),
                    $("#genero").val(""),
                    alert("usuario asignado correctamente");
            },
            error: function (ex) {
                alert("se ha producido un error en el registro del usuario");
            }
        });
    }

    UpdateUser(id) {
        
        var tabla = document.getElementById("tablaUsuarios");
        var filas = tabla.getElementsByTagName("tr");
        for (var i = 0; i < filas.length; i++) {
            var inputs = filas[i].getElementsByTagName("input");
            for (var j = 0; j < inputs.length; j++) {
                inputs[j].classList.add("baseTable");
                inputs[j].classList.remove("form-control");
                inputs[j].classList.remove("clearTable");
                inputs[j].readOnly = true;
            }
        }
        for (var i = 0; i < filas.length; i++) {
            var selects = filas[i].getElementsByTagName("select");
            for (var j = 0; j < selects.length; j++) {
                selects[j].classList.add("baseTable");
                selects[j].classList.remove("clearTable");
                selects[j].classList.remove("form-control");
                selects[j].disabled = true;
            }
        }


        for (var i = 0; i < filas.length; i++) {
            var selects = filas[i].getElementsByClassName("baseButton");
            for (var j = 0; j < selects.length; j++) {
                selects[j].style.display = "none";
            }
        }
        this.changeRow(id);
    }

   

    changeRow(id) {

        var gen_ = document.getElementById("genero_" + id);
        gen_.removeAttribute("disabled");
        gen_.classList.add("clearTable");
        gen_.classList.add("form-control");
        var nombre_ = document.getElementById("nombre_" + id);
        nombre_.removeAttribute("readonly")
        nombre_.classList.add("clearTable");
        nombre_.classList.add("form-control");
        var fecha_ = document.getElementById("fecha_" + id);
        fecha_.classList.add("clearTable");
        fecha_.classList.add("form-select");
        fecha_.removeAttribute("readonly")
        document.getElementById("save_" + id).style.display = "block";
    }


    DeleteUser(id) {
        var oData = {
            Id: id
        };
        $.ajax({
            type: 'GET',
            url: '../Home/DeleteUsuario',
            data: oData,
            success: function (salida) {
                window.location.reload();
            },
            error: function (ex) {
                alert("se ha producido un error en el registro del usuario");
            }
        });
    }

    SaveUser(id) {

        if ( $("#nombre_" + id).val() == "") {
            alert("por favor ingrese el nombre del usuario");
            return false;
        }
        
        if (  $("#fecha_" + id).val() == "") {
            alert("por favor ingrese la fecha de nacimiento del usuario");
            return false;
        }
        if ($("#genero_" + id).val() == "") {
            alert("por favor ingrese el género del usuario");
            return false;
        }
        var oData = {
            Id: id,
            Nombre: $("#nombre_"+id).val(),
            FechaNacimiento: $("#fecha_" + id).val(),
            Sexo: $("#genero_" + id).val(),
        };
        $.ajax({
            type: 'GET',
            url: '../Home/SaveUsuario',
            data: oData,
            success: function (salida) {
                alert("usuario actualizado correctamente");
                window.location.reload();
            },
            error: function (ex) {
                alert("se ha producido un error en el registro del usuario");
            }
        });

    }
}