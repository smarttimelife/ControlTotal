using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
 
namespace ModelCartera
 { 
public  class documentacion
 { 
//Atributos de clase
public  int  Id { get; set; } 
public  DateTime  Fecha { get; set; } 
public  string  Operacion { get; set; } 
public  string  IdAdjudicacion { get; set; } 
public  string  UsuarioEnvio { get; set; } 
public string ComentariosEnvio { get; set; } 
public  string  UsuarioRecibe { get; set; } 
public  DateTime  FechaRecibe { get; set; } 
public  DateTime  FechaCierre { get; set; } 
public  string  Estado { get; set; } 
public string ComentariosRecibe { get; set; } 
 } 
 } 
