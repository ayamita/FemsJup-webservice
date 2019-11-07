$(document).ready(function(){
   $("#btnConsulta").click(function(){
        // obtenemos la información de la UI
        var obj = {
            Id: 0,
            nombre: 0,
            apellidoM: 0,
            apellidoP:0,
            correo: 0,
            contrasenia: 0,
            id_tipousuario: 0,
            fotoperfil: 0,
            telefono: 0,
            iddireccion: 0,
            pais: 0,
            estado: 0,
            municipio: 0,
        };
        // Realizamos la Petición web
        //let url = "http://localhost/techclubapi/PersonWS.asmx/Get";
   let url = "http://localhost:51437/ConexionSQL.asmx/Mostrar";

 	$.ajax({
	//regresa datos primitivos
	type:"POST",
	url:url,
   //data:{},
   data:JSON.stringify({obj:obj}),//nombre de parametro que recibe debe ser el mismo que del metodo primera variable
	contentType:"application/json; charset=utf-8",
	dataType:"json",
	success:function(data){
      //alert(data.d);
      var lstperson = data.d;
      var table = '<table class="table table-hover table-condensed table-bordered">' + 
      '<thead><tr>'+
      '<th>#</th><th>nombre</th><th>apellido</th><th>apellidop</th><th>corre</th><th>contrasenia</th><th>tipousu</th><th>foto</th><th>telefono</th><th>direccion</th><th>pais</th><th>estado</th><th>municipiio</th>'+
      '</tr></thead>'+
      '<tbody>';

      $.each(lstperson, function(i, item){
         let index = i + 1;
         table += "<tr>";
         table += "<th> "+ index +"</th>";
         table += "<th>"+ item.nombre +"</th>";
         table += "<th>"+ item.apellidoM +"</th>";
         table += "<th>"+ item.apellidoP +"</th>";
         table += "<th>"+ item.correo+"</th>";
         table += "<th>"+ item.contrasenia +"</th>";
         table += "<th>"+ item.id_tipousuario+"</th>";
         table += "<th>"+ item.fotoperfil+"</th>";
         table += "<th>"+ item.telefono+"</th>";
         table += "<th>"+ item.iddireccion+"</th>";
         table += "<th>"+ item.pais+"</th>";
         table += "<th>"+ item.estado+"</th>";
         table += "<th>"+ item.municipio+"</th>";         
         table += "</tr>"
      });

      table += '</tbody></table>';

      $("#dvResults").html(table);

	},
	error:function(xmlHttpResquest, textStatus, erroThrow){
		alert("Te pinto un zorro :p")
		console.log(xmlHttpResquest,textStatus,erroThrow);
	}
});

       
   });

	
   $("#btnReset").click(function(){
        $("#txtFirstName").val("");
        $("#txtLastName").val("");
        $("#txtAge").val("");
        $("#txtPhoneNumber").val("");
        $("#txtAddress").val("");
        $("#txtCountry").val("");        
   });
	
  


});