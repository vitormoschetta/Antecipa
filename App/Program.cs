using App;
using App.Services;

Console.WriteLine("Entre com um texto: ");
var text = Console.ReadLine();
var fila = "teste.txt";

var queue = ServiceCollections.GetQueue();

var processo = new Processo(queue);

processo.Execute(text, fila);