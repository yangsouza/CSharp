public class Carro
{
    public string Placa { get; set; }

    public string Descricao { get; set; }

    public Carro()
    {
        Placa = string.Empty;
        Descricao = string.Empty;
    }

    public Carro(string placa, string descricao)
    {
        Placa = placa;
        Descricao = descricao;
    }

    
}