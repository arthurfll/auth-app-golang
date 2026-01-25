using System.ComponentModel.DataAnnotations;

namespace Core.Models;

public class Revisao
{
    [Key]
    public int Id { get; set; }
    public string UserId {get;set;}
    public string Conceito { get; set; }
    public string Link {get;set;}
    public MotivoDoErroEnum MotivoDoErro { get; set; }

    private DateTime _dataDaCorrecao;
    public DateTime DataDaCorrecao
    {
        get => _dataDaCorrecao;
        set
        {
            _dataDaCorrecao = value;

            Revisao1 = value.AddDays(1);
            Revisao2 = value.AddDays(3);
            Revisao3 = value.AddDays(7);
            Revisao4 = value.AddDays(14);
            Revisao5 = value.AddDays(30);
        }
    }

    public DateTime Revisao1 { get; private set; }
    public bool Revisao1Check { get; set; } = false;

    public DateTime Revisao2 { get; private set; }
    public bool Revisao2Check { get; set; } = false;

    public DateTime Revisao3 { get; private set; }
    public bool Revisao3Check { get; set; } = false;

    public DateTime Revisao4 { get; private set; }
    public bool Revisao4Check { get; set; } = false;

    public DateTime Revisao5 { get; private set; }
    public bool Revisao5Check { get; set; } = false;
}

public enum MotivoDoErroEnum
{
    Pegadinha,
    Raciocinio,
    Conhecimento
}
