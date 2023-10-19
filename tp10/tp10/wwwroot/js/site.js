
    function MostrarSeries(IdS)
    {
        $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url:'/Home/verDetalleSerie',
            data: {IdSerie:IdS},
            success:
            function(response){
                console.log(response.nombre);
                $("#Nombre").html(response.nombre);
                $("#info").html("Año de inicio: " + response.añoInicio + "</br>" + "sinopsis: "  + response.sinopsis);
        
               
            }
        });
    }


    ///////////////////////////////////////////////////
    function MostrarTemporada(IdSerie)
    {
        $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url:'/Home/verTemporada',
            data: {IdSerie:IdSerie},
            success:
            function(response)
            {
                console.log(response)

                 let temporadasHtml = '';
                 for (let i = 0; i < response.lenght; i++) {
                   temporadasHtml += response[i].numeroTemporada + ' - ' + response[i].tituloTemporada + '</br>';
                 }

                $("#info").html(temporadasHtml);
                $("#nombreModal").html("temporadas");
                
            }
            }
        );
    }

       
        
    
