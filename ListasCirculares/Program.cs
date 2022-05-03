using ListasCirculares;

Lista listas = new Lista();
listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Tres");
Console.WriteLine(listas.RecorrerLista());

Console.WriteLine("-------Buscando Uno---------");
Nodo nodoBusqueda = listas.Buscar("Uno");
Console.WriteLine(nodoBusqueda.Valor);


Console.WriteLine("-------Buscando Tres--------");
Nodo nodoDos = listas.Buscar("Tres");
Console.WriteLine(nodoDos.Valor);

Console.WriteLine("-------Borrando Tres--------");
listas.BorrarNodo("Tres");
Console.WriteLine(listas.RecorrerLista());