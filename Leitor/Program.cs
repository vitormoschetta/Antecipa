using Leitor;

var fila = ServiceCollections.GetQueue();

var banco = ServiceCollections.GetDatabase();

var processo = new Processo(fila, banco);

processo.Execute("fila");