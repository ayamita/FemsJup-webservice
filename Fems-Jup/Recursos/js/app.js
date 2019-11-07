$(document).ready(function(){
   $("#btnSearch").click(function(){
        // obtenemos la información de la UI
        var obj = {
            PersonId: 0,
            FirstName: $("#txtFirstName").val(),
            LastName: $("#txtLastName").val(),
            PhoneNumber: $("#txtPhoneNumber").val(),
            Address: $("#txtAddress").val(),
            Country: $("#txtCountry").val(),
            Age: $("#txtAge").val() === "" ? 0 : $("#txtAge").val()
        };
        // Realizamos la Petición web
        //let url = "http://localhost/techclubapi/PersonWS.asmx/Get";
   let url = "http://localhost:8083/TechClubApi/PersonWS.asmx/Get";

 	$.ajax({
	//regresa datos primitivos
	type:"POST",
	url:url,
   //data:{},
   data:JSON.stringify({obj:obj}),//nombre de parametro que recibe debe ser el mismo que del metodo primera variable
	contentType:"application/json; charset=utf-8",
	dataType:"JSON",
	success:function(data){
      //alert(data.d);
      var lstperson = data.d;
      var table = '<table class="table table-hover table-condensed table-bordered">' + 
      '<thead><tr>'+
      '<th>#</th><th>firstName</th><th>LastName</th><th>Age</th><th>Phone Number</th><th>Address</th><th>Country</th>'+
      '</tr></thead>'+
      '<tbody>';

      $.each(lstperson, function(i, item){
         let index = i + 1;
         table += "<tr>";
         table += "<th> "+ index +"</th>";
         table += "<th>"+ item.FirstName +"</th>";
         table += "<th>"+ item.LastName +"</th>";
         table += "<th>"+ item.Age +"</th>";
         table += "<th>"+ item.PhoneNumber+"</th>";
         table += "<th>"+ item.Address +"</th>";
         table += "<th>"+ item.Country+"</th>";
         table += "</tr>"
      });

      table += '</tbody></table>';

      $("#dvResults").html(table);

	},
	error:function(xmlHttpResquest, textStatus, erroThrow){
		alert("Te pinto un zorro :p")
		console.log(xmlHttpResquest.responseText);
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