using System.ComponentModel.DataAnnotations;

namespace Core.Models;

public class Revisao()
{
  [Key]
  public int Id {get;set;}
  public string Conceito {get;set;}
  public MotivoDoErroEnum MotivoDoErro {get;set;}
  public DateTime DataDaCorrecao  {get;set;}
public DateTime Revisao1 { get; set; }
public bool Revisao1Check { get; set; } = false;

public DateTime Revisao2 { get; set; }
public bool Revisao2Check { get; set; }= false;

public DateTime Revisao3 { get; set; }
public bool Revisao3Check { get; set; }= false;

public DateTime Revisao4 { get; set; }
public bool Revisao4Check { get; set; }= false;

public DateTime Revisao5 { get; set; }
public bool Revisao5Check { get; set; }= false;

}

public enum MotivoDoErroEnum
{
  Pegadinha, Raciocinio, Conhecimento
}
