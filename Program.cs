using MinimalAPIPeliculas.Entidades;
var builder = WebApplication.CreateBuilder(args);
var apellido = builder.Configuration.GetValue<string>("apellido");
//inicio del área de los servicios

//Fin del área de los servicios
var app = builder.Build();
//inicio de área de los mildware


app.MapGet("/", () => apellido);
app.MapGet("/otra-cosa", () => "otra-cosa");

app.MapGet("/generos", () =>
{
    var generos = new List<Genero>
    {
        new Genero
        {
            Id = 1,
            Nombre ="drama"
        },
        new Genero
        {
            Id = 2,
            Nombre ="Acción"
        },
        new Genero
        {
            Id = 3,
            Nombre ="Comedia"
        },
    };

    return generos;
});
//fin del área de los mildware
app.Run();
