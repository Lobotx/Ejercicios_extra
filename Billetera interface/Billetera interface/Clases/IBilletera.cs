namespace Billetera_interface.Clases
{
    public interface IBilletera
    {
        int billetesDe10 { get; set; }
        int billetesDe100 { get; set; }
        int billetesDe1000 { get; set; }
        int billetesDe20 { get; set; }
        int billetesDe200 { get; set; }
        int billetesDe50 { get; set; }
        int billetesDe500 { get; set; }

        IBilletera Combinar(IBilletera b);
        decimal Total();
        void vaciar();
    }
}