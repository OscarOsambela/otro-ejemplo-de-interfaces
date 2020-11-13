using System;

class AvisosTrafico:IAvisos{
  //campos de clase no tiene ninguna relacion con los nombre de los parametros abajo mencionados a pesar de tener el mismo nombre
  //pudieron llamarse de manera distinta solo es para efectos de este ejercicio
  private string remitente;
  private string mensaje;
  private string fecha;

  public AvisosTrafico(){
    remitente = "SAT";
    mensaje = "Sanción cometida. Pague antes de 3 días y obtendrá beneficio.";
    fecha = "";
  }
  public AvisosTrafico(string remitente, string mensaje, string fecha){
    this.remitente = remitente;
    this.mensaje = mensaje;
    this.fecha = fecha;
  }
  public string GetFecha(){
    return fecha;
  }
  public void MostrarAvisos(){
    Console.WriteLine("Mensaje: {0} Ha sido enviado por {1} el día: {2}", mensaje, remitente, fecha);
  }

}