using System;
using System.Collections.Generic;

namespace CRM;

public partial class Client
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? State { get; set; }

    public decimal? Tva { get; set; }

    public decimal? TotalCaHt { get; set; }

    public string? Comment { get; set; }

    public virtual List<Order> Orders { get; } = new List<Order>();
    public Client()
    {

    }
    public Client(int Id,string Name,bool State,decimal Tva,decimal TotalCaHt,string Comment)
    {
        this.Id=Id;
        this.Name=Name;
        this.State=State;
        this.Tva=Tva;
        this.TotalCaHt=TotalCaHt;
        this.Comment=Comment;
    }
}   
