using System;

class MainClass {
  public static void Main (string[] args) {
    AvisosTrafico av1 = new AvisosTrafico();
    av1.MostrarAvisos();
    AvisosTrafico av2 = new AvisosTrafico("Municipalidad de Surquillo", "Sanción en ejecución. Pague hasta el 2 de diciembre.", "31-12-2020");
    Console.WriteLine(av2.GetFecha());
    av2.MostrarAvisos();
  }
}