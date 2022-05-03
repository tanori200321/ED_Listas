using ListasDobleMenteLigadasCirculares;


Console.WriteLine("-------------------------------------");
Lista listas = new Lista();
listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Cinco");
Console.WriteLine(listas.RecorrerLista());
Console.WriteLine("-------------------------------------");
Console.WriteLine("··········Buscando Cinco·············");
Nodo nodoBusqueda = listas.Buscar("Cinco");
Console.WriteLine(nodoBusqueda.NodoSiguiente.Valor);
Console.WriteLine("-------------------------------------");
Console.WriteLine("··········Buscando Dos···············");
Nodo nodoDos = listas.Buscar("Dos");
Console.WriteLine(nodoDos.Valor);
Console.WriteLine("-------------------------------------");
Console.WriteLine("··········Borrando Dos···············");
listas.BorrarNodo("Dos");
Console.WriteLine(listas.RecorrerLista());
Console.WriteLine("-------------------------------------");