using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera_interface.Clases
{
    public class Billetera : IBilletera
    {
        private int[,] billetes = new int[7, 2];
        public Billetera()
        {
            billetes[0, 1] = 10;
            billetes[1, 1] = 20;
            billetes[2, 1] = 50;
            billetes[3, 1] = 100;
            billetes[4, 1] = 200;
            billetes[5, 1] = 500;
            billetes[6, 1] = 1000;

        }
        public int billetesDe10
        {
            get { return billetes[0, 0]; }
            set { billetes[0, 0] = value; }
        }
        public int billetesDe20
        {
            get { return billetes[1, 0]; }
            set { billetes[1, 0] = value; }
        }
        public int billetesDe50
        {
            get { return billetes[2, 0]; }
            set { billetes[2, 0] = value; }
        }
        public int billetesDe100
        {
            get { return billetes[3, 0]; }
            set { billetes[3, 0] = value; }
        }
        public int billetesDe200
        {
            get { return billetes[4, 0]; }
            set { billetes[4, 0] = value; }
        }
        public int billetesDe500
        {
            get { return billetes[5, 0]; }
            set { billetes[5, 0] = value; }
        }
        public int billetesDe1000
        {
            get { return billetes[6, 0]; }
            set { billetes[6, 0] = value; }
        }

        public decimal Total()
        {

            decimal total = 0;
            for (int i = 0; i < billetes.GetLength(0); i++)
            {
                total += billetes[i, 1] * billetes[i, 0];
            }
            return total;

        }
        public Billetera Combinar(Billetera b)
        {
            var nuevaB = new Billetera();
            for (int i = 0; i < billetes.GetLength(0); i++)
            {
                nuevaB.billetes[i, 0] = billetes[i, 0] + b.billetes[i, 0];
            }
            //Se combina las billeteras

            return nuevaB;
        }
        public void vaciar()
        {
            for (int i = 0; i < billetes.GetLength(0); i++)
            {
                billetes[i, 0] = 0;
            }
        }
    }
}
